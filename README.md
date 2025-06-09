# Ejercicio 4
**¿String es una tipo por valor o un tipo por referencia?**

En C#, string es un tipo de referencia, aunque en algunos casos puede comportarse como un tipo de valor. Esto se debe a que los operadores == y != comparan los valores de las cadenas, no las referencias

**¿Qué secuencias de escape tiene el tipo string?**

**Secuencias de escape comunes:**
* \n: Salto de línea (nueva línea).
* \t: Tabulación horizontal.
* \r: Retorno de carro.
* \": Comillas dobles.
* \': Comilla simple.
* \\: Barra invertida.
* \0: Carácter nulo (fin de cadena en algunos lenguajes).
* \b: Retroceso.
* \Z: Sustitución (carácter de sustitución en algunas plataformas).
* \xNN: Representa un carácter Unicode con el código hexadecimal NN.
* \uNNNN: Representa un carácter Unicode con el código hexadecimal NNNN (4 dígitos). 

**¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto?**

En C#, el carácter @ antes de una cadena de texto (como en `@"Mi cadena") define una cadena literal, donde las secuencias de escape se interpretan literalmente, y el carácter $ antes de una cadena de texto (como en $"{variable}") define una cadena interpolada, donde las expresiones dentro de las llaves son evaluadas y reemplazadas en la cadena. 

Cuando se usa @ antes de una cadena de texto, las secuencias de escape (como \n para nueva línea o \t para tabulación) se interpretan como texto literal en lugar de caracteres especiales.
Esto es útil para crear cadenas que contienen muchos caracteres especiales, como líneas de texto o cadenas que deben ser interpretadas exactamente como están escritas. 

Cuando se usa $ antes de una cadena de texto, las expresiones entre llaves {} son evaluadas y sus valores son insertados en la cadena.
Esto permite la creación de cadenas dinámicas, donde partes de la cadena se pueden generar a partir de variables o expresiones.
Se puede usar @ junto con $, como en $\"{variable}", para crear cadenas interpoladas literales, donde las secuencias de escape se interpretan literalmente y las variables son interpoladas. 
