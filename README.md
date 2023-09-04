##Simulador de dos dados, obtener suma y repetir juego.##



## Tabla de Contenidos
- [Introducción](#introducción)
- [Características](#características)
- [Instalación](#instalación)
- [Uso](#uso)
- [Contribuciones](#contribuciones)
- [Licencia](#licencia)


##Introduccion##
Se obtendran datos de manera aleatroria, un dado tiene 6 caras y se sumaran los resultadados de lso dados
y se le preguntara al usuario si desea volver a repetir el programa para obtener 
nuevos resultados.



##Caracteristicas.
Este codigo se creo con Visual Studio 2022, se crearon varias entre ellas una variabe global para la suma de los dados en este caso se llamara res de respuesta.
-La variabel s definiera si la respuesta es un si en caso de que se desee repetir el juego.
-Se utilizara un DO, dentro del DO se haremos todo el juego de los dados, se agrega una clase RAMDOM que nos permite manipular numeros aleatorios
con un inicio y un limite.
- Se declaran avariables para ambos dados y se trae en metodo next y se le pone de 1 al 6 que son las 6v partes de un dado.
-Tambien se agrega un console.writelien para dejar un espacio para que no se vea muy pegado las lineas d texto.
-Con un console.writeline contatenamos dado1 mas dado2 en esta instruccion nos da un numero de manera aleatorea un numero del 1 al 6.
-Posteriormente se utiliza la variable res para hacer la suma de dado1 y dado2.
- Luego se indica el resultado con un console Writeline (El sesultado es: y se contatena con la variabe +res)
-Posteriormente se con un console Writeline hacemos la pregunta si desea volver tirar los dados y se contatena con la 
variable s con un convert.toint32 para repetir la funcion.
- cerramos el DO con While si la respuest es un si se pone un 1.

##instalación
Es neceario descargar la aplicacion de windows studio, puedes descargarlo desde el sig link https://learn.microsoft.com/es-es/visualstudio/install/install-visual-studio?view=vs-2022


##Uso.
-Para el uso es necesario tener conocimientos basico de Visual Studio.









