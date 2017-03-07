using System.Collections.Generic;

namespace SignalR.Api.Models
{
    public class Score
    {
        public int Id { get; set; }
        public string ScoreText { get; set; }

        public Score(int id, string scoreText)
        {
            Id = id;
            ScoreText = scoreText;
        }

        public static Score[] GetScoreData(int numberOfScores)
        {
            var scores = new List<Score>();
            for (var i = 1; i <= numberOfScores; i++)
            {
                scores.Add(new Score(i, $"Score for loan {i}"));
            }
            return scores.ToArray();
        }
    }
}