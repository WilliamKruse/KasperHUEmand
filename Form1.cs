using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Q42.HueApi;
using Q42.HueApi.ColorConverters;
using Q42.HueApi.ColorConverters.Original;
using Q42.HueApi.Interfaces;
using Newtonsoft.Json;
using System.Threading;
using System.Configuration;
using System.Collections.Specialized;
using System.Media;
using System.Xml.Linq;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using KasperHUEmand.Models;
using KasperHUEmand.Services;
namespace KasperHUEmand
{
    public partial class Form1 : Form
    {
        public LiveScoreService Service { get; set; } = new LiveScoreService();
        IBridgeLocator locator { get; set; }
        public string IP { get; set; } = ConfigurationManager.AppSettings.Get("lastipused");
        public string HueCode { get; set; } = ConfigurationManager.AppSettings.Get("huekey");
        public string GeneratedHueCode { get; set; } = "";
        public bool FormFirstTime { get; set; } = false;
        public string APIStatus { get; set; } = "API IKKE KALDT ENDNU";

        public bool ProcessRunning { get; set; } = true;

        public int UpdateCounter { get; set; } = 0;
        public System.Windows.Forms.Timer MyTimer { get; set; } = new System.Windows.Forms.Timer();
        public System.Windows.Forms.Timer MyTimer2 { get; set; } = new System.Windows.Forms.Timer();

        public bool StopPressedOnce { get; set; } = false;

        public SoundPlayer MusicBot { get; set; }
        public readonly Country[] QualifiedCountries = new Country[] { new Country("Danmark", "Denmark",0), new Country("Argentina", "Argentina",1), new Country("Australien", "Australia", 2), new Country("Belgien", "Belgium", 3), new Country("Brasillien", "Brazil", 4), new Country("Cameroon", "Cameroon", 5), new Country("Canada", "Canada", 6), new Country("Costa Rica", "Costa Rica", 7), new Country("Kroatien", "Croatia", 8), new Country("Ecuador", "Ecuador", 9), new Country("England", "England", 10), new Country("Frankrig", "France", 11), new Country("Ghana", "Ghana", 12), new Country("Holland", "Netherlands", 13), new Country("Iran", "Iran", 14), new Country("Japan", "Japan", 15), new Country("Mexico", "Mexico", 16), new Country("Morocco", "Morocco", 17), new Country("Polen", "Poland", 18), new Country("Portugal", "Portugal", 19), new Country("Qatar", "Qatar", 20), new Country("Saudi Arabien", "Saudi Arabia", 21), new Country("Senegal", "Senegal", 22), new Country("Serbien", "Serbia", 23), new Country("Syd Korea", "South Korea", 24), new Country("Spanien", "Spain", 25), new Country("Schweiz", "Switzerland", 26), new Country("Tunesien", "Tunesia", 27), new Country("Tyskland", "Germany", 28), new Country("Uruguay", "Uruguay", 29), new Country("USA", "USA", 30), new Country("Wales", "Wales", 31) };
        public string ChosenCountry { get; set; } = "Denmark";
        public int CountDownConnection { get; set; } = 20;
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            IPInput.Text = IP;
            HueHashInput.Text = HueCode;
            ChooseCountry.SelectedText = QualifiedCountries[0].ToString();
            ChooseCountry.SelectedItem = QualifiedCountries[0].Value;
            foreach (var item in QualifiedCountries)
            {
                ChooseCountry.Items.Add(item);
            }
           
            MusicBot = new SoundPlayer(Properties.Resources.Gulddreng);
            MusicBot.PlayLooping();
        }

        private async Task<bool> TestLights()
        {
            ILocalHueClient client = new LocalHueClient(IP);
            client.Initialize(HueCode);
            IEnumerable<Light> CurrentLights = await client.GetLightsAsync();
            var lysrød = new LightCommand();
            var lyshvid = new LightCommand();
            int count = 0;
            while (true)
            {
                await client.SendCommandAsync(lysrød.SetColor(new RGBColor("FF0000")));
                await Task.Delay(700);
                await client.SendCommandAsync(lyshvid.SetColor(new RGBColor("FFFFFF")));
                await Task.Delay(700);
                count++;
                if (count == 10)
                {
                    foreach (var lights in CurrentLights)
                    {
                        await client.SendCommandAsync(lysrød.SetColor(lights.ToRGBColor()), new List<string> { lights.Id });
                    }
                    break;
                }
            }
            return true;
        }
        private void VeryFirstTime()
        {
            Timer2();
        }
        private async void ContinousScoreCheck(string teamname)
        {
                ILocalHueClient client = new LocalHueClient(IP);
                client.Initialize(HueCode);
                IEnumerable<Light> CurrentLights = await client.GetLightsAsync();
            var lysrød = new LightCommand();
            var lyshvid = new LightCommand();

            while (ProcessRunning)
            {
                string goalchecker = "false";
                goalchecker = await Service.CheckIfGoalWasScored(teamname);
                if (goalchecker == "false")
                {
                    APIStatus = "true";
                }
                else if(goalchecker == "false")
                {
                    APIStatus = "true";
                }
                else
                {
                    APIStatus = goalchecker;
                }
                
                if (goalchecker == "true")
                {
                    int count = 0;
                    while (true)
                    {
                        await client.SendCommandAsync(lysrød.SetColor(new RGBColor("FF0000")));
                        await Task.Delay(700);
                        await client.SendCommandAsync(lyshvid.SetColor(new RGBColor("FFFFFF")));
                        await Task.Delay(700);
                        count++;
                        if (count == 10)
                        { 
                            foreach (var lights in CurrentLights)
                            {
                                await client.SendCommandAsync(lysrød.SetColor(lights.ToRGBColor()),new List<string> { lights.Id });
                            }
                            break;
                        }
                    }
                }
                await Task.Delay(2000);

            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (FormFirstTime)
            {
                VeryFirstTime();
                UpdateConfig("lastipused", IP);
            }
            else
            {
                StartButton.Enabled = false;
                ContinousScoreCheck(ChosenCountry);
                //Task.Run(() => ContinousScoreCheck(ChosenCountry));
                Timer();
                StopButton.Enabled = true;
                UpdateConfig("lastipused", IP);
                UpdateConfig("huekey", HueCode);
            }



        }
        private void Timer()
        {
            MyTimer.Interval = 2000;
            MyTimer.Tick += new EventHandler(UpdateStatusMSG);
            MyTimer.Start();
        }
   
        private void UpdateStatusMSG(object sender, EventArgs e)
        {
            CurrentStatus.Text = "Applikationen kører: " + APIStatus + ". Opdateret (" + UpdateCounter + ") gange.";
            UpdateCounter++;
        }

        private void Timer2()
        {
            NewGeneratedCode.Text = "Prøver at connecte til din HUE Bridge om (";
            MyTimer2.Interval = 1000;
            MyTimer2.Tick += new EventHandler(UpdateConnectionCoutdown);
            MyTimer2.Start();
        }
        private async void UpdateConnectionCoutdown(object sender, EventArgs e)
        {
            NewGeneratedCode.Text = "Prøver at connecte til din HUE Bridge om (" + CountDownConnection + ") sekunder, TRYK PÅ KNAPPEN PÅ DIN BRIDGE LIGE INDEN";
            CountDownConnection = CountDownConnection - 1;
            if (CountDownConnection == -1)
            {
                NewGeneratedCode.Text = "Connecting....";
                MyTimer2.Stop();
                locator = new HttpBridgeLocator();
                ILocalHueClient client1 = new LocalHueClient(IP);
                string salt = DateTime.UtcNow.ToShortTimeString().Replace(" ","");
                GeneratedHueCode = await client1.RegisterAsync("HUEmand"+ salt, "MinComputer");
                NewGeneratedCode.Text = "Her er din kode: (gem den et sted på din computer)(genstart derefter appen)";
                GeneratedHashCode.Text = GeneratedHueCode;
                IPInput.Enabled = false;
                checkBox1.Enabled = false;
                StartButton.Enabled = false;
                TestLightButton.Enabled = false;
                UpdateConfig("HueKey", GeneratedHueCode);
                CountDownConnection = 20;
                
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            switch (checkBox1.CheckState)
            {
                case CheckState.Checked:
                    {
                        HueHashInput.Enabled = false;
                        FormFirstTime = true;
                        break;
                    }
                case CheckState.Unchecked:
                    {
                        HueHashInput.Enabled = true;
                        FormFirstTime = false;
                        break;
                    }
            }



        }

        private void IPInput_TextChanged(object sender, EventArgs e)
        {
            IP = IPInput.Text;
        }

        private void HueKodeInput_TextChanged(object sender, EventArgs e)
        {
            HueCode = HueHashInput.Text;
        }


        private void STOPKNAPPEN_Click(object sender, EventArgs e)
        {
            ProcessRunning = false;
            MyTimer.Stop();
            CurrentStatus.Text = "Applikationen blev stoppet";
            StopButton.Enabled = false;
            StartButton.Enabled = true;
            UpdateCounter = 0;
            Application.Restart();
            Environment.Exit(0);

        }
        private void UpdateConfig(string key, string value)
        {
            var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            configFile.AppSettings.Settings[key].Value = value;
            configFile.Save(ConfigurationSaveMode.Full, true);
            ConfigurationManager.RefreshSection("appSettings");
        }

        private void SlukMusik_CheckedChanged(object sender, EventArgs e)
        {
            switch (ToogleMusic.CheckState)
            {
                case CheckState.Checked:
                    {
                        MusicBot.Stop();
                        break;
                    }
                case CheckState.Unchecked:
                    {
                        MusicBot.PlayLooping();
                        break;
                    }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            ChosenCountry = QualifiedCountries[ChooseCountry.SelectedIndex].Value;
        }

        private async void TestLys_Click(object sender, EventArgs e)
        {
            bool ready = await Task.Run(()=>TestLights());
            if (ready)
            {
                Application.Restart();
                Environment.Exit(0);
            }
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MusicBot.Stop();
            ToogleMusic.Checked = false;
            MusicBot = new SoundPlayer(Properties.Resources.Burhan);
            MusicBot.PlayLooping();
        }

        private void NATHOLDET_Click(object sender, EventArgs e)
        {
            MusicBot.Stop();
            ToogleMusic.Checked = false;
            MusicBot = new SoundPlayer(Properties.Resources.Natholdet);
            MusicBot.PlayLooping();
        }

        private void GULDDRENG_Click(object sender, EventArgs e)
        {
            MusicBot.Stop();
            ToogleMusic.Checked = false;
            MusicBot = new SoundPlayer(Properties.Resources.Gulddreng);
            MusicBot.PlayLooping();
        }

        private void UAK_Click(object sender, EventArgs e)
        {
            MusicBot.Stop();
            ToogleMusic.Checked = false;
            MusicBot = new SoundPlayer(Properties.Resources.UAK);
            MusicBot.PlayLooping();
        }
    }
    
}
