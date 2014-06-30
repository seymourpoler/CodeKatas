describe("The cards game", function() {
	var player;
	beforeEach(function() {
    	player = new CardsPlayer();
  	});

	it("win with the highest card in a single card game ", function(){
		
		expect(player.play(['1'], ['0'])).toEqual('Player1 wins 1 to 0');
	});

	it("win with the highest card in the other player with a single card game ", function(){
		expect(player.play(['0'], ['1'])).toEqual('Player2 wins 1 to 0');
	});

	it("Tie", function(){
		expect(player.play(['1'], ['1'])).toEqual('Tie');
	});

	it("knows the card ranking wich not always matches the ascii order", function(){
		expect(player.play(['K'], ['Q'])).toEqual('Player1 wins 1 to 0');
	});
	it("wins with several cards", function(){
		expect(player.play(['1', '2'], ['1', '1'])).toEqual('Player1 wins 1 to 0');
	});
});