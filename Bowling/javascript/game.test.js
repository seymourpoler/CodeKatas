let Game = require('./game');

describe('Game', function(){
    describe('when score is requested', function(){
        it('returns score if is just created', function(){
            let game = new Game();

            const score = game.getScore();

            expect(score).toBe(0);
        });

        it('returns zero score with zero pins', function(){
            let game = new Game();
            game.roll(0);

            const score = game.getScore();

            expect(score).toBe(0);
        });

        it('returns score with pins', function(){
            let game = new Game();
            for(let i=0; i < 20; i++){
                game.roll(1);
            }

            const score = game.getScore();

            expect(score).toBe(20);
        });

        it('returns score with one spare pin', function(){
            let game = new Game();
            game.roll(5);
            game.roll(5);
            game.roll(3);

            const score = game.getScore();

            expect(score).toBe(16);
        });

        it('returns score with one strike', function(){
            let game = new Game();
            game.roll(10);
            game.roll(3);
            game.roll(4);

            const score = game.getScore();

            expect(score).toBe(24);
        });
    });
});