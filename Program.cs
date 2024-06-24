using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.IO;
using System.Threading;
using System.Net.Http;

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
            }

            //Ciclos
            Console.Write("Que quieres repetir: ");
            string aux = Console.ReadLine(); 
            Console.Write("Cuantas veces quieres que se diga " + aux + ": ");
            int var = Convert.ToInt32(Console.ReadLine());

            if(var <= 0)
            {
                Console.WriteLine("Eliga otro numero arriba de 0");
            }
            else
            {
                for (int i = 0; i < var; i++)
                {
                    Console.WriteLine(aux);
                }
            }
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine(i);
                i++;
            }

            Console.Write("Ingresa el primer numero: ");
            int numberA = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingresa el segundo numero: ");
            int numberb = Convert.ToInt32(Console.ReadLine());

            int answer = numberA * numberb;
            Console.Write("El valor de " + numberA + " * " + numberb + ": ");
            int actualAnswer = 0;

            /*while (answer != actualAnswer) {
                Console.ReadLine();
                Console.Write("escribe tu respuesta: ");
                string answerInput = Console.ReadLine();
                actualAnswer = Convert.ToInt32(answerInput);
                if (answer != actualAnswer)
                {
                    Console.WriteLine("Casi pero no");
                }
                
                Console.ReadLine();
            }

            do
            {
                Console.Write("escribe tu respuesta: ");
                string answerInput = Console.ReadLine();
                actualAnswer = Convert.ToInt32(answerInput);
                if (answer != actualAnswer)
                {
                    Console.WriteLine("Casi pero no");
                    Console.WriteLine();
                }

                Console.ReadLine();
            } while(answer != actualAnswer);

            Console.WriteLine("lo lograste");

            int age = 10;
            if(age >= 0)
            {
                Console.WriteLine("valid");
            }
            else
            {
                Console.WriteLine("invalid");
            }

            string result = age >= 10 ? "valid" : "invalid";
            Console.WriteLine(result);

            //Console.WriteLine(age >= 10 ? "valid" : "invalid");

            //Formatos
            double value = 10000D / 12.34D;

            Console.WriteLine(value);
            //Console.WriteLine(string.Format("{0} {1}",value,1000));
            Console.WriteLine(string.Format("{0:0}",value));
            Console.WriteLine(string.Format("{0:0.0}",value));
            Console.WriteLine(string.Format("{0:0.00}",value));


            double money = 10D / 3D;
            Console.WriteLine(money);
            //Console.WriteLine(string.Format("$10 / $3 = ${0:0.00}",money));
            Console.WriteLine(money.ToString("C"));
            Console.WriteLine(money.ToString("C0"));
            Console.WriteLine(money.ToString("C1"));

            //Console.WriteLine(money.ToString("C",CultureInfo.CurrentCulture));
            Console.WriteLine(money.ToString("C",CultureInfo.CreateSpecificCulture("en-GB")));
            Console.WriteLine(money.ToString("C",CultureInfo.CreateSpecificCulture("en-us")));
            Console.WriteLine(money.ToString("C",CultureInfo.CreateSpecificCulture("en-au")));

            */

            //proteccion de datos

            /*Console.WriteLine("Escribe un numero: ");
            string numInput = Console.ReadLine();
            //int num = Convert.ToInt32(numInput);
            int num = 0;

            bool success = int.TryParse(numInput, out num);

            if (success)
            {
                Console.WriteLine(num);
            }
            else
            {
                Console.WriteLine("Error al convertir");
            }
            bool success = true;

            while(success)
            {
                Console.WriteLine("Escribe un numero: ");
                string numInput = Console.ReadLine();

                if (int.TryParse(numInput, out int num))
                {
                    success = false;
                    Console.WriteLine(num);
                }
                else
                {
                    Console.WriteLine("Error al convertir");
                }
            }

            Console.WriteLine("Escribe un numero: ");
            int number = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= 10; i++) 
            {
                Console.WriteLine("{0} x {1} = {2}", i, number, i * number);
            }

            //Fizzbuzz practica
            for(int i = 1; i <= 15; i++)
            {
               if(i % 3 == 0 && i % 5 == 0) {
                    Console.WriteLine("FizzBuzz");
               }
               else if(i % 3 == 0)
               {
                   Console.WriteLine("Fizz");
               }else if(i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

            //Verbatim \t \n \ \\  \"
            string speech = "He said \"somenting\"" + "\n";
            Console.WriteLine(speech);

            string path = @"C:\\user\\documents\\c";
            Console.WriteLine(path);

            string name = @"hola ""adios""";
            Console.WriteLine(name);

            string name2 = "hola 'antuane'";
            Console.WriteLine(name2);

            //formateo compuesto
            string name = "antuane";
            int age = 23;

            Console.WriteLine("Nombre: " + name);
            Console.WriteLine("Edad: " + age);
            Console.WriteLine();

            Console.WriteLine("Nombre: " + name + "\nEdad: " + age);
            Console.WriteLine("Tu nombre es " + name + ", y tu edad es " + age);
            Console.WriteLine();
            Console.WriteLine("Nombre: {0}\nEdad: {1}",name,age);
            Console.WriteLine("Tu nombre es {0}, y tu edad es {1}",name,age);

            //interpolacion de strings

            string name = "antuane";
            int age = 23;

            Console.WriteLine($"Tu nombre es {name}, y tu edad es {age}");

            //concatenacion de strings
            string test = string.Concat("Tu nombre es ", name, " y tu edad es ", age);
            Console.WriteLine(test);

            string[] names = new string[]
            {
                " Antunae"," Test"," Luna"
            };
            Console.WriteLine(string.Concat(names));

            //strings vacias

            Console.WriteLine("Escribe tu nombre: ");
            string name2 = Console.ReadLine();

            if (name2 != string.Empty) {
                Console.WriteLine($"Tu nombre es {name2}");
            }
            else
            {
                Console.WriteLine("Nombre vacio");
            }

            //igualdad de strings
            string message = "hola";
            string compare = "hola";

            if(message.Equals(compare)) // message == compare
            {
                Console.WriteLine("iguales");
            }
            else
            {
                Console.WriteLine("diferentes");
            }

            Console.WriteLine("Escribe tu nombre: ");
            string nombre = Console.ReadLine();

            if(!nombre.Equals(""))
            {
                Console.WriteLine($"tu nombre es {nombre}");
            }
            else
            {
                Console.WriteLine("nombre invalido");
            }

            //string iteracion
            string message = "C# is awesome";
            //char[] = 
            //Console.WriteLine(message[1]);
            //Console.WriteLine(message[15]);

            for(int i = 0;i < message.Length;i++)
            {
                Console.Write(message[i]);
                Thread.Sleep(100);
            }
            Console.WriteLine();
            Console.WriteLine(message.Contains("C"));

            bool contains = false;
            for(int i = 0;i < message.Length; i++)
            {
                if (message[i] == 'C') 
                { 
                    contains = true; 
                    break;
                }
            }

            Console.WriteLine(contains);

            //string vacio o nulo
            Console.WriteLine("Escribe tu nombre: ");
            string name = Console.ReadLine();
            //string name = null; 

            Console.WriteLine($"Tu nombre es {name}");
            if (name != "")
            {
                Console.WriteLine("0");
            }

            //if (!name.Equals(""))
            //{
              //  Console.WriteLine("1");
            //}

            if (!string.IsNullOrEmpty(name))
            {
                Console.WriteLine("2");
            }

            //practica texto nomral y alreves
            Console.Write("Escribe el mensaje: ");
            string message = Console.ReadLine();

            for(int i = 0;i< message.Length;i++)
            {
                Console.Write(message[i]);
            }
            Console.WriteLine();
            for (int i = message.Length - 1;i >= 0 ;i--)
            {
                Console.Write(message[i]);
            }

            //Practica password checker

            Console.Write("Escribe la contraseña: ");
            string password = Console.ReadLine();            
            Console.Write("Escribe la contraseña otra vez: ");
            string passwordC = Console.ReadLine();

            if (!password.Equals(string.Empty))
            {
                if(!passwordC.Equals(string.Empty)) {
                    if(passwordC.Length >= 6 && password.Length >=6)
                    {
                        if (password.Equals(passwordC))
                        {
                            Console.WriteLine("Las contrasenias coinciden");
                        }
                        else
                        {
                            Console.WriteLine("Las contrasenias no coinciden.");
                        }
                    }else {
                            Console.WriteLine("Los tamanios de letra no son mayores a 6");
                        }
                }
                else
                {
                    Console.WriteLine("La contraseña es incorrecta");
                }
            }
            else 
            {
                Console.WriteLine("Escriba una contrasenia valida.");
            }*/

            //arreglos
            /*int num1 = 5;
            int num2 = 10;
            int num3 = 15;

            int[] numbers = new int[8];*/

            /*Console.Write("Ingresa un numero: ");
            numbers[0] = Convert.ToInt32(Console.ReadLine());            
            Console.Write("Ingresa un numero: ");
            numbers[1] = Convert.ToInt32(Console.ReadLine());            
            Console.Write("Ingresa un numero: ");
            numbers[2] = Convert.ToInt32(Console.ReadLine());
            
            Console.Write('\n');*/

            //Console.WriteLine($"{num1} {num2} {num3}");
            //Console.WriteLine($"{numbers[0]} {numbers[1]} {numbers[2]}");

            /*for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Ingresa un numero: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]} ");
            }
            Console.WriteLine();
            foreach (int num in numbers)
            {
                Console.Write($"{num}");
            }

            int[] angulos = new int[3];

            for (int i = 0; i < angulos.Length; i++)
            {
                Console.Write($"Escribe el Angulo{i + 1}: ");
                angulos[i] = Convert.ToInt32 (Console.ReadLine());
            }

            int angulosum = 0;
            foreach (int angulo in angulos)
            {
                angulosum += angulo;
            }

            Console.WriteLine();
            Console.WriteLine(angulosum == 180 ? "Triangulo Valido" : "Triangulo Invalido");

            //Ordenamiento de arreglos
            int[] numbers = new int[] {
                9, 2, 7, 4, 5, 6, 1, 0
            };

            string text = "";
            text.Replace(" ", "");

            Array.Sort(numbers);

            foreach (int number in numbers)
            {
                Console.Write($"{number} ");
            }

            //Array al reves    
            int[] numbers = new int[] {
                0, 2, 7, 4, 5, 6, 7, 9
            };

            Array.Reverse(numbers);
            foreach (int i in numbers)
            {
                Console.Write($"{i} ");
            }

            //limpieza de arrays resetea los valores a default
            int[] numbers = new int[] {
                0, 2, 7, 4, 5, 6, 7, 9
            };

            Array.Clear(numbers,4,3);

            foreach (int i in numbers)
            {
                Console.Write($"{i} ");
            }

            //index del array

            int[] numbers = new int[]
            {
                90,199,200,67,4
            };

            Console.Write("Escriba el numero a buscar: ");
            int search = Convert.ToInt32(Console.ReadLine());

            int position = Array.IndexOf(numbers, search);
            int position = Array.IndexOf(numbers, search, 2, 3); Posicion de inicio y fin de la busqueda en adelante

            if(position >= 0)
            {
                Console.WriteLine($"Numero buscado esta en la posicion {position + 1}");
            }
            else
            {
                Console.WriteLine("Numero buscado no se encontro");
            }

            //Listas <>
            int[] numbers = new int[3]{
                1,2,3
            };

            List<int> listNumbers = new List<int>()
            {
                1,2,3,4,5,6
            };

            listNumbers.Add(99);

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Escribe un numero: ");
                listNumbers.Add(Convert.ToInt32(Console.ReadLine()));
            }
            Console.WriteLine();
            for (int i = 0; i < listNumbers.Count; i++)
            {
                Console.Write(listNumbers[i] );
            }
            Console.WriteLine();
            foreach (var item in listNumbers)
            {
                Console.WriteLine(item);
            }

            listNumbers.RemoveAt(6);

            //diccionarios
            Dictionary<int, string> names = new Dictionary<int, string>()
            {
                //keyValuePair
                {4, "Pepe" },
                {5, "Luis" },
            };

            names.Add(1, "antuan");
            names.Add(2, "alex");
            names.Add(3, "juan");

            for (int i = 0; i < names.Count; i++)
            {
                KeyValuePair<int, string> pair = names.ElementAt(i);
                Console.WriteLine($"{pair.Key} - {pair.Value}");
            }
            Console.WriteLine();
            Dictionary<string, string> teachers = new Dictionary<string, string>()
            {
                {"mate","luis" },
                {"historia","pepe" },
            };

            //Console.WriteLine(teachers["historia"]);
            if(teachers.TryGetValue("Historia",out string teacher))
            {
                Console.WriteLine(teacher);
            }
            else
            {
                Console.WriteLine("No encontrado");
            }


            if (teachers.ContainsKey("historia"))
            {
                teachers.Remove("historia");
                for (int i = 0; i < teachers.Count; i++)
                {
                    KeyValuePair<string, string> pair = teachers.ElementAt(i);
                    Console.WriteLine($"{pair.Key} - {pair.Value}");
                }
            }
            else
            {
                Console.WriteLine("Materia no encontrada");
            }

            //practica pares e impares
            List<int> even = new List<int>();
            List<int> pair = new List<int>();

            for (int i = 0; i <= 20; i++)
            {
                if(i % 2 == 0)
                {
                    pair.Add(i);
                }else
                {
                    even.Add(i);
                }
            }

            foreach (int i in pair)
            {
                Console.WriteLine($"Numeros pares: {i}");
            }
            Console.WriteLine();
            foreach (int i in even)
            {
                Console.WriteLine($"Numeros impares: {i}");
            }

            //Arreglo de multiplos
            int numero = 7;
            int[] num = new int[5];

            for (int i = 1; i <= num.Length; i++)
            {
                num[i - 1] = numero * i;
            }

            for (int i = 1; i <= num.Length; i++)
            {
                Console.WriteLine($"El valor de {numero} * {i} es: {numero * i}");
            }*/

            //Funciones
            Hola();

            Console.ReadLine();
        }

        static void Hola()
        {
            Console.WriteLine("Hola Antuane");
        }
    }
}
