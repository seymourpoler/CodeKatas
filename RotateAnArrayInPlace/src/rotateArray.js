exports.rotate = function(positions, data){
  var number = 0;
  var result = [];
  for (var counter = 0; counter < positions; counter++) {
  	number = data.shift();
  	data[data.length] = number;
  }
  return data;
};