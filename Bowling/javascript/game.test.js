let Game = require('./game');

describe('Game', function(){
    describe('when score is requested', function(){
        it('returns score if is just created', function(){
            let game = new Game();

            let score = game.getScore();

            expect(score).toBe(0);
        });
    });
});