function CashRegister()
{
	var fruits = [];
	var self = this;
	var numberOfCherrys = 0;

	self.with = function(fruit){
		fruits.push(fruit);
		return self;
	};

	self.withCSV = function(fruitsInCSVFormat){
		var fruitsFromCSV = fruitsInCSVFormat.split(';');
		var fruit;
		for(var position = 0; position < fruitsFromCSV.length; position++){
			fruit = fruitsFromCSV[position];
			fruits.push(fruit);
		}
		return self;
	};

	self.getTheBill = function(){
		var totalPriceToPay = 0;
		var fruit;
		for(var position = 0; position < fruits.length; position++){
			fruit = fruits[position];
			totalPriceToPay = totalPriceToPay + getPriceFor(fruit);
		}
		return {totalPrice: totalPriceToPay};
	};

	function getPriceFor(fruit){
		if('bannana' == fruit){
			return 100;
		}
		if('platano' == fruit){
			return 105;
		}
		if('apple' == fruit){
			return 75;
		}
		if('cherry' == fruit){
			numberOfCherrys ++;
			return calculatePriceForCherry(numberOfCherrys);
		}
		return 0;

		function calculatePriceForCherry(numberOfCherrys){
			if(numberOfCherrys % 2 == 0)
			{
				return 45;
			}
			return 90;
		}
	}
}