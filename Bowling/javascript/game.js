function Game(){
    var self = this;
    var frames = [];

    self.roll = function(pins){
       frames.push(pins);
    };
 
    self.getScore = function(){
        const numberOfPinsPerSpare = 10;
        const numberOfPinsPerStrike = 10;
        let framePosition = 0;
        let score = 0;
        while(framePosition < frames.length){
            if(isStrike(framePosition)){
                score = score + numberOfPinsPerStrike + frames[framePosition+1] + frames[framePosition+2];
                framePosition = framePosition + 1;
            }
            else if(isSpare(framePosition)){
                score = score + numberOfPinsPerSpare + frames[framePosition + 2];
                framePosition = framePosition + 2;
            }else{
              score = score + frames[framePosition];
              framePosition = framePosition + 1;
            }
        }
        
       return score;

       function isSpare(position){
           if(position == frames.length){
               return false;
           }
            return frames[position] + frames[position+1] == numberOfPinsPerSpare;
       }

       function isStrike(position){
           const numberOfPinsPerStrike = 10;
           return frames[position] === numberOfPinsPerStrike;
       }
        
    };
}

module.exports = Game;