// using System;

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


﻿using EspacioCalculadora;
//Enu define un dominio, define los tio de dato
Calculadora calcula = new();  
int opcion;
double x, valorAntesDeOperar;

do
{
    Console.WriteLine("\n\n\nCalculadora\n");
    Console.WriteLine("1-Sumar");
    Console.WriteLine("2-Restar");
    Console.WriteLine("3-Multiplicar");
    Console.WriteLine("4-Dividir");
    Console.WriteLine("5-Limpiar");
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
      default:
        Console.WriteLine("\nSaliendo del programa...");
        return 0;
    }
} while (opcion==1 || opcion==2 || opcion==3 || opcion==4 || opcion==5);
return 0;

int ingresaEntero(){
  int num;
  if(int.TryParse(Console.ReadLine(), out num)){
    return num;
  } else{
    return -999;
  }
}

double ingresaReal(){
  double num;
  if(double.TryParse(Console.ReadLine(), out num)){
    return num;
  } else{
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