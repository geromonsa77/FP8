namespace _1.InicioVisualStudio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaración e inicialización de variables
            string nombre = "gero";
            const string iva = "19%";
            string apellidos = "Monsalve Jaramillo";
            Console.Write(" Bienvenidos al curso de Fundamentos de Programación\n");
            nombre = "Geronimo";
            //iva = "20%"; No puede cambiar el valor de "iva" por ser una constante
            Console.Write("\t" + nombre + " " + apellidos + " " + iva);
            Console.ReadKey();
        }
    }
}
