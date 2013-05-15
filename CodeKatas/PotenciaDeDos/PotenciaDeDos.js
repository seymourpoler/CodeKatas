function PotenciaDeDos(numero){
	if(numero > 255){
		return 0;
	}
	var resultado  = 2;
	for(int contador = 0; contador< numero; contador++){
		resultado = resultado * 2;
	}
	return resultado;
}
