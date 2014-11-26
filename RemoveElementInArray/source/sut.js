function removeElementInArray(number, vector){
	if(vector == []){
		return vector;
	}

	var result = [];
	var head;

	for(var position = 0; position < vector.length; position++){
		head = vector[position];
		if(head != number){
			result.push(head);
		}
	}
	return result;
}

exports.remove = removeElementInArray;