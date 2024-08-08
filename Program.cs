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








// Ejercicio 2. Ingrese al branch CalculadoraV1 y construya un programa que sea una
// calculadora que permita al usuario realizar las 4 operaciones básicas (Sumar, Restar,
// Multiplicar y Dividir) a partir de un menú para seleccionar la opción a elegir y que luego
// pida dos números y que devuelva el resultado de la operación seleccionada. Además
// una vez que termine de realizar la operación le pregunte si desea realizar otro cálculo.

// Ejercicio 3. Ingrese al Branch CalculadoraV2 para implementar las mejoras en la
// calculadora.. Solicite al usuario un número y muestre por pantalla:
// ● El valor absoluto de un número
// ● El cuadrado
// ● La raíz cuadrada
// ● El seno
// ● El Coseno
// ● La parte entera de un tipo float
// Luego de esto, solicite dos números al usuario y determine:
// ● El Máximo entre los dos números
// ● El Mínimo entre los dos números



﻿using EspacioCalculadora;
using System.Globalization;

Calculadora calcula = new();  
int opcion;
double x, y, resultado, valorAntesDeOperar;

do
{
    Console.WriteLine("\n\n\nCalculadora\n");
    Console.WriteLine("1-Sumar");
    Console.WriteLine("2-Restar");
    Console.WriteLine("3-Multiplicar");
    Console.WriteLine("4-Dividir");
    Console.WriteLine("5-Limpiar");
    Console.WriteLine("6-Valor absoluto");
    Console.WriteLine("7-Cuadrado");
    Console.WriteLine("8-Raíz cuadrada");
    Console.WriteLine("9-Seno");
    Console.WriteLine("10-Coseno");
    Console.WriteLine("11-Parte entera de un float");
    Console.WriteLine("12-Máximo entre dos números");
    Console.WriteLine("13-Mínimo entre dos números");
    Console.WriteLine("Salir -> Presione cualquier otra tecla");
    Console.Write("\nIngrese opcion: ");
    opcion = ingresaEntero();
    switch (opcion)
    {
        case 1:
            valorAntesDeOperar=calcula.Resultado;
            Console.Write("\nValor actual: "+valorAntesDeOperar);
            Console.Write("\nIngrese numero que desea sumar: ");
            x = ingresarNumeroReal();
            calcula.Sumar(x);
            Console.WriteLine("\nEl resultado de "+valorAntesDeOperar+" + "+x+" es: "+calcula.Resultado);
            Console.Write("\nPrecione una tecla para continuar\t");
            Console.ReadKey();
            break;
        case 2:
            valorAntesDeOperar=calcula.Resultado;
            Console.Write("\nValor actual: "+valorAntesDeOperar);
            Console.Write("\nIngrese numero que desea restar: ");
            x = ingresarNumeroReal();
            calcula.Restar(x);
            Console.WriteLine("\nEl resultado de "+valorAntesDeOperar+" - "+x+" es: "+calcula.Resultado);
            Console.Write("\nPrecione una tecla para continuar\t");
            Console.ReadKey();
        break;
      case 3:
            valorAntesDeOperar=calcula.Resultado;
            Console.Write("\nValor actual: "+valorAntesDeOperar);
            Console.Write("\nIngrese numero por el que desea multiplicar: ");
            x = ingresarNumeroReal();
            calcula.Multiplicar(x);
            Console.WriteLine("\nEl resultado de "+valorAntesDeOperar+" * "+x+" es: "+calcula.Resultado);
            Console.Write("\nPrecione una tecla para continuar\t");
            Console.ReadKey();
        break;
      case 4:
            valorAntesDeOperar=calcula.Resultado;
            Console.Write("\nValor actual: "+valorAntesDeOperar);
            Console.Write("\nIngrese numero por el que desea dividir: ");
            do{
              x = ingresarNumeroReal();
            } while(x==0);
            calcula.Dividir(x);
            Console.WriteLine("\nEl resultado de "+valorAntesDeOperar+" / "+x+" es: "+calcula.Resultado);
            Console.Write("\nPrecione una tecla para continuar\t");
            Console.ReadKey();
        break;
      case 5:
            calcula.Limpiar();
            Console.WriteLine("\nValor inicial reiniciado a 0");
            Console.ReadKey();
        break;
        case 6:
            Console.Write("\nIngrese un número para obtener su valor absoluto: ");
            x = ingresarNumeroReal();
            resultado = Math.Abs(x);
            Console.WriteLine("\nEl valor absoluto de " + x + " es: " + resultado);
            Console.ReadKey();
            break;
        case 7:
            Console.Write("\nIngrese un número para obtener su cuadrado: ");
            x = ingresarNumeroReal();
            resultado = Math.Pow(x, 2);
            Console.WriteLine("\nEl cuadrado de " + x + " es: " + resultado);
            Console.ReadKey();
            break;
        case 8:
            Console.Write("\nIngrese un número para obtener su raíz cuadrada: ");
            x = ingresarNumeroReal();
            if (x < 0)
            {
                Console.WriteLine("\nNo se puede calcular la raíz cuadrada de un número negativo.");
            }
            else
            {
                resultado = Math.Sqrt(x);
                Console.WriteLine("\nLa raíz cuadrada de " + x + " es: " + resultado);
            }
            Console.ReadKey();
            break;
        case 9:
            Console.Write("\nIngrese un número para obtener su seno: ");
            x = ingresarNumeroReal();
            resultado = Math.Sin(x);
            Console.WriteLine("\nEl seno de " + x + " es: " + resultado);
            Console.ReadKey();
            break;
        case 10:
            Console.Write("\nIngrese un número para obtener su coseno: ");
            x = ingresarNumeroReal();
            resultado = Math.Cos(x);
            Console.WriteLine("\nEl coseno de " + x + " es: " + resultado);
            Console.ReadKey();
            break;
        case 11:
            Console.Write("\nIngrese un número decimal para obtener su parte entera: ");
            x = ingresarNumeroReal();
            resultado = Math.Truncate(x);
            Console.WriteLine("\nLa parte entera de " + x + " es: " + resultado);
            Console.ReadKey();
            break;
        case 12:
            Console.Write("\nIngrese el primer número: ");
            x = ingresarNumeroReal();
            Console.Write("\nIngrese el segundo número: ");
            y = ingresarNumeroReal();
            resultado = Math.Max(x, y);
            Console.WriteLine("\nEl máximo entre " + x + " y " + y + " es: " + resultado);
            Console.ReadKey();
            break;
        case 13:
            Console.Write("\nIngrese el primer número: ");
            x = ingresarNumeroReal();
            Console.Write("\nIngrese el segundo número: ");
            y = ingresarNumeroReal();
            resultado = Math.Min(x, y);
            Console.WriteLine("\nEl mínimo entre " + x + " y " + y + " es: " + resultado);
            Console.ReadKey();
            break;
      default:
        Console.WriteLine("\nSaliendo del programa...");
        return 0;
    }
} while (opcion >= 1 && opcion <= 13);
return 0;

int ingresaEntero(){
  int num;
  if(int.TryParse(Console.ReadLine(), out num)){
    return num;
  } else{
    return -999;
  }
}

double ingresaReal()
{
    double num;
    string? input = Console.ReadLine();
    input = input?.Replace(',', '.');
    if (double.TryParse(input, NumberStyles.Float, CultureInfo.InvariantCulture, out num))
    {
        return num;
    }
    else
    {
        Console.WriteLine("Entrada no válida. Por favor, ingrese un número decimal.");
        return -999;
    }
}

double ingresarNumeroReal()
{
    double a;
    do
    {
        a = ingresaReal();
    } while (a == -999);
    return a;
}