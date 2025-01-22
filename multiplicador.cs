using System;

class multiplicador
{
    static void Main(){
        // El usuario ingresa el numero
        Console.Write("Ingrese un número entero: ");
        int numero;
        // Ciclo while para determinar si el numero es entero o no
        while (!int.TryParse(Console.ReadLine(), out numero))
        {
            Console.Write("Numero no valido, ingrese un numero entero: ");
        }
        int resultado = numero * 2;
        Console.WriteLine($"El resultado de multiplicar {numero} por 2 es: {resultado}");
    }
}
