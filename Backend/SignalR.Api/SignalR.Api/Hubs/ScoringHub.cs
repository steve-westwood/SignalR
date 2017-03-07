using System.Threading;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using SignalR.Api.Models;

namespace SignalR.Api.Hubs
{
    [HubName("Scoring")]
    public class ScoringHub : Hub
    {
        public void GetScores(int numberOfScores)
        {
            var scores = Score.GetScoreData(numberOfScores);
            for (var s = 0; s < numberOfScores; s++)
            {
                Thread.Sleep(2000);
                Clients.All.onGetScores(scores[s]);
            }
        }
    }
}