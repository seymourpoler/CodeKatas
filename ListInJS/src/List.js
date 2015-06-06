function List(arrayData){
	var data = [];
	if(arrayData != undefined && arrayData != null){
		data = arrayData;
	}
	this.count = function(){
		return data.length;
	};
	this.sum = function(){
		var result = 0;
		for (var position = 0; position < this.count(); position ++) {
			if(typeof(data[position]) === 'number'){
				result = result + data[position];
			}
		};
		return result;
	};
}