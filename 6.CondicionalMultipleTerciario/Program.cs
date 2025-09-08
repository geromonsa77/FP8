﻿namespace _6.CondicionalMultipleTerciario
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

            /*Diseñar un algoritmo que permita crear una calculadora básica capaz de realizar operaciones aritméticas entre dos números ingresados por el usuario. 
           Las operaciones disponibles serán: suma, resta, multiplicación y división, las cuales se ejecutarán según la opción seleccionada por el usuario.*/

            float num1 = 0;
            float num2 = 0;
            float num3 = 0;
            char opcion = ' ';

            Console.WriteLine("Ingrese el número 1: ");
            num1 = Single.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el número 2: ");
            num2 = Single.Parse(Console.ReadLine());
            Console.WriteLine($"Seleccione la opción que desea realizar: 1. Suma, 2. Resta, 3. Multiplicación, 4. División ");
            opcion = Convert.ToChar(Console.ReadLine());

            switch (opcion)
            {
                case '1':
                    num3 = num1 + num2;
                    Console.WriteLine($"La operación que se realizó fue una suma y el resultado es {num3}");

                    break;

                case '2':
                    num3 = num1 - num2;
                    Console.WriteLine($"La operación que se realizó fue una resta y el resultado es {num3}");

                    break;

                case '3':
                    num3 = num1 * num2;
                    Console.WriteLine($"La operación que se realizó fue una multiplicación y el resultado es {num3}");

                    break;

                case '4':
                    num3 = num1 / num2;
                    Console.WriteLine($"La operación que se realizó fue una división y el resultado es {num3}");

                    break;


            }
               /* Diseñar un algoritmo que solicite al usuario un número del 1 al 12, 
               correspondiente a un mes del año (1 para enero, 2 para febrero, etc.). 
               El algoritmo debe mostrar en pantalla el nombre del mes seleccionado 
               y la cantidad de días que contiene.*/
                                   

            int numeroMes = 0;
            string resultado = "";

            Console.WriteLine("Ingrese un número del 1 al 12 correspondiente a un mes: ");
            numeroMes = int.Parse(Console.ReadLine());


            switch (numeroMes)
            {
                case 1:
                    resultado = "Enero tiene 31 días";
                    break;

                case 2:
                    resultado = "Febrero tiene 28 o 29 días";
                    break;

                case 3:
                    resultado = "Marzo tiene 31 días";
                    break;

                case 4:
                    resultado = "Abril tiene 30 días";
                    break;

                case 5:
                    resultado = "Mayo tiene 31 días";
                    break;

                case 6:
                    resultado = "Junio tiene 30 días";
                    break;

                case 7:
                    resultado = "Julio tiene 31 días";
                    break;

                case 8:
                    resultado = "Agosto tiene 31 días";
                    break;

                case 9:
                    resultado = "Septiembre tiene 30 días";
                    break;

                case 10:
                    resultado = "Octubre tiene 31 días";
                    break;

                case 11:
                    resultado = "Noviembre tiene 30 días";
                    break;

                case 12:
                    resultado = "Diciembre tiene 31 días";
                    break;

                default:
                    resultado = "Número inválido. Ingrese un número entre 1 y 12.";
                    break;
            }

            Console.WriteLine(resultado);


        }



    }
}

      