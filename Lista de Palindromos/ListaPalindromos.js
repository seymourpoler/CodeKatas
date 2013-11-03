function sonPalindromos(lista)
{
	if(lista.length<2){
		return false;
	}
	
	var posicionInicial = 0;
	var posicionFinal = lista.length-1;
	var resultado  = true;

	while((posicionInicial < posicionFinal) && (resultado)){
		resultado = (lista[posicionInicial] == lista[posicionFinal]);
		posicionFinal = posicionFinal -1;
		posicionInicial = posicionInicial + 1;
	}

	return resultado;
}
