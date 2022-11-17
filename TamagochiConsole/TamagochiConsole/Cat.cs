using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace TamagochiConsole
{
    public class Cat
    {

        public int eat { get; set; } = 100;
        public string name { get; set; } = "Кисуня";
        public int mood { get; set; } = 100;
        public bool sex { get; set; } //false - cat   true - кошка
        public bool isDead { get; set; } = false;


        public Cat(){
            this.eat = 100;
            this.sex = true;
        }

        public Cat(string name, bool sex)
        {
            this.eat = 100;
            this.name = name;
            this.sex = sex;
        }


        public Cat(bool f) //ПОЛНЫЙ КАЛ БЛЯТЬ мне просто лень было делать нормально, хз, может когда-нибудь переделаю.
        {
            Console.Clear();
            Console.SetCursorPosition(0, 3);
            Assets.born();

            Console.SetCursorPosition(75, 5);
            Console.WriteLine("Вы впервые берёте свою кроху на ручки.");

            Console.SetCursorPosition(70, 8);
            Console.Write("Выберите пол котика."); //просим ввести пол котика
            while (true)
            {
                Console.SetCursorPosition(70, 10);
                Console.Write("1 - женский\t0 - мужской");
                Console.SetCursorPosition(70, 12);
                string sexx = Console.ReadLine();

                Console.SetCursorPosition(70, 10); //затираем строку женский/мужской, остальное затирается потом
                Console.Write("                             ");

                //стираем строку введённую пользователем
                Console.SetCursorPosition(70, 12);
                Console.WriteLine(space(sexx));
                if (sexx.Equals("0"))
                {
                    this.sex = false;
                    break;
                }
                else if (sexx.Equals("1"))
                {
                    this.sex = true;
                    break;
                }
                else
                {
                    Console.SetCursorPosition(70, 8);
                    Console.WriteLine("Ты в глаза долбишься? Вводи ещё раз: ");
                }
            }
            Console.SetCursorPosition(70, 8);
            Console.WriteLine("Введите имя котика                        ");

            Console.SetCursorPosition(70, 10);
            this.name = Console.ReadLine(); //читает имя
            Console.SetCursorPosition(70, 10);
            Console.Write(space(name)); //затирает имя

            Console.SetCursorPosition(70, 8);
            Console.Write($"Прекрасно, вашу кисуню теперь зовут {this.name}");

            //осматривается
            Thread.Sleep(5000);
            Console.Clear();
            Console.SetCursorPosition(0, 3);
            Assets.lookAround();
            Console.SetCursorPosition(75, 5);
            Console.WriteLine($"{name} осторожно осматривается");
        }

        public bool setEat(int dam)
        {
            eat += dam;
            if (eat < 0)
            {
                Console.WriteLine("Кошка сдохла...(");
                isDead = true;
            }
            if (eat > 110)
            {
                eat = 30;
                return true;
            }
            return false;
        }



        public void catDead()
        {
            Console.Clear();
            Console.SetCursorPosition(0, 3);
            Assets.dead();
            Console.SetCursorPosition(75, 13);
            if (sex)
                Console.WriteLine($"К сожалению {name} умерла от голода. Это конец...");
            else
                Console.WriteLine($"К сожалению {name} умер от голода. Это конец...");
            Console.SetCursorPosition(0, 20);
        }

        private string space(string x)
        {
            string newStr = "";
            foreach (char c in x)
                newStr += " ";
            return newStr;
        }

    }
}
