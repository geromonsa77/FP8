namespace ParcialCondicionalesGeronimomonsalve
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pizzería Olafo");
            Console.WriteLine("Tipos de pizza disponibles:");
            Console.WriteLine("1. Vegetariana");
            Console.WriteLine("2. No vegetariana");
            Console.Write("Elige el tipo de pizza (1 o 2): ");
            int tipo = int.Parse(Console.ReadLine());

            string tipoPizza = "";
            string ingredientes = "";
            double precioBase = 0;
            double iva = 0;
            double precioFinal = 0;

            if (tipo == 1)
            {
                tipoPizza = "Vegetariana";
                Console.WriteLine("\nIngredientes disponibles (elige 3):");
                Console.WriteLine("Pimiento, Tofu, Champiñones, Tomate, Lechuga");

                Console.Write("Ingrediente 1: ");
                string ing1 = Console.ReadLine();
                Console.Write("Ingrediente 2: ");
                string ing2 = Console.ReadLine();
                Console.Write("Ingrediente 3: ");
                string ing3 = Console.ReadLine();

                ingredientes = $"{ing1}, {ing2}, {ing3}";

                if ((ing1.ToLower() == "pimiento" || ing2.ToLower() == "pimiento" || ing3.ToLower() == "pimiento") &&
                    (ing1.ToLower() == "champiñones" || ing2.ToLower() == "champiñones" || ing3.ToLower() == "champiñones") &&
                    (ing1.ToLower() == "lechuga" || ing2.ToLower() == "lechuga" || ing3.ToLower() == "lechuga"))
                {
                    precioBase = 20000;
                    iva = 0.19;
                }
                else if ((ing1.ToLower() == "tofu" || ing2.ToLower() == "tofu" || ing3.ToLower() == "tofu") &&
                         (ing1.ToLower() == "champiñones" || ing2.ToLower() == "champiñones" || ing3.ToLower() == "champiñones") &&
                         (ing1.ToLower() == "lechuga" || ing2.ToLower() == "lechuga" || ing3.ToLower() == "lechuga"))
                {
                    precioBase = 30000;
                    iva = 0.15;
                }
                else
                {
                    precioBase = 25000;
                    iva = 0.10;
                }
            }
            else if (tipo == 2)
            {
                tipoPizza = "No vegetariana";
                Console.WriteLine("\nIngredientes disponibles (elige 2):");
                Console.WriteLine("Res, Chorizo, Pollo, Tocineta, Cerdo");

                Console.Write("Ingrediente 1: ");
                string ing1 = Console.ReadLine();
                Console.Write("Ingrediente 2: ");
                string ing2 = Console.ReadLine();

                ingredientes = $"{ing1}, {ing2}";

                if ((ing1.ToLower() == "res" && ing2.ToLower() == "pollo") ||
                    (ing1.ToLower() == "pollo" && ing2.ToLower() == "res"))
                {
                    precioBase = 10000;
                    iva = 0.19;
                }
                else if ((ing1.ToLower() == "res" && ing2.ToLower() == "tocineta") ||
                         (ing1.ToLower() == "tocineta" && ing2.ToLower() == "res"))
                {
                    precioBase = 15000;
                    iva = 0.17;
                }
                else if ((ing1.ToLower() == "chorizo" && ing2.ToLower() == "tocineta") ||
                         (ing1.ToLower() == "tocineta" && ing2.ToLower() == "chorizo"))
                {
                    precioBase = 25000;
                    iva = 0.09;
                }
                else
                {
                    precioBase = 22000;
                    iva = 0.10;
                }
            }
            else
            {
                Console.WriteLine("Opción no válida.");
                return;
            }

            double valorIva = precioBase * iva;
            precioFinal = precioBase + valorIva;

            Console.WriteLine("\nResumen de tu pedido");
            Console.WriteLine($"Tipo de pizza: {tipoPizza}");
            Console.WriteLine($"Ingredientes: {ingredientes}");
            Console.WriteLine($"IVA aplicado: {iva * 100}%");
            Console.WriteLine($"Precio base: ${precioBase:N0}");
            Console.WriteLine($"Valor del IVA: ${valorIva:N0}");
            Console.WriteLine($"Precio final: ${precioFinal:N0}");
        }
    }
    
}
