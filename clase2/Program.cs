using System;

namespace clase2
{
    class Program
    {
        static void Main(string[] args)

        {
            double costo=0, cliente=0, cambio=0;
            Console.WriteLine("ingrese el costo del articulo:");
            costo = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese la cantidad entregada por el cliente:");
            cliente = double.Parse(Console.ReadLine());
            cambio = cliente - costo;
            Console.WriteLine("el total a pagar es:" + cambio);
       
        }
    }
}
