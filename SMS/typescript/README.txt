SMS
Supondremos un teclado de teléfono móvil con 10 teclas: del 0 al 9. Cada tecla tendrá asociada una secuencia de caracteres como se especifica en la siguiente tabla.

Tecla	Secuencia de caracteres
0	-_:0
1	.; 1
2	abc2
3	def3
4	ghi4
5	jkl5
6	mno6
7	pqrs7
8	tuv8
9	wxyz9

(nótese el caracter de espacio en blanco antes del 1)


Funcionamiento
Por ejemplo, cuando se pulsa la tecla 4 una sola vez, se escribe el caracter 'g', si se pulsa dos veces seguidas dicha tecla, el caracter que se escribe es 'h'. 
O dicho de otra manera, siendo N el número de pulsaciones consecutivas de un misma tecla, el caracter asociado es el que se encuentra en la posición N de la secuencia. Hay que tener en cuenta que la secuencia es cíclica y por tanto 5 pulsaciones seguidas de la tecla 5 dará como resultado el caracter 'j'.
Para distinguir dos secuencias de pulsaciones consecutivas de la misma tecla insertaremos un espacio como mínimo (se pueden insertar más de uno sin que afecte al funcionamiento descrito) entre ambas con el fin de determinar dónde acaba una y dónde empieza la otra. Es decir, si tenemos la secuencia de pulsaciones "6 666" (nótese el espacio en blanco), el resultado será "mo". No es necesario dicho espacio para secuencias de teclas distintas aunque podría haber uno o más sin afectar al funcionamiento. "22444" y "22 444" representarían "bi".

Teniendo en cuenta lo anterior, se pide desarrollar un programa que sea capaz de traducir una secuencia de pulsaciones de tecla al mensaje que representan.
Ejemplos

Entrada	Salida
""	""
"0"	"-"
"6 666 66 666"	"mono"
"222 277772"	"casa"
"222 2 7777 2"	"casa"
"4444446665552"	"hola"
