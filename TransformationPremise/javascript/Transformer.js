function findPositionsOfUpperCaseCharactersIn(text){
	return findPositionsOfUpperCaseCharactersRecursiveIn(text, 0);
}

function findPositionsOfUpperCaseCharactersRecursiveIn(text, position){
	if(text.length == position){
		return [];
	}
	if(isUpperCase(text[position])){
		return [position].concat(findPositionsOfUpperCaseCharactersRecursiveIn(text, position+1));
	}
	return findPositionsOfUpperCaseCharactersRecursiveIn(text, position+1);
}

function isUpperCase(character){
	return (character == character.toUpperCase());
}