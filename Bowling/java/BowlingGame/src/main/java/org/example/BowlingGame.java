package org.example;

import java.util.ArrayList;
import java.util.List;

public class BowlingGame {
    private List<Integer> rolls;

    public BowlingGame(){
        rolls = new ArrayList<Integer>();
    }

    public void roll(int pin) {
        this.rolls.add(pin);
    }

    public int score() {
        int score = 0;
        int position = 0;
        for (int frame=0; frame<10; frame++){
            if(getRoll(position) == 10)
            {
                score = score + strikeBonus(position);
                position = position + 1;
            }
            if(isSpare(position)){
                score = score + spareBonus(position);
                position = position + 2;
            }
            else{
                score = score + sumOfBallsInFrame(position);
                position = position + 2;
            }
        }
        return score;
    }

    private int sumOfBallsInFrame(int position) {
        return getRoll(position) + getRoll(position + 1);
    }

    private int spareBonus(int position) {
        return 10 + getRoll(position + 2);
    }

    private Boolean isSpare(Integer position){
        Boolean result = getRoll(position) + getRoll(position+1) == 10;
        return result;
    }

    private Integer getRoll(Integer position){
        if(rolls.size() <= position){
            return 0;
        }
        return rolls.get(position);
    }

    private Integer strikeBonus(Integer position){
        return 10 + getRoll(position+1) + getRoll(position+2);
    }
}
