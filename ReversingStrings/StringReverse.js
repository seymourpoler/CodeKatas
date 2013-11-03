

String.prototype.reverse = function(){
	var result = [];
	var values =  this.split('');
	for(var cont = 0; cont < values.length; cont++){
		result.unshift(values[cont]);
	}
	return result.join('');
}

