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
using System.Linq.Expressions;

namespace KasperHUEmand
{
    public partial class Form1 : Form
    {
        public SoccerService service { get; set; } = new SoccerService();
        IBridgeLocator locator { get; set; }
        IBridgeLocator locator1 { get; set; }
        IBridgeLocator locator2 { get; set; }
        public string IP { get; set; } = ConfigurationManager.AppSettings.Get("lastipused");
        public string HueCode { get; set; } = ConfigurationManager.AppSettings.Get("huekey");
        public string GeneratedHueCode { get; set; } = "";
        public bool FormFirstTime { get; set; } = false;
        public string APIStatus { get; set; } = "API IKKE KALDT ENDNU";

        public bool STOPKNAP { get; set; } = true;

        public int UpdateCounter { get; set; } = 0;
        public System.Windows.Forms.Timer MyTimer { get; set; } = new System.Windows.Forms.Timer();
        public System.Windows.Forms.Timer MyTimer2 { get; set; } = new System.Windows.Forms.Timer();

        public bool StopPressedOnce { get; set; } = false;

        public SoundPlayer NightCoreBot { get; set; }
        public readonly Land[] Lande = new Land[] { new Land("Danmark", "Denmark",0), new Land("Argentina", "Argentina",1), new Land("Australien", "Australia", 2), new Land("Belgien", "Belgium", 3), new Land("Brasillien", "Brazil", 4), new Land("Cameroon", "Cameroon", 5), new Land("Canada", "Canada", 6), new Land("Costa Rica", "Costa Rica", 7), new Land("Kroatien", "Croatia", 8), new Land("Ecuador", "Ecuador", 9), new Land("England", "England", 10), new Land("Frankrig", "France", 11), new Land("Ghana", "Ghana", 12), new Land("Holland", "Netherlands", 13), new Land("Iran", "Iran", 14), new Land("Japan", "Japan", 15), new Land("Mexico", "Mexico", 16), new Land("Morocco", "Morocco", 17), new Land("Polen", "Poland", 18), new Land("Portugal", "Portugal", 19), new Land("Qatar", "Qatar", 20), new Land("Saudi Arabien", "Saudi Arabia", 21), new Land("Senegal", "Senegal", 22), new Land("Serbien", "Serbia", 23), new Land("Syd Korea", "South Korea", 24), new Land("Spanien", "Spain", 25), new Land("Schweiz", "Switzerland", 26), new Land("Tunesien", "Tunesia", 27), new Land("Tyskland", "Germany", 28), new Land("Uruguay", "Uruguay", 29), new Land("USA", "USA", 30), new Land("Wales", "Wales", 31) };
        public string ChosenCountry { get; set; } = "Denmark";
        public int CountDownConnection { get; set; } = 20;
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            IPInput.Text = IP;
            HueKodeInput.Text = HueCode;
            comboBox1.SelectedText = Lande[0].ToString();
            comboBox1.SelectedItem = Lande[0].Value;
            foreach (var item in Lande)
            {
                comboBox1.Items.Add(item);
            }
           
            NightCoreBot = new SoundPlayer(Properties.Resources.Gulddreng);
            NightCoreBot.PlayLooping();
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
        private async void MainFunc(string teamname)
        {
                ILocalHueClient client = new LocalHueClient(IP);
                client.Initialize(HueCode);
                IEnumerable<Light> CurrentLights = await client.GetLightsAsync();
            var lysrød = new LightCommand();
            var lyshvid = new LightCommand();

            while (STOPKNAP)
            {
                string goalchecker = "false";
                goalchecker = await service.GetTheData(teamname);
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
                button1.Enabled = false;
                MainFunc(ChosenCountry);
                //Task.Run(() => MainFunc(ChosenCountry));
                Timer();
                STOPKNAPPEN.Enabled = true;
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
                locator1 = new HttpBridgeLocator();
                //var bridges1 = await locator1.LocateBridgesAsync(TimeSpan.FromSeconds(5));
                //bridges1 = await HueBridgeDiscovery.CompleteDiscoveryAsync(TimeSpan.FromSeconds(5), TimeSpan.FromSeconds(30));
                ILocalHueClient client1 = new LocalHueClient(IP);
                string salt = DateTime.UtcNow.ToShortTimeString().Replace(" ","");
                GeneratedHueCode = await client1.RegisterAsync("HUEmand"+ salt, "MinComputer");
                NewGeneratedCode.Text = "Her er din kode: (gem den et sted på din computer)(genstart derefter appen)";
                NewGeneratedCode2.Text = GeneratedHueCode;
                IPInput.Enabled = false;
                checkBox1.Enabled = false;
                button1.Enabled = false;
                TestLys.Enabled = false;
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
                        HueKodeInput.Enabled = false;
                        FormFirstTime = true;
                        break;
                    }
                case CheckState.Unchecked:
                    {
                        HueKodeInput.Enabled = true;
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
            HueCode = HueKodeInput.Text;
        }

        private void CurrentStatus_Click(object sender, EventArgs e)
        {

        }

        private void STOPKNAPPEN_Click(object sender, EventArgs e)
        {
            STOPKNAP = false;
            MyTimer.Stop();
            CurrentStatus.Text = "Applikationen blev stoppet";
            STOPKNAPPEN.Enabled = false;
            button1.Enabled = true;
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
            switch (SlukMusik.CheckState)
            {
                case CheckState.Checked:
                    {
                        NightCoreBot.Stop();
                        break;
                    }
                case CheckState.Unchecked:
                    {
                        NightCoreBot.PlayLooping();
                        break;
                    }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            ChosenCountry = Lande[comboBox1.SelectedIndex].Value;
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
            NightCoreBot.Stop();
            SlukMusik.Checked = false;
            NightCoreBot = new SoundPlayer(Properties.Resources.Burhan);
            NightCoreBot.PlayLooping();
        }

        private void NextSong_Click(object sender, EventArgs e)
        {
            NightCoreBot.Stop();
            SlukMusik.Checked = false;
            NightCoreBot = new SoundPlayer(Properties.Resources.Natholdet);
            NightCoreBot.PlayLooping();
        }

        private void GULDDRENG_Click(object sender, EventArgs e)
        {
            NightCoreBot.Stop();
            SlukMusik.Checked = false;
            NightCoreBot = new SoundPlayer(Properties.Resources.Gulddreng);
            NightCoreBot.PlayLooping();
        }

        private void UAK_Click(object sender, EventArgs e)
        {
            NightCoreBot.Stop();
            SlukMusik.Checked = false;
            NightCoreBot = new SoundPlayer(Properties.Resources.UAK);
            NightCoreBot.PlayLooping();
        }
    }
    public class Land
    {
        public string DisplayName { get; set; }
        public string Value { get; set; }
        public int Index { get; set; }
        public Land(string displayname, string value, int index)
        {
            this.DisplayName = displayname;
            this.Value = value;
            this.Index = index;
        }
        public override string ToString()
        {
            return this.DisplayName;
        }
    }

    public class SoccerService
    {
        public int Goals { get; set; } = 0;
        public bool firsttime { get; set; } = true;
        public SoccerService()
        {
            this.Goals = 0;
            this.firsttime = true;
        }


        public async Task<string> GetTheData(string teamname)
        {
            string status = "Kampen er ikke igang endnu";
            HttpClient cli = new HttpClient();
            const string url = "https://api.sofascore.com/api/v1/sport/football/events/live";
            var response = await cli.GetAsync(url);
            Console.WriteLine(response.StatusCode);
            var jsonString = await response.Content.ReadAsStringAsync();
            dynamic dyn = JsonConvert.DeserializeObject(jsonString);
            foreach (var obj in dyn.events)
            {
                if (obj.homeTeam.name == teamname)
                {
                    status = "hold fundet, kamp igang";
                    
                    if (obj.homeScore.current > Goals)
                    {
                        Console.WriteLine("Tidligere mål: " + Goals);
                        Console.WriteLine("Mål fra API: " + obj.homeScore.current);
                        Goals = obj.homeScore.current;
                        if (firsttime)
                        {
                            firsttime = false;
                            return "false";
                        }
                        Console.WriteLine("Danmark har scoret!!!");
                        return "true";
                    }
                }
                if (obj.awayTeam.name == teamname)
                {
                    status = "hold fundet, kamp igang";
                    if (obj.awayScore.current > Goals)
                    {
                        Console.WriteLine("Tidligere mål: " + Goals);
                        Console.WriteLine("Mål fra API: " + obj.awayScore.current);
                        Goals = obj.awayScore.current;
                        if (firsttime)
                        {
                            firsttime = false;
                            return "false";
                        }
                        Console.WriteLine("Danmark har scoret!!!");
                        return "true";
                    }
                }
            }

            return status;

        }
    }
}
