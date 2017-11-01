using System.Linq;
using System.Collections.Generic;

namespace Bowling
{
    public class ScoreBoard
    {
        private IList<SessionOfThrows> sessionOfThrowses;
        
        public int TotalScore
        {
            get
            {
                return sessionOfThrowses
                    .Aggregate(0, (result, sessionOfThrows) => 
                        result + sessionOfThrows.Score);
            }
        }

        public int ScoreOfCurrentThrow => 
            sessionOfThrowses.Last().Score;

        public int CurrentFrame =>
            sessionOfThrowses.Count;

        public ScoreBoard()
        {
            sessionOfThrowses = new List<SessionOfThrows>();
        }

        public void AddSessionOfThrows(SessionOfThrows aSessionOfThrows)
        {
            const int maximumNumnerOfThrows = 10;
            if (sessionOfThrowses.Count >= maximumNumnerOfThrows)
            {
                return;
            }
            sessionOfThrowses.Add(aSessionOfThrows);
        }

        public int ScoreOfThrow(int aThrow)
        {
            if (sessionOfThrowses.IsEmpty())
            {
                return 0;
            }
            if (sessionOfThrowses.Count <= aThrow)
            {
                return 0;
            }
            return sessionOfThrowses[aThrow].Score;
        }
    }

    public class SessionOfThrows
    {
        private int pointsOfFirstThrow;
        private int pointsOfSecondThrow;
        private int pointsOfThirdThrow;
        
        public SessionOfThrows(
            int pointsOfFirstThrow, 
            int pointsOfSecondThrow,
            int pointsOfThirdThrow=0)
        {
            this.pointsOfFirstThrow = pointsOfFirstThrow;
            this.pointsOfSecondThrow = pointsOfSecondThrow;
            this.pointsOfThirdThrow = pointsOfThirdThrow;
        }

        public int Score => 
            pointsOfFirstThrow +
            pointsOfSecondThrow +
            pointsOfThirdThrow;
    }
}