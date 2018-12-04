function Game(){
    var self = this;
    var frames = [];
    var score = 0;

    self.roll = function(pins){
       score = score + pins;
    };

    self.getScore = function(){
       return score;
    };
}

module.exports = Game;