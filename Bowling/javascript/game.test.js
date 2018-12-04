let Game = require('./game');

describe('Game', function(){
    describe('when score is requested', function(){
        it('returns score if is just created', function(){
            let game = new Game();

            let score = game.getScore();

            expect(score).toBe(0);
        });

        it('returns zero score with zero pins', function(){
            let game = new Game();

            game.roll(0);
            let score = game.getScore();

            expect(score).toBe(0);
        });

        it('returns score with pins', function(){
            let game = new Game();
            for(let i=0; i < 20; i++){
                game.roll(1);
            }

            let score = game.getScore();

            expect(score).toBe(20);
        });
    });
});