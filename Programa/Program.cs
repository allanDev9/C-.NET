using System;

namespace CSharpHolaMundo
{
    class HolaMundo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola Mundo");

            string nombreCompleto = "Allan Noe Peña Guerra";
            //nombreCompleto = "Juan Orlando Hernandez";
            Console.WriteLine(nombreCompleto);

            int numero = 7;
            numero = numero + 2;
            Console.WriteLine(numero - 1);

            bool Numero = true;
            Console.WriteLine(Numero);

            var miNumero = 12 + 12;
            Console.WriteLine(miNumero);

            Console.WriteLine($"El valor la suma es {miNumero} y el bool es {Numero}.");
        }
    }
}
