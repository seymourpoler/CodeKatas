function List(arrayData){
	var data = [];
	if(arrayData != undefined && arrayData != null){
		data = arrayData;
	}
	var self = this;

	this.getItem = function(position){
		return data[position];
	};
	this.count = function(){
		return data.length;
	};
	this.sum = function(filter){
		var result = 0;
		var number;
		for (var position = 0; position < self.count(); position ++) {
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
		for (var position = 0; position < self.count() && position < numberOfElements; position ++) {
			result.add(data[position])
		};
		return result;
	};
	this.add = function(element){
		data.push(element);
		return new List(data);
	};
	this.isEqual = function(list){
		if(self.count() != list.count()){
			return false;
		}
		for (var position = 0; position < self.count() ; position ++) {
			if(data[position] != list.getItem(position)){
				return false;
			}
		}
		return true;
	};
	this.where = function(condition){
		var result = new List();
		var item;
		for (var position = 0; position < self.count(); position ++) {
			item = self.getItem(position);
			if(condition(item)){
				result.add(item);
			}
		}
		return result;
	};
	this.union = function(list){
		for (var position = 0; position < list.count(); position ++) {
			self.add(list.getItem(position));
		};
		return self;
	}
	this.reverse = function(){
		var result = new List();
		var item;
		for (var position = self.count() - 1; position >= 0; position --) {
			item = self.getItem(position);
			result.add(item)
		};
		return result;
	}
	this.select = function(func){
		var result = new List();
		var item;
		for (var position = 0; position < self.count(); position++) {
			item = func(data[position]);
			result.add(item);
		};
		return result;
	};
	this.remove = function (condition) {
		var result = new List();
		for(var position = 0; position < self.count(); position ++){
			if(condition(data[position])){
				result.add(data[position]);
			}
		}
		return result;
	}
	this.clear = function(){
		data = [];
	};

	this.elementAt = function(position){
		return self.getItem(position);
	};
	this.isEmpty = function(){
		return self.count() == 0;
	};
	this.first = function(condition){
		if(typeof(condition) == 'undefined'){
			return data[0];
		}
		var item;
		for(var position = 0; position < self.count(); position ++){
			item = data[position];
			if(condition(item)){
				return item;
			}
		}
		return undefined;
	};
	this.last = function(condition){
		if(typeof(condition) == 'undefined'){
			var lasPosition = self.count() - 1;
			return data[lasPosition];
		}
		var item;
		for(var position = self.count()-1; position >= 0; position --){
			item = data[position];
			if(condition(item)){
				return item;
			}
		}
		return undefined;
	};
	this.orderAscending = function(){
		return self.orderBy(function(x, y){
			return (x - y);
		});
	};
	this.orderDescending = function() {
		return self.orderBy(function(x, y){
			return (y - x);
		});
	};
	this.orderBy = function(orderingFunction){
		return new List(data.sort(orderingFunction));
	};
	this.skip = function(number){
		var result = new List();
		var position = 0;
		for(var position = 0; position < self.count(); position++){
				if(position >= number){
				result.add(data[position]);
			}
		}
		return result;
	};
	this.getRange = function(position, length){
		return self.skip(position)
				.take(length);
	}
}