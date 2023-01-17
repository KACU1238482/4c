using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotOfTasks
{
    class Exercise
    {
        #region Podstawy Programowania
        public void Exercise1()
        {
            Console.WriteLine("Podaj pierwszą liczbę: \n");
            float FirstNumber = float.Parse(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę: \n");
            float SecondNumber = float.Parse(Console.ReadLine());

            Console.WriteLine("Średnia arytmetyczna podanych liczb wynosi: " + (FirstNumber + SecondNumber) / 2);
        }

        public void Exercise2()
        {
            Console.WriteLine("Podaj bok A:");
            float SideA = float.Parse(Console.ReadLine());
            Console.WriteLine("Podaj bok B:");
            float SideB = float.Parse(Console.ReadLine());

            Console.WriteLine("Pole prostokąta wynosi:" + SideA * SideB);
        }

        public void Exercise3()
        {
            Console.WriteLine("Podaj promień");
            float Radius = float.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wysokość");
            float Height = float.Parse(Console.ReadLine());

            Console.WriteLine("Objętość stożka wynosi:" + Math.PI / 3 * Radius * Radius * Height);
        }

        public void Exercise4()
        {
            Console.WriteLine("Podaj promień");
            float Radius = float.Parse(Console.ReadLine());

            Console.WriteLine("Objetość koła wynosi: " + Math.PI * Math.Pow(Radius, 2));
        }
        
        public void Exercise5()
        {
            Console.WriteLine("Podaj wartość a");
            float A = float.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wartość b");
            float B = float.Parse(Console.ReadLine());

            Console.WriteLine("Wartość wynosi " + (Math.Pow(A, 2) + Math.Pow(B, 2)));
        }

        public void Exercise6()
        {
            Console.WriteLine("Podaj długość b");
            float B = float.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wysokość h");
            float H = float.Parse(Console.ReadLine());

            Console.WriteLine("Pole trójkąta wynosi: " + (B * H) / 2);
        }

        public void Exercise7()
        {
            Console.WriteLine("Podaj wartość r");
            float R = float.Parse(Console.ReadLine());

            Console.WriteLine("Objętość kuli wynosi: " + (1,33 + Math.PI * Math.Pow(R, 3)));
        }

        public void Exercise8()
        {
            Console.WriteLine("Podaj wartość a");
            float A = float.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wartość b");
            float B = float.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wartość h");
            float H = float.Parse(Console.ReadLine());

            Console.WriteLine("Pole trapezu wynosi: " + ((A + B) * H) / 2 );
        }

        public void Exercise9()
        {
            Console.WriteLine("Podaj ocene wagi 1");
            float W1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Podaj ocene wagi 2");
            float W2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Podaj ocene wagi 3");
            float W3 = float.Parse(Console.ReadLine());

            Console.WriteLine("Średnia ważona wynosi: " + (((W1 * 1) + (W2 * 2) + (W3 * 3)) / (1 + 2 + 3)));
        }
        #endregion

        #region InstrukcjaIf 
        public void Exercise10()
        {
            Console.WriteLine("Podaj liczbę: ");
            int Number = int.Parse(Console.ReadLine());
            if (Number > 0)
            {
                if (Number % 2 == 0)
                    Console.WriteLine("Liczba jest parzysta");
                else if (Number % 2 != 0)
                    Console.WriteLine("Liczba nie jest parzysta");
            }
            else
            {
                Console.WriteLine("Podana liczba nie może być ujemna");
            }
        }

        public void Exercise11()
        {
            Console.WriteLine("Podaj liczbę: ");
            int Number = int.Parse(Console.ReadLine());
            if (Number > 0)
            {
                Console.WriteLine("Liczba jest dodatnia");
            }
            else if (Number < 0)
            {
                Console.WriteLine("Liczba jest ujemna");
            }
            else if (Number == 0)
            {
                Console.WriteLine("Podana Liczba jest równa 0");
            }
        }

        public void Exercise12()
        {
            Console.WriteLine("Podaj rok: ");
            int Year = int.Parse(Console.ReadLine());
            if ((Year % 4 == 0 && Year % 100 != 0) || Year % 400 == 0)
            {
                Console.WriteLine("Podany rok jest przestępny");
            }
            else
                Console.WriteLine("Podany rok nie jest przestępny");
        }

        public void Exercise13()
        {
            Console.WriteLine("Podaj ocene: ");
            int Grade = int.Parse(Console.ReadLine());
            if (Grade >= 1 && Grade <= 6)
            {
                if (Grade == 1)
                    Console.WriteLine("Ocena niedostateczna");
                else if (Grade == 2)
                    Console.WriteLine("Ocena dopuszczająca");
                else if (Grade == 3)
                    Console.WriteLine("Ocena dostateczna");
                else if (Grade == 4)
                    Console.WriteLine("Ocena dobra");
                else if (Grade == 5)
                    Console.WriteLine("Ocena bardzo dobra");
                else if (Grade == 6)
                    Console.WriteLine("Ocena celująca");
            }
            else
            {
                Console.WriteLine("Podaj ocene z zakresu 1-6");
            }
        }

        public void Exercise14()
        {
            string Password = "abc123";
            Console.WriteLine("Podaj hasło");
            string PasswordFromUser = Console.ReadLine();
            if (PasswordFromUser == Password)
            {
                Console.WriteLine("Prawidłowe hasło");
            }
            else
                Console.WriteLine("Nieprawidłowe hasło");
        }

        public void Exercise15()
        {

        }

        public void Exercise16()
        {
            Console.WriteLine("Podaj temperature");
            int Temperature = int.Parse(Console.ReadLine());
            if (Temperature >= 20)
            {
                Console.WriteLine("Jest ciepło");
            }
            else if (Temperature <= 20 && Temperature >= 10)
            {
                Console.WriteLine("Jest chłodno");
            }
            else
                Console.WriteLine("Jest zimno");
        }
        #endregion
    }
}

