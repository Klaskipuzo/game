using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using System.Collections.Generic;

namespace MyProject2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите слово (Start)");
            Start();
            Select();
            Game();



            Console.WriteLine();
        }


        static string Start()
        {
            while (true)
            {

                string str1 = "Start";

                string starts = Console.ReadLine();


                if (starts.Contains(str1))
                {
                    Console.WriteLine("Добро пожаловать!");

                    Console.WriteLine("Вы попали в мою игру! Выберите своего героя");

                    return starts;

                }

                else
                {
                    Console.WriteLine("Ошибка");
                }




                Console.WriteLine();
            }

        }
        static bool Select()
        {
            Console.WriteLine("Вы готовы сделать свой выбор?");
            Console.WriteLine("1 - OrcWarrior \n2 - HumanWizard \n3 - ElfRogue");
            var selects = int.Parse(Console.ReadLine());

            if (selects == 1)
            {

                var h = 100;
                var health = h;
                OrcWarrior(h);
                Console.WriteLine($"Ваш выбор могучий орк воин, который имеет здоровья: {health}");
                return true;

            }
            else if (selects == 2)
            {

                var h = 20;
                var health = h;
                HumanWizard(h);
                Console.WriteLine($"Ваш выбор мудрый волшебник, который имеет здоровья: {health}");
                return true;
            }
            else if (selects == 3)
            {
                var h = 50;
                var health = h;
                ElfRogue(h);
                Console.WriteLine($"Ваш выбор могучий ловкий плут, который имеет здоровья: {health}");
                return true;
            }
            else
            {
                Console.WriteLine("Вы сделали неправильный выбор");

            }
            return true;

            Console.WriteLine();
        }
        public static int OrcWarrior(int h)
        {

            h = 100;
            return h;

            Console.WriteLine();
        }
        public static int HumanWizard(int h)
        {

            h = 20;
            return h;
            Console.WriteLine();
        }
        public static int ElfRogue(int h)
        {

            h = 50;
            return h;
            Console.WriteLine();
        }

        static void Game()
        {

            Console.WriteLine($"\nВы оказались в тёмной комнате, сквозь темноту видно дверь и рядом стоящий сундук.\nВаши дейтвия?");
            Console.WriteLine($"Выберите действия:\n1 - Открыть сундук\n2 - открыть дверь\n3 - Зажечь факел");
            var select = int.Parse(Console.ReadLine());
            if (select == 1)
            {
                Console.WriteLine("При попытке открыть сундук он взрывается и вы умираете");
            }
            else if (select == 2)
            {
                Console.WriteLine("При попытке открыть дверь вы не замечаете ловушку и сквозь отверстия в двери  вылетают ядовитые дротики и протыкают вас, вы медленно умираете");

            }
            else if (select == 3)
            {
                Console.WriteLine("Вы зажгли факел и увидели ловушку на двери и на сундуке. При хорошем освещении вы избавились от ловушек и открыли сундук");
                Chess();
            }

            Console.WriteLine();
        }



        static void Chess()
        {
            string[] waepon = new string[] { "Axe", "Knife", "Staff" };

            Console.WriteLine($"Вы открыли сундук и выдите слудующее (1){waepon[0]} (2){waepon[1]} (3){waepon[2]} Что вы выберите?");

            var take = int.Parse(Console.ReadLine());
            if (take == 1)
            {

                Console.WriteLine($"Вы выбрали ({waepon[0]})");

            }
            else if (take == 2)
            {

                Console.WriteLine($"Вы выбрали ({waepon[1]})");

            }
            else if (take == 3)
            {
                var Monster = 100;
                Console.WriteLine($"Вы выбрали ({waepon[2]})");

            }
            else
            {
                Console.WriteLine("error");
            }
            Console.WriteLine("Взяв свое первое оружие вы  вы слышите шум позади себя\nНА ВАС НАПАЛ МОНСТР, ЗАЩИЩАЙТЕСЬ! ");

            string takes = Convert.ToString(take);

            FightOrc();

            Console.WriteLine();

        }


        static void FightOrc()
        {
            Random random = new Random();
            var hits = random.Next(0, 100);
            var Monster = 100;
            var h = 100;
            OrcWarrior(h);
            Console.WriteLine($"Монстр бьет вас уроном в размере {hits} у вас остается {h - hits}");
            Console.WriteLine("На данный момент все");

        }



    }
}