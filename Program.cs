using System;

//variables para el programa
int seleccion;
double n1;
double n2;
double resultado;

Console.WriteLine("Bienvedio y gracias por utilizar nuestra calculadora");
Console.WriteLine("Por favor ingrese el número de la opcion que desea utilizar");
Console.WriteLine("0 - Sumar");
Console.WriteLine("1 - Restar");
Console.WriteLine("2 - Multiplicar");
Console.WriteLine("3 - Dividir");
Console.WriteLine("4 - Potencia");
Console.WriteLine("5 - Raiz cuadrada");
seleccion = int.Parse(Console.ReadLine());

switch (seleccion)
{
    case 0:
        Console.WriteLine("Por favor ingrese el primer número a sumar: ");
        n1 = double.Parse(Console.ReadLine());  
        Console.WriteLine("Por favor ingrese el segundo número a sumar: ");
        n2 = double.Parse(Console.ReadLine());
        resultado = n1 + n2;
        Console.WriteLine("El resultado es: " + resultado);
        break;
    case 1:
        Console.WriteLine("Por favor ingrese el primer número a restar: ");
        n1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Por favor ingrese el segundo número a restar: ");
        n2 = double.Parse(Console.ReadLine());
        resultado = n1 - n2;
        Console.WriteLine("El resultado es: " + resultado);
        break;
    case 2:
        Console.WriteLine("Por favor ingrese el primer número a multiplicar: ");
        n1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Por favor ingrese el segundo número a multiplicar: ");
        n2 = double.Parse(Console.ReadLine());
        resultado = n1 * n2;
        Console.WriteLine("El resultado es: " + resultado);
        break;
    case 3:
        Console.WriteLine("Por favor ingrese el primer número a dividir: ");
        n1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Por favor ingrese el segundo número a dividir: ");
        n2 = double.Parse(Console.ReadLine());
        resultado = n1 / n2;
        Console.WriteLine("El resultado es: " + resultado);
        break;
    case 4:
        Console.WriteLine("Por favor ingrese el número base: ");
        n1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Por favor ingrese el número de la potencia: ");
        n2 = double.Parse(Console.ReadLine());
        resultado = Math.Pow(n1,n2);
        Console.WriteLine("El resultado es: " + resultado);
        break;
    case 5:
        Console.WriteLine("Por favor ingrese el primer número al que desea sacar la raiz: ");
        n1 = double.Parse(Console.ReadLine());
        resultado = Math.Sqrt(n1);
        Console.WriteLine("El resultado es: " + resultado);
        break;
}


