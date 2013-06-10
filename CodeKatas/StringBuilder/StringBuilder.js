
function StringBuilder(value){
	var buffer = new Array(value);
	this.toString = function(){
		return buffer.join('');
	}
	this.append = function(value){
		buffer.push(value);
	}
	this.clear = function(){
		buffer.length = 1;
	}
}

