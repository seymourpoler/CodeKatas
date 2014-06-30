function CardsPlayer(){
	this.carRank = '123456789TJQK';
}

CardsPlayer.prototype.play = function(playerOne, playerTwo){
	var scorePlayer1 = 0;
	var scorePlayer2 = 0;
	for (var i = 0; i < playerOne.length; i++) {
		if(this.carRank.indexOf(playerOne[i]) > this.carRank.indexOf(playerTwo[i])){
			scorePlayer1 ++;
		}
		else if(this.carRank.indexOf(playerOne[i]) < this.carRank.indexOf(playerTwo[i])){
			scorePlayer2 ++;
		}	
	}

	if(scorePlayer1 > scorePlayer2){
		return 'Player1 wins 1 to 0';
	}
	else if(scorePlayer1 < scorePlayer2){
		return 'Player2 wins 1 to 0';
	}
	return 'Tie';
}