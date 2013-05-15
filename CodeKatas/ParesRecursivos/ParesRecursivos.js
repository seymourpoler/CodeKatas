
function mayoresParesRecursivos(repeticiones, numero){
	
	if(sinRepeticiones(repeticiones)){
		return [];
	}

	var resultado = [];
	
	if(esPar(numero)){
		resultado.push(numero);
		repeticiones = repeticiones - 1;
	}
	numero = numero - 1;
	var valores = mayoresParesRecursivos(repeticiones, numero);
	return resultado.concat(valores);
}

function esPar(numero){
	return (numero % 2 == 0);
}

function sinRepeticiones(repeticiones){
	return (repeticiones == 0);
}