using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello, World!");

        int a;
        int b;
        a = 10;
        b = a;

        Console.WriteLine("valor de a: " + a);
        Console.WriteLine("valor de b: " + b);

        // Ejercicio 1. Construir un programa que permita invertir un número. Verifique que el
        // texto ingresado es de hecho un número y, en caso afirmativo, realice la inversión del
        // número sólo si éste es mayor a 0.
        Console.WriteLine("\n\nINVERSION DE NUMEROS:");
        Console.Write("Ingrese un número para invertir:");
        int numero = IngresarEntero();

        if (numero == -999)
        {
            Console.WriteLine("Debe ingresar un número.");
        }
        else if (numero > 0)
        {
            int numeroInvertido = InvertirNumero(numero);
            Console.WriteLine("Número invertido: " + numeroInvertido);
        }
        else
        {
            Console.WriteLine($"El número {numero} debe ser mayor a 0 para aplicar la inversion.");
        }
    }

    public static int IngresarEntero()
    {
        int num;
        if (int.TryParse(Console.ReadLine(), out num))
        {
            return num;
        }
        else
        {
            return -999; 
        }
    }

    public static int InvertirNumero(int numero)
    {
        char[] array = numero.ToString().ToCharArray();
        Array.Reverse(array);
        return int.Parse(new string(array));
    }
}