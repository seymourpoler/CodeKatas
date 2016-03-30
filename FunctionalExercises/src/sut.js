exports.adder = function(x){
  return function(y){
	return x + y;  	
  };
};

exports.multiplier = function(x){
	return function (y){
		return x * y;
	};
};

