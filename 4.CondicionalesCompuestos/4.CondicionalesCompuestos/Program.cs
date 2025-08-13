namespace _4.CondicionalesCompuestos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*4. Crear un algoritmo que permita ingresar el nombre y el sueldo de una persona, si el sueldo supera los 3000 pesos mostrar el mensaje en pantalla con el nombre de la persona, indicando que debe abonar impuestos. De lo contrario mostrar el mensaje “Persona exenta de impuestos”.*/
            string nombre = "";
            int sueldo = 0;

            Console.WriteLine("Ingrese nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su sueldo");
            sueldo = Int32.Parse(Console.ReadLine());
            if (sueldo >= 3000)
            {
                //VERDADERA
                Console.WriteLine($"La persona {nombre}, debe abonar impuestos");
            }
            else
            {
                //FALSO
                Console.WriteLine($"La persona {nombre}, no debe abonar impuestos");
            }

            int edad = 0;

            Console.WriteLine("ingrese su edad");
            edad = Int32.Parse(Console.ReadLine());

            if (edad > 18)
            {
                Console.WriteLine($"la persona {nombre},es bienvenido a mi sitio web");

            }
            else
            {
                Console.WriteLine($"la persona {nombre}, no es bienvenida a mi sitio web");
            }

            int numero1 = 0;
            int numero2 = 0;

            Console.WriteLine("ingresar el primer numero");
            numero1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("ingresar el segundo numero");
            numero2 = Int32.Parse(Console.ReadLine());

            if (numero1 > numero2);
            {
                Console.WriteLine($"la suma es+ {numero1 + numero2}");
                Console.WriteLine($"la diferencia es + {numero1 + numero2}");
            }

          

            
        }
    }
}