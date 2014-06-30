
describe("the cards game", function() {
  var cardsPlayer;
  var whoWins;

  beforeEach(function() {
    cardsPlayer = new CardsPlayer();
    whoWins = '';
  });

  it("should be able to play a Song", function() {
    whoWins = cardsPlayer.play(['1'],['2']]);
    whoWins.toEqual('Player2 wins 1 to 0');

  });
});

