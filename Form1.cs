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

namespace KasperHUEmand
{
    public partial class Form1 : Form
    {
        public SoccerService service { get; set; } = new SoccerService();
        public string IP { get; set; } = ConfigurationManager.AppSettings.Get("lastipused");
        public string HueCode { get; set; } = ConfigurationManager.AppSettings.Get("huekey");
        public string GeneratedHueCode { get; set; } = "";
        public bool FormFirstTime { get; set; } = false;
        public string APIStatus { get; set; } = "API IKKE KALDT ENDNU";

        public bool STOPKNAP { get; set; } = true;

        public int UpdateCounter { get; set; } = 0;
        public System.Windows.Forms.Timer MyTimer { get; set; } = new System.Windows.Forms.Timer();

        public bool StopPressedOnce { get; set; } = false;
       
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            IPInput.Text = IP;
            HueKodeInput.Text = HueCode;
        }

        private async void MainFunc()
        {
                IBridgeLocator locator = new HttpBridgeLocator();
                var bridges = await locator.LocateBridgesAsync(TimeSpan.FromSeconds(5));
                bridges = await HueBridgeDiscovery.CompleteDiscoveryAsync(TimeSpan.FromSeconds(5), TimeSpan.FromSeconds(30));
                ILocalHueClient client = new LocalHueClient(IP);
        
                if (FormFirstTime)
                {
                    GeneratedHueCode = await client.RegisterAsync("ViErRødeViErHvide", "MinComputer");
                    NewGeneratedCode.Text = GeneratedHueCode;
                    UpdateConfig("HueKey", GeneratedHueCode);

            }
                if (!FormFirstTime)
                {
                    client.Initialize(HueCode);
                }
                var lysrød = new LightCommand();
                var lyshvid = new LightCommand();
          
            while (STOPKNAP)
            {
                bool goalchecker = false;
                goalchecker = await service.GetTheData();
                APIStatus = "" + !goalchecker;
                if (goalchecker)
                {
                    int count = 0;
                    while (true)
                    {
                        await client.SendCommandAsync(lysrød.TurnOn().SetColor(new RGBColor("FF0000")));
                        Thread.Sleep(600);
                        await client.SendCommandAsync(lyshvid.TurnOn().SetColor(new RGBColor("FFFFFF")));
                        Thread.Sleep(600);
                        count++;
                        if (count == 20)
                        {
                            break;
                        }
                    }
                }
                Thread.Sleep(2000);
            
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            Task.Run(() => MainFunc());
            Timer();
            STOPKNAPPEN.Enabled = true;
            UpdateConfig("lastipused", IP);
            if (!FormFirstTime)
            {
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
            CurrentStatus.Text = "Applikationen kører: " + APIStatus +". Opdateret (" + UpdateCounter +") gange.";
            UpdateCounter++;
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
                        break;
                    }
                case CheckState.Unchecked:
                    {
                        HueKodeInput.Enabled = true;
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


        public async Task<bool> GetTheData()
        {

            HttpClient cli = new HttpClient();
            const string url = "https://api.sofascore.com/api/v1/sport/football/events/live";
            var response = await cli.GetAsync(url);
            Console.WriteLine(response.StatusCode);
            var jsonString = await response.Content.ReadAsStringAsync();
            dynamic dyn = JsonConvert.DeserializeObject(jsonString);
            foreach (var obj in dyn.events)
            {
                if (obj.homeTeam.name == "Denmark")
                {
                    Console.WriteLine("hold fundet");
                    
                    if (obj.homeScore.current > Goals)
                    {
                        Console.WriteLine("Tidligere mål: " + Goals);
                        Console.WriteLine("Mål fra API: " + obj.homeScore.current);
                        Goals = obj.homeScore.current;
                        if (firsttime)
                        {
                            firsttime = false;
                            return false;
                        }
                        Console.WriteLine("Danmark har scoret!!!");
                        return true;
                    }
                }
                if (obj.awayTeam.name == "Denmark")
                {
                    Console.WriteLine("hold fundet");
                    if (obj.awayScore.current > Goals)
                    {
                        Console.WriteLine("Tidligere mål: " + Goals);
                        Console.WriteLine("Mål fra API: " + obj.awayScore.current);
                        Goals = obj.awayScore.current;
                        if (firsttime)
                        {
                            firsttime = false;
                            return false;
                        }
                        Console.WriteLine("Danmark har scoret!!!");
                        return true;
                    }
                }
            }

            return false;

        }
    }
}
