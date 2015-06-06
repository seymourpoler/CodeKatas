function List(arrayData){
	var data = [];
	if(arrayData != undefined && arrayData != null){
		data = arrayData;
	}
	var self = this;
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
	}
	this.getItem = function(position){
		return data[position];
	}
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
}