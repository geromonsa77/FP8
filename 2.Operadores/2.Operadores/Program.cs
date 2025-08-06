﻿using System.ComponentModel.DataAnnotations.Schema;

namespace _2.Operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //OPERADORES
            //Operadores numericos
            //Cambio de signo
            int num1 = 5;
            int num2 = -num1;
            int num3 = +num2;
            int num4 = -num3;
            Console.WriteLine(num1 + "//" + num2 + "//" + num3 + "//" + num4);

            //Aritmeticos 
            int num5 = 3 + 5;//Suma
            Console.WriteLine(num5);
            int num6 = 100 - 26;//Resta
            Console.WriteLine(num6);
            int num7 = 4 * 2;//Producto
            Console.WriteLine(num7);
            //float num8 = (float) 5 / 3;//Division
            //float num8 = 5f / 3;
            //float num8 = 5 / 3f;
            float num8 = 5f / 3f;
            Console.WriteLine(num8);
            double num9 = 105d / 4;
            Console.WriteLine(num9);
            decimal num10 = 50m / 6;
            Console.WriteLine(num10);

            //Incremento decremneto
            num10++;//num10 = num10 + 1;
            Console.WriteLine(num10);
            num1--;//num1=num1-1; Decremento
            Console.WriteLine(num1);
            num2 += 5;//num2 = num2+5
            Console.WriteLine(num2);
            num3 -= 5;//num2 = num3-5
            Console.WriteLine(num3);
            num4 *= 5;//num2 = num4*5
            Console.WriteLine(num4);
            num5 /= num1;//num5= num5 / num1;
            Console.WriteLine(num5);

            //Orden de evaluacvion operadores aritmeticos
            float num11 = 4f * 3 / 2;
            Console.WriteLine(num11);
            float num12 = 4 / 3 * 2f;
            Console.WriteLine(num12);
            float num13 = (4 * 3) / 2;
            Console.WriteLine(num13);
            float num14 = 4 + 6 * 2;
            Console.WriteLine(num14);
            float num15 = 4 + 6 * (2 - 1);
            Console.WriteLine(num15);

            //OPERADORES LOGICOS
            //CONJUNCIONES - AND - Y - &&
            Console.WriteLine("TABLA DE VERDAD CONJUNCION");
            Console.WriteLine($"V && V 0{true && true}");
            Console.WriteLine($"V && V 0{true && false}");
            Console.WriteLine($"V && V 0{false && true}");
            Console.WriteLine($"V && V 0{false && false}");

            //DISYUNCION -- OR - ||

            Console.WriteLine("TABLA DE VERDAD DISYUNCION");
            Console.WriteLine($"V || V 0{true || true}");
            Console.WriteLine($"V || V 0{true || true}");
            Console.WriteLine($"V || V 0{true || true}");
            Console.WriteLine($"V || V 0{true || true}");

            bool exp1 = true;
            bool exp2 = false;
            bool exp3 = exp1 && exp2;
            bool exp4 = !exp2;
            bool exp5 = !exp3 || exp4;
            Console.WriteLine($"exp1={exp1}, exp2{exp2}, exp3{exp3}, exp4{exp4}, exp5{exp5}");









        }
    }
}
