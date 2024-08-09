using System;

// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Hello, World!");

//         int a;
//         int b;
//         a = 10;
//         b = a;

//         Console.WriteLine("valor de a: " + a);
//         Console.WriteLine("valor de b: " + b);

//         // Ejercicio 1. Construir un programa que permita invertir un número. Verifique que el
//         // texto ingresado es de hecho un número y, en caso afirmativo, realice la inversión del
//         // número sólo si éste es mayor a 0.
//         Console.WriteLine("\n\nINVERSION DE NUMEROS:");
//         Console.Write("Ingrese un número para invertir:");
//         int numero = IngresarEntero();

//         if (numero == -999)
//         {
//             Console.WriteLine("Debe ingresar un número.");
//         }
//         else if (numero > 0)
//         {
//             int numeroInvertido = InvertirNumero(numero);
//             Console.WriteLine("Número invertido: " + numeroInvertido);
//         }
//         else
//         {
//             Console.WriteLine($"El número {numero} debe ser mayor a 0 para aplicar la inversion.");
//         }
//     }

//     public static int IngresarEntero()
//     {
//         int num;
//         if (int.TryParse(Console.ReadLine(), out num))
//         {
//             return num;
//         }
//         else
//         {
//             return -999; 
//         }
//     }

//     public static int InvertirNumero(int numero)
//     {
//         char[] array = numero.ToString().ToCharArray();
//         Array.Reverse(array);
//         return int.Parse(new string(array));
//     }
// }











// EJERCICIO 4
// Realizar los siguientes ejercicios
// Dada una cadena (un string) de texto ingresada por el usuario, realice las siguientes
// tarea:


class Program
{
    static void Main()
    {
        // ● Obtener la longitud de la cadena y muestre por pantalla
        Console.Write("Ingrese una frase larga: ");
        string aux;
        aux = Console.ReadLine()!.ToString();
        Console.WriteLine("El tamaño de tu frase es: "+ aux.Length); 
        // ● A partir de una segunda cadena ingresada por el usuario, concatene ambas
        // cadenas distintas.
        Console.Write("Ingrese su segunda frase: ");
        String aux2;
        aux2 = Console.ReadLine()!.ToString();
        // ● Extraer una subcadena de la cadena ingresada
        string cadenaSalida = $"{aux} {aux2}"; 
        Console.WriteLine("Cadenas concatenadas: "+cadenaSalida);
        
    }
}
