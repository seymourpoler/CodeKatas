function CashRegister()
{
	var fruits = [];
	var self = this;

	self.with = function(fruit){
		fruits.push(fruit);
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
		if('apple' == fruit){
			return 75;
		}
		if('cherry' == fruit){
			return 90;
		}
		throw 'kind of fruit not implemented for getPriceFor'
	}
}