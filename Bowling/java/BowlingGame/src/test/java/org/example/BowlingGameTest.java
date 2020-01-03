package org.example;

import org.junit.Assert;
import org.junit.Before;
import org.junit.Test;

public class BowlingGameTest {
    private BowlingGame bowlingGame;

    @Before
    public void setUp() throws Exception {
        bowlingGame = new BowlingGame();
    }

    @Test
    public void testGutterGame() {
        rollMany(20, 0);

        Assert.assertEquals(0, bowlingGame.score());
    }

    @Test
    public void testAllOnes() {
        rollMany(20, 1);

        Assert.assertEquals(20, bowlingGame.score());
    }

    @Test
    public void testOneSpare() {
        bowlingGame.roll(5);
        bowlingGame.roll(5);
        bowlingGame.roll(3);
        rollMany(17, 0);

        Assert.assertEquals(16, bowlingGame.score());
    }

    @Test
    public void testOneStrike() {
        bowlingGame.roll(10);
        bowlingGame.roll(3);
        bowlingGame.roll(4);
        rollMany(16, 0);

        Assert.assertEquals(24, bowlingGame.score());
    }
    @Test
    public void testPerfectGame(){
        rollMany(12, 10);

        Assert.assertEquals(200, bowlingGame.score());
    }




    private void rollMany(int times, int pins){
        for (int i=0; i<times; i++){
            bowlingGame.roll(pins);
        }
    }
}
