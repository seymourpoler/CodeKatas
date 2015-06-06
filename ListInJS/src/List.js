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
	this.take = function(position){
		return new List();
	}
}