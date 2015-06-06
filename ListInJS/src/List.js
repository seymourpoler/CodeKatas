function List(arrayData){
	var data = [];
	if(arrayData != undefined && arrayData != null){
		data = arrayData;
	}
	this.count = function(){
		return data.length;
	};
	this.sum = function(filter){
		var result = 0;
		var number;
		for (var position = 0; position < this.count(); position ++) {
			if(filter != 'undefined' && typeof(filter) === 'function'){
				result = result + filter(data[position]);
			}
			else if(typeof(data[position]) === 'number'){
				result = result + data[position];
			}
		};
		return result;
	};
	this.take = function(numberOfElements){
		var result = new List([]);
		for (var position = 0; position < this.count() && position < numberOfElements; position ++) {
			result.add(data[position])
		};
		return result;
	};
	this.add = function(element){
		data.push(element);
		return new List(data);
	}
	this.getItem = function(position){
		return data[position];
	}
	this.isEqual = function(list){
		if(this.count() != list.count()){
			return false;
		}
		for (var position = 0; position < this.count() ; position ++) {
			if(data[position] != list.getItem(position)){
				return false;
			}
		}
		return true;
	};
}