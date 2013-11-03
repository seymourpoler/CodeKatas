function TransformacionLetra(mayus, minus){
	this.mayuscula = mayus;
	this.minucula = minus;
}

function Texto(texto){
	var transformacionDeletras = [];
	transformacionDeletras.push(new TransformacionLetra('A','a'));
	transformacionDeletras.push(new TransformacionLetra('Á','a'));
	transformacionDeletras.push(new TransformacionLetra('Ä','a'));
	transformacionDeletras.push(new TransformacionLetra('À','a'));
	transformacionDeletras.push(new TransformacionLetra('Â','a'));
	transformacionDeletras.push(new TransformacionLetra('B','b'));
	transformacionDeletras.push(new TransformacionLetra('C','c'));
	transformacionDeletras.push(new TransformacionLetra('D','d'));
	transformacionDeletras.push(new TransformacionLetra('E','e'));
	transformacionDeletras.push(new TransformacionLetra('É','e'));
	transformacionDeletras.push(new TransformacionLetra('Ë','e'));
	transformacionDeletras.push(new TransformacionLetra('È','e'));
	transformacionDeletras.push(new TransformacionLetra('Ê','e'));
	transformacionDeletras.push(new TransformacionLetra('F','f'));
	transformacionDeletras.push(new TransformacionLetra('G','g'));
	transformacionDeletras.push(new TransformacionLetra('h','h'));
	transformacionDeletras.push(new TransformacionLetra('I','i'));
	transformacionDeletras.push(new TransformacionLetra('Í','i'));
	transformacionDeletras.push(new TransformacionLetra('Ï','i'));
	transformacionDeletras.push(new TransformacionLetra('Ì','i'));
	transformacionDeletras.push(new TransformacionLetra('Î','i'));
	transformacionDeletras.push(new TransformacionLetra('J','j'));
	transformacionDeletras.push(new TransformacionLetra('L','l'));
	transformacionDeletras.push(new TransformacionLetra('M','m'));
	transformacionDeletras.push(new TransformacionLetra('N','n'));
	transformacionDeletras.push(new TransformacionLetra('Ñ','n'));
	transformacionDeletras.push(new TransformacionLetra('O','o'));
	transformacionDeletras.push(new TransformacionLetra('Ó','o'));
	transformacionDeletras.push(new TransformacionLetra('Ö','o'));
	transformacionDeletras.push(new TransformacionLetra('Ò','o'));
	transformacionDeletras.push(new TransformacionLetra('Ô','o'));
	transformacionDeletras.push(new TransformacionLetra('P','p'));
	transformacionDeletras.push(new TransformacionLetra('Q','q'));
	transformacionDeletras.push(new TransformacionLetra('R','r'));
	transformacionDeletras.push(new TransformacionLetra('S','s'));
	transformacionDeletras.push(new TransformacionLetra('T','t'));
	transformacionDeletras.push(new TransformacionLetra('U','u'));
	transformacionDeletras.push(new TransformacionLetra('Ú','u'));
	transformacionDeletras.push(new TransformacionLetra('Ü','u'));
	transformacionDeletras.push(new TransformacionLetra('Ù','u'));
	transformacionDeletras.push(new TransformacionLetra('Û','u'));
	transformacionDeletras.push(new TransformacionLetra('V','v'));
	transformacionDeletras.push(new TransformacionLetra('W','w'));
	transformacionDeletras.push(new TransformacionLetra('X','x'));
	transformacionDeletras.push(new TransformacionLetra('Y','y'));
	transformacionDeletras.push(new TransformacionLetra('Z','z'));

	var letras = texto;

	function simplificar(){
		if(letras.length == 0){
			return '';
		}
		return procesarTexto(letras);
	}

	function procesarTexto(texto){
		var resultado = '';
		for(var contador = 0; contador < texto.length; contador++){
			resultado += transformarLetra(decodeURIComponent(texto.charAt(contador)));
		}
		return resultado;
	}

	function transformarLetra(letra){
		var encontrado = false;
		var resultado = letra;
		var contador  = 0;
		console.log('TransformacionLetra: ' + letra);
		while((contador < transformacionDeletras.length) && (!encontrado)){
			if(letra == transformacionDeletras[contador].minucula)
			{
				resultado = transformacionDeletras[contador].mayuscula;
				encontrado = true;	
			}
			contador ++;
		}
		console.log('resultado transformarLetra : ' + resultado);
		return resultado;
	}

	return {
		simplificar: simplificar
	}
}
