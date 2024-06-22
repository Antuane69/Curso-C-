using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Primer_Proyecto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int x = 10;
            //int y = 20;
            //int z = 30;

            /*
            //Variables de Numero
            int x = 10, y = 10, z = 10;

            string textAge = "-23";
            int age = Convert.ToInt32(textAge);
            Console.WriteLine(age);

            string textBN = "900000000";
            long bigNumber = Convert.ToInt64(textBN);
            Console.WriteLine(bigNumber);

            string textNegative = "-49.5";
            double negative = Convert.ToDouble(textNegative);
            Console.WriteLine(negative);

            string textPre = "5000001";
            float precision = Convert.ToSingle(textPre);
            Console.WriteLine(precision);

            string textMoney = "18.99";
            decimal money = Convert.ToDecimal(textMoney);
            Console.WriteLine(money);

            //Variables de Texto
            string name = "Emma";
            char letter = 'a';

            Console.Write("Tu nombre es ");
            Console.Write(name);
            Console.WriteLine();
            Console.WriteLine(letter);
            Console.ReadLine();

            //Variables Booleanas
            bool value = false;
            bool isMale = true;

            //Operadores
            int age2 = 23;
            Console.WriteLine(age2);
            age2++;
            Console.WriteLine(age2);
            age2--;
            Console.WriteLine(age2);

            age2 += 2;
            Console.WriteLine(age2);
            age2 -= 15;
            Console.WriteLine(age2);
            age2 *= 10;
            Console.WriteLine(age2);

            string nombre = "Antuane";
            nombre += " esta programando";
            Console.WriteLine(nombre);

            char let = 'a';
            let += 'b';
            Console.WriteLine(let);

            int i = 0;
            Console.WriteLine(++i);


            //Residuo
            int firtnum = 10;
            int secondNum = 2;

            Console.WriteLine(firtnum%secondNum);

            //variables de tipo automatico python
            var age = 23;
            var bign = 900000L;
            var money = 6.000;
            var nombre = "antuane";
            var lett = 'b';

            //variables constantes
            const int vat = 20;
            const double percentVAT = vat / 100D;

            int balance = 1000;

            Console.WriteLine(balance * (vat/100D));
            Console.WriteLine(balance * percentVAT);

            var name = "Emma";
            var number = "0123456789";
            var age = 23;

            Console.WriteLine(name);
            Console.WriteLine(number);
            Console.WriteLine(age);

            int var1 = 10;
            int var2 = 2;
            int residuo = var1 % var2;
            Console.WriteLine(residuo);

            var1 = 11;
            residuo = var1 % var2;
            Console.WriteLine(residuo);*/

            //Consola Lectura
            //Console.Write("Ingresa tu nombre: ");
            //string nombre = Console.ReadLine();
            //Console.WriteLine(nombre);

            //Console.Write("Pon tu edad: ");
            //int age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(age);
            /*
            //Console.Write("Tu nombre es ");
            //Console.Write(nombre);
            //Console.Write(" Tu edad es ");
            //Console.Write(age);
            Console.WriteLine();
            Console.WriteLine("Tu nombre es " + nombre + " y tu edad es " + age);

            //Flujos de if, else
            //>= == <= < > !=

            if(age < 0 || age > 150)
            {
                Console.WriteLine("Edad Incorrecta");
            }
            else
            {
                if (age >= 18 && age <= 25)
                {
                    Console.WriteLine("Tienes 18 anios o mas");
                }
                else if (age > 25)
                {
                    Console.WriteLine("Tienes 25 anios o mas");
                }

                Console.WriteLine("Edad Correcta");
            }

            Console.Write("Ingresa el primer numero: ");
            int numberA = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingresa el segundo numero: ");
            int numberb = Convert.ToInt32(Console.ReadLine());

            int answer = numberA * numberb;
            Console.Write("El valor de " + numberA + " * " + numberb + ": ");
            string answerInput = Console.ReadLine();
            int actualAnswer = Convert.ToInt32(answerInput);

            if(actualAnswer == answer)
            {
                Console.WriteLine("Lo lograste!");
            }
            else
            {
                Console.WriteLine("Te equivocaste");
            }

            //Switch
            Console.WriteLine("Escribe el dia de la semana: ");
            int day = Convert.ToInt32(Console.ReadLine());

            if(day == 1)
            {
                Console.WriteLine("Monday");
            }
            else if(day == 2)
            {
                Console.WriteLine("Tuesday");
            }

            switch (day)
            {
                case 1:
                    Console.WriteLine("mondat");
                    break;
                case 2:
                    Console.WriteLine("tuesday");
                    break;
                case 3:
                    Console.WriteLine("wednesday");
                    break;
                case 4:
                    Console.WriteLine("thursday");
                    break;
                case 5:
                    Console.WriteLine("friday");
                    break;
                case 6:
                    Console.WriteLine("saturday");
                    break;
                case 7:
                    Console.WriteLine("sunday");
                    break;
                default:
                    Console.WriteLine("Dia invalido");
                    break;
            }*/

            //Ciclos

            Console.ReadLine();
        }
    }
}
