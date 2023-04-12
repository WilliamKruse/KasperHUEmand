using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KasperHUEmand.Services
{
    public class LiveScoreService
    {
        public int Goals { get; set; } = 0;
        public bool FirstTime { get; set; } = true;
        public string Status { get; set; } = "";
        public LiveScoreService()
        {
            this.Goals = 0;
            this.FirstTime = true;
        }

        public async Task<dynamic> GetLiveScores()
        {
            Status = "Kampen er ikke igang endnu";
            HttpClient cli = new HttpClient();
            const string url = "https://api.sofascore.com/api/v1/sport/football/events/live";
            var response = await cli.GetAsync(url);
            Console.WriteLine(response.StatusCode);
            var jsonString = await response.Content.ReadAsStringAsync();
            dynamic liveMatches = JsonConvert.DeserializeObject(jsonString);
            return liveMatches;
        }

        public async Task<string> CheckIfGoalWasScored(string teamName)
        {
            dynamic liveMatches = await GetLiveScores();

            foreach (var Match in liveMatches.events)
            {
                if (Match.homeTeam.name == teamName)
                {
                    Status = "hold fundet, kamp igang";

                    if (Match.homeScore.current > Goals)
                    {
                        Console.WriteLine("Tidligere mål: " + Goals);
                        Console.WriteLine("Mål fra API: " + Match.homeScore.current);
                        Goals = Match.homeScore.current;
                        if (FirstTime)
                        {
                            FirstTime = false;
                            return "false";
                        }
                        Console.WriteLine("Danmark har scoret!!!");
                        return "true";
                    }
                }
                if (Match.awayTeam.name == teamName)
                {
                    Status = "hold fundet, kamp igang";
                    if (Match.awayScore.current > Goals)
                    {
                        Console.WriteLine("Tidligere mål: " + Goals);
                        Console.WriteLine("Mål fra API: " + Match.awayScore.current);
                        Goals = Match.awayScore.current;
                        if (FirstTime)
                        {
                            FirstTime = false;
                            return "false";
                        }
                        Console.WriteLine("Danmark har scoret!!!");
                        return "true";
                    }
                }
            }

            return Status;

        }
    }

        
        
    
}
