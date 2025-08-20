namespace _6.CondicionalMultipleTerciario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float ValorCompra = 0;
            float descuento = 0;
            char dia = ' ';

            Console.WriteLine("Ingrese el valor de la comrpa: ");
            ValorCompra = Single.Parse(Console.ReadLine());
            Console.WriteLine($"Ingrese el día de la semana: L: Lunes, M: Martes, X: Miercoles, J: Jueves, V: Viernes, S: Sábado, D: Domingo ");
            dia = Convert.ToChar(Console.ReadLine());

            switch (dia)
            {
                case 'L':
                    descuento = ValorCompra * 0.1f;
                    Console.WriteLine($"Hoy es lunes, descuento de {descuento}, valor total de la compra {ValorCompra - descuento}");

                    break;

                case 'M':
                    descuento = ValorCompra * 0.15f;
                    Console.WriteLine($"Hoy es martes, descuento de {descuento}, valor total de la compra {ValorCompra - descuento}");

                    break;

                case 'X':
                    descuento = ValorCompra * 0.1f;
                    Console.WriteLine($"Hoy es miercoles, descuento de {descuento}, valor total de la compra {ValorCompra - descuento}");

                    break;

                case 'J':
                    descuento = ValorCompra * 0.15f;
                    Console.WriteLine($"Hoy es jueves, descuento de {descuento}, valor total de la compra {ValorCompra - descuento}");

                    break;

                case 'V':
                    descuento = ValorCompra * 0.2f;
                    Console.WriteLine($"Hoy es viernes, descuento de {descuento}, valor total de la compra {ValorCompra - descuento}");

                    break;

                case 'S':
                    descuento = ValorCompra * 0.2f;
                    Console.WriteLine($"Hoy es sábado, descuento de {descuento}, valor total de la compra {ValorCompra - descuento}");

                    break;

                case 'D':
                    descuento = ValorCompra * 0;
                    Console.WriteLine($"Hoy es domingo, descuento de {descuento}, valor total de la compra {ValorCompra - descuento}");

                    break;
            }

        }
    }
}