namespace ParcialArreglosGeronimoMonsalve
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] datos = new string[6, 6];


            datos[0, 0] = "Nombre";
            datos[0, 1] = "Grado";
            datos[0, 2] = "Parcial1";
            datos[0, 3] = "Parcial2";
            datos[0, 4] = "Examen";
            datos[0, 5] = "Final";

            float[,] notas = new float[5, 3];
            float[] promedios = new float[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("\nEstudiante " + (i + 1));

                Console.Write("Nombre: ");
                datos[i + 1, 0] = Console.ReadLine();


                string grado = "";
                while (grado != "6" && grado != "7" && grado != "8" && grado != "9")
                {
                    Console.Write("Grado (6,7,8,9): ");
                    grado = Console.ReadLine();
                    if (grado != "6" && grado != "7" && grado != "8" && grado != "9")
                        Console.WriteLine("Grado inválido. Ingrese solo 6, 7, 8 o 9.");
                }
                datos[i + 1, 1] = grado;


                float n1 = -1, n2 = -1, n3 = -1;

                while (n1 < 0 || n1 > 5)
                {
                    Console.Write("Parcial 1 (0 a 5): ");
                    n1 = float.Parse(Console.ReadLine());
                    if (n1 < 0 || n1 > 5)
                        Console.WriteLine("La nota debe estar entre 0 y 5.");
                }

                while (n2 < 0 || n2 > 5)
                {
                    Console.Write("Parcial 2 (0 a 5): ");
                    n2 = float.Parse(Console.ReadLine());
                    if (n2 < 0 || n2 > 5)
                        Console.WriteLine("La nota debe estar entre 0 y 5.");
                }

                while (n3 < 0 || n3 > 5)
                {
                    Console.Write("Examen Final (0 a 5): ");
                    n3 = float.Parse(Console.ReadLine());
                    if (n3 < 0 || n3 > 5)
                        Console.WriteLine("La nota debe estar entre 0 y 5.");
                }


                float prom = (n1 + n2 + n3) / 3;

                notas[i, 0] = n1;
                notas[i, 1] = n2;
                notas[i, 2] = n3;
                promedios[i] = prom;


                datos[i + 1, 2] = "" + n1;
                datos[i + 1, 3] = "" + n2;
                datos[i + 1, 4] = "" + n3;
                datos[i + 1, 5] = "" + prom;
            }


            Console.WriteLine("\n=== MATRIZ DE ESTUDIANTES ===\n");
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    string texto = datos[i, j];
                    if (texto == null) texto = "";
                    Console.Write(texto.PadRight(15));
                }
                Console.WriteLine();
            }


            float mayor = promedios[0];
            int pos = 0;
            for (int i = 1; i < 5; i++)
            {
                if (promedios[i] > mayor)
                {
                    mayor = promedios[i];
                    pos = i;
                }
            }

            Console.WriteLine("\nEl mejor estudiante es: " + datos[pos + 1, 0] + " con nota " + mayor);
        }
    }
}
