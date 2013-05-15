function cifrar(texto, desplazamiento){
	var resultado = '';
	var letra = '';

	for(var posicion = 0; posicion<texto.length; posicion++){
		letra = cifrarLetra(texto[posicion], desplazamiento);
		resultado = resultado.concat(letra);
	}
	return resultado;;
}

function cifrarLetra(letra, desplazamiento){
	if(!esLetraNormal(letra)){
		return letra;
	}

	var numero = letra.charCodeAt(0);
	numero += desplazamiento;
	return String.fromCharCode(numero);
}

function esLetraNormal(letra){
	var expresionRegular = new RegExp("[a-zA-Z]");
	var coincidencias = letra.search(expresionRegular);
	return !coincidencias > 0;
}