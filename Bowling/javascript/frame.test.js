let Frame = require('./frame');

describe ('Frame', function(){
    describe('when score is requested', function(){
        it('returns zero if is just created', function(){
            var frame = new Frame();
            
            var score = frame.getScore();

            expect(score).toBe(0);
        });
    });
});