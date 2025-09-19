namespace Parcia_Ciclos_Geronimo_Monsalve
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*El almacén Oxford cuenta con los registros mensuales del número de ventas del año anterior y requiere un programa que procese esta información para evaluar el desempeño anual.
  El programa debe realizar las siguientes operaciones:
  Ingresar por teclado el número de ventas realizadas en cada mes (12 meses en total).
  Calcular el promedio anual de ventas.
  Determinar y mostrar el mes con mayor número de ventas.
  Determinar y mostrar el mes con menor número de ventas.
  Evaluar el promedio anual de ventas y mostrar un mensaje:
  Si el promedio es mayor a 500 ventas, mostrar: “Se aprobó la meta”.
  Si el promedio es menor o igual a 500 ventas, mostrar: “La meta de ventas no se cumplió”.*/

            int TotalMeses = 12;
            float acumuladoVentas = 0;
            float ventasMaximas = 0;
            float ventasMinimas = 0;
            float mesMaximo = 0;
            float mesMinimo = 0;
            float ventasMes = 0;
            float promedioAnual = 0;

            Console.WriteLine("Registro de ventas mensuales del año anterior:");

            for (int mes = 1; mes <= TotalMeses; mes++)
            {
                Console.Write($"Ingrese las ventas del mes {mes}: ");
                ventasMes = Convert.ToInt32(Console.ReadLine());


                acumuladoVentas += ventasMes;


                if (mes == 1)
                {
                    ventasMaximas = ventasMes;
                    ventasMinimas = ventasMes;
                    mesMaximo = mes;
                    mesMinimo = mes;
                }
                else
                {
                    if (ventasMes > ventasMaximas)
                    {
                        ventasMaximas = ventasMes;
                        mesMaximo = mes;
                    }

                    if (ventasMes < ventasMinimas)
                    {
                        ventasMinimas = ventasMes;
                        mesMinimo = mes;
                    }
                }
            }


            promedioAnual = acumuladoVentas / TotalMeses;
            if (promedioAnual > 500)
            {
                Console.WriteLine("Se aprobó la meta.");
            }
            else
            {
                Console.WriteLine("La meta de ventas no se cumplió.");

            }
            Console.WriteLine($"El promedio de ventas es: {promedioAnual}");
            Console.WriteLine($"Mes con mayor número de ventas: {mesMaximo} ({ventasMaximas} ventas)");
            Console.WriteLine($"Mes con menor número de ventas: {mesMinimo} ({ventasMinimas} ventas)");


        }
    }
}
