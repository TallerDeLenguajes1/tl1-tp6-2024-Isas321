# Preguntas sobre el tipo `string` en C#

### ¿String es un tipo por valor o un tipo por referencia?

En C#, string es un tipo por referencia. Aunque no cambia, cuando lo pasas a un método, solo se pasa una referencia al string, no una copia.

### ¿Qué secuencias de escape tiene el tipo `string`?

Soporta varias secuencias de escape, que permiten incluir caracteres especiales en las cadenas de texto. Las más comunes son:

- `\n` : Nueva línea
- `\r` : Retorno de carro
- `\t` : Tabulador
- `\\` : Barra invertida
- `\"` : Comillas dobles
- `\'` : Comillas simples
- `\b` : Retroceso (Backspace)
- `\f` : Salto de página
- `\0` : Carácter nulo

Estas secuencias de escape permiten manejar y formatear textos de manera más efectiva en C#.

### ¿Qué sucede cuando utiliza el carácter `@` y `$` antes de una cadena de texto?

En C#, el uso de los caracteres `@` y `$` antes de una cadena de texto tiene significados especiales:

`@` (cadena literal): Cuando se coloca `@` antes de una cadena, se trata como una cadena literal, lo que significa que las secuencias de escape no se procesan. Esto es útil para escribir rutas de archivos o cadenas que contienen muchas barras invertidas. Tambien es util para graficos en modo consola para el proyecto de la materia.
