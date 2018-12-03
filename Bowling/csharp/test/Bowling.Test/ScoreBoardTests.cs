using System;
using Xunit;

namespace Bowling.Test
{
    public class ScoreBoardTests
    {
        private ScoreBoard scoreBoard;
        
        public ScoreBoardTests()
        {
            scoreBoard = new ScoreBoard();
        }
        
        [Fact]
        public void ReturnsZeroForTotalScoreWhenThereIsNoThrows()
        {
            Assert.Equal(0, scoreBoard.TotalScore);
        }

        [Fact]
        public void ReturnsTotalScoreWithOnSessionOfThrows()
        {
            var aSessionOfThrows = new SessionOfThrows(
                pointsOfFirstThrow: 2, 
                pointsOfSecondThrow: 5);
            scoreBoard.AddSessionOfThrows(aSessionOfThrows);

            var totalScore = scoreBoard.TotalScore;

            Assert.Equal(7, totalScore);
        }

        [Fact]
        public void ReturnsTotalScoreWithMoreThanOneSessionOfThrows()
        {
            var firstSessionOfThrows = new SessionOfThrows(
                pointsOfFirstThrow: 1, 
                pointsOfSecondThrow: 2);
            var secondSessionOfThrows = new SessionOfThrows(
                pointsOfFirstThrow: 3, 
                pointsOfSecondThrow: 4);
            scoreBoard.AddSessionOfThrows(firstSessionOfThrows);
            scoreBoard.AddSessionOfThrows(secondSessionOfThrows);

            var totalScore = scoreBoard.TotalScore;
            
            Assert.Equal(10, totalScore);
        }

        [Fact]
        public void ReturnsZeroForScoreOfOneThrowWhenThereNoThrows()
        {
            const int secondThrow = 1;
            
            var scoreOfOneThrow = scoreBoard.ScoreOfThrow(secondThrow);
            
            Assert.Equal(0, scoreOfOneThrow);
        }

        [Fact]
        public void ReturnsZeroForScoreOfOneThrowWhenThereIsNotEnoughThrows()
        {
            const int secondThrow = 1;
            var aSessionOfThrows = new SessionOfThrows(
                pointsOfFirstThrow: 1, 
                pointsOfSecondThrow: 2);
            scoreBoard.AddSessionOfThrows(aSessionOfThrows);
            
            var scoreOfOneThrow = scoreBoard.ScoreOfThrow(secondThrow);
            
            Assert.Equal(0, scoreOfOneThrow);
        }
        
        [Fact]
        public void ReturnsScoreOfOneThrow()
        {
            const int firstThrow = 0;
            var firstSessionOfThrows = new SessionOfThrows(
                pointsOfFirstThrow: 1, 
                pointsOfSecondThrow: 2);
            var secondSessionOfThrows = new SessionOfThrows(
                pointsOfFirstThrow: 3, 
                pointsOfSecondThrow: 4);
            scoreBoard.AddSessionOfThrows(firstSessionOfThrows);
            scoreBoard.AddSessionOfThrows(secondSessionOfThrows);

            var scoreOfOneThrow = scoreBoard.ScoreOfThrow(firstThrow);
            
            Assert.Equal(3, scoreOfOneThrow);
        }
        
        [Fact]
        public void ReturnsScoreOfCurrentThrow()
        {
            var firstSessionOfThrows = new SessionOfThrows(
                pointsOfFirstThrow: 1, 
                pointsOfSecondThrow: 2);
            var secondSessionOfThrows = new SessionOfThrows(
                pointsOfFirstThrow: 3, 
                pointsOfSecondThrow: 4);
            scoreBoard.AddSessionOfThrows(firstSessionOfThrows);
            scoreBoard.AddSessionOfThrows(secondSessionOfThrows);

            var scoreOfCurrentThrow = scoreBoard.ScoreOfCurrentThrow;
            
            Assert.Equal(7, scoreOfCurrentThrow);
        }

        [Fact]
        public void ReturnsTotalScoreOfThrowWithStrike()
        {
            var sessionOfThrows = new SessionOfThrows(
                pointsOfFirstThrow:5,
                pointsOfSecondThrow: 10,
                pointsOfThirdThrow: 3);
            scoreBoard.AddSessionOfThrows(sessionOfThrows);

            var totalScoreWithStrike = scoreBoard.TotalScore;
            
            Assert.Equal(18, totalScoreWithStrike);
        }

        [Fact]
        public void ReturnsTotalScoreForMaximumNumberOfThrows()
        {
            const int moreThanMaximumNumnerOfThrows = 11;
            for (var count = 0; count < moreThanMaximumNumnerOfThrows; count++)
            {
                var sessionOfThrows = new SessionOfThrows(
                    pointsOfFirstThrow:1,
                    pointsOfSecondThrow: 1);
                scoreBoard.AddSessionOfThrows(sessionOfThrows);
            }            
            
            var totalScore = scoreBoard.TotalScore;
                
            Assert.Equal(20, totalScore);
        }

        [Fact]
        public void ReturnsZeroForCurrentFrameWhenThereIsNoThrows()
        {
            var currentFrame = scoreBoard.CurrentFrame;

            Assert.Equal(0, currentFrame);
        }

        [Fact]
        public void ReturnsCurrentFrame()
        {
            var aSessionOfThrows = new SessionOfThrows(
                pointsOfFirstThrow: 2,
                pointsOfSecondThrow: 4);
            scoreBoard.AddSessionOfThrows(aSessionOfThrows);

            var currentFrame = scoreBoard.CurrentFrame;
            
            Assert.Equal(1, currentFrame);
        }

        [Fact]
        public void RetunrsTotalScoreWithAllStrikes()
        {
            for (var count = 0; count < 11; count++)
            {
                var aSessionOfThrows = new SessionOfThrows(
                    pointsOfFirstThrow: 10,
                    pointsOfSecondThrow: 10,
                    pointsOfThirdThrow: 10);
                scoreBoard.AddSessionOfThrows(aSessionOfThrows);
            }

            var totalScore = scoreBoard.TotalScore;
            
            Assert.Equal(300, totalScore);
        }

        [Fact]
        public void ReturnsTotalScoreWithStrikeInTheLastThrow()
        {
            SessionOfThrows aSessionOfThrows; 
            for (var count = 0; count < 9; count++)
            {
                aSessionOfThrows = new SessionOfThrows(
                    pointsOfFirstThrow: 0,
                    pointsOfSecondThrow: 0);
                scoreBoard.AddSessionOfThrows(aSessionOfThrows);
            }
            aSessionOfThrows = new SessionOfThrows(
                pointsOfFirstThrow: 2,
                pointsOfSecondThrow: 8,
                pointsOfThirdThrow: 10);
            scoreBoard.AddSessionOfThrows(aSessionOfThrows);
            
            var totalScore = scoreBoard.TotalScore;
            
            Assert.Equal(20, totalScore);
        }
    }
}