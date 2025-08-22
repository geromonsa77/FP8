namespace _8.TallerCondicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Taller //

/* 1. Crear un algoritmo que permita leer tres valores y almacenarlos en las variables numero1, 
numero2, numero3 respectivamente. El algoritmo debe comprobar si los números son 
diferentes, si es así, imprimir cual es el número mayor, además ordenar y mostrar en 
pantalla los números de menor a mayor. 
Si hay números iguales, el algoritmo debe mostrar un mensaje indicando que se deben 
ingresar números diferentes. */

            int numero1 = 0;
            int numero2 = 0;
            int numero3 = 0;
            int mayor = 0;
            int centro = 0;
            int menor = 0;

            Console.WriteLine("Ingrese el numero 1");
            numero1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el numero 2");
            numero2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el numero 3");
            numero3 = Int32.Parse(Console.ReadLine());

            if (numero1 != numero2 && numero2 != numero3 && numero3 != numero1)
            {
                mayor = numero1;
                if (numero2 > mayor) mayor = numero2;
                if(numero3 > mayor) mayor = numero3;
                Console.WriteLine($"El numero mayor es {mayor}");
                centro = numero3;
                if (numero3 > numero2 && numero3 < numero1) centro = numero3;
                menor = numero2;
                Console.WriteLine($"El orden de los numero de menor a mayor es: {menor}, {centro}, {mayor}");
            }
           
            
               
            
            



        }
}
}
