namespace _7.OperadorTernario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Operador Ternario//
            /*Escribe un programa que verifique si una persona es mayor de edad usando el operador ternario. 
             Una persona mayor de edad tiene 18 años o más).*/

            int edad = 0;
            Console.WriteLine("ingrese su edad");
            edad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(edad >= 18 ? "La persona es mayor de edad" : "La persona es menor de edad ");


            /*Crear un algoritmo que permita ingresar 3 numeros enteros,
             y mostrar por pantalla cual es el mayor*/

            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            int mayor = 0;

            Console.WriteLine("Ingrese el numero 1:");
            num1=Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el numero 2:");
            num2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el numero 3:");
            num3 = Int32.Parse(Console.ReadLine());

            mayor = num1 > num2 ? (num1 > num3 ? num1 : num3)
                : (num2> num3 ? num2 : num3);
            Console.WriteLine($"El numero mayor es: {mayor}");
        }
    }
}
