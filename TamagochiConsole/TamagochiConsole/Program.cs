using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace TamagochiConsole
{

    internal class Program
    {
        //static Cat cat;
        static Random rand = new Random();

        static void LineLeave(int count)
        {
            for (int i = 0; i < count; i++)
                Console.WriteLine();
        }


        static void drawConsole(Cat cat, bool overeat = false, int n = -1)
        {
            //int left, top;
            string mess;

            Console.Clear();

            Console.SetCursorPosition(55, 1);   //установка курсора
            Console.WriteLine(cat.name);        //пишем имя кота

            Console.SetCursorPosition(80, 10);  //установка курсора
            Console.WriteLine("Еда: "+ cat.eat); //вывод количества еды

            //+-+-+-+-+-+-+-+-+ПЕРЕЕЛ+-+-+-+-+-+-+-+-+
            if (overeat)
            {
                Console.SetCursorPosition(0, 3);
                Assets.spew();
                Console.SetCursorPosition(75, 13);
                if (cat.sex)
                    Console.WriteLine($"{cat.name} сильно переела и выблевала большую часть еды.");
                else
                    Console.WriteLine($"{cat.name} сильно переел и выблевал большую часть еды.");
                return;
            }



            Console.SetCursorPosition(0,3);

            mess = Assets.arrDraw[rand.Next(0, 3)].Invoke();   //вывод картинки кота

            LineLeave(3);                               //отступы

            Console.SetCursorPosition(75, 13);   //установка курсора по игрику

            Console.WriteLine(cat.name + " "+ mess);

        }


        static void Main(string[] args)
        {
            Console.SetWindowSize(150, 40);

            Cat cat = new Cat(true); //создаём кота, выводим всю хуйню и осматриваемся

            //Thread.Sleep(5000); //спать

            Stopwatch st = new Stopwatch();
            bool overeat = false;

            st.Start();


            //bool f = false;


            while (true)
            {


                ////+-+-+-+-+-+-+-+-+-+-+-+-+ПАУЗА+-+-+-+-+-+-+-+-+-+-+-+-+-+ ХУЙ С НЕЙ ПОКА ЧТО
                //Task.Factory.StartNew(() =>
                //{
                //    while (Console.ReadKey().Key != ConsoleKey.Escape) ;
                //    if (f == false)
                //    {
                //        st.Stop();
                //        f = true;
                //        Console.WriteLine("Пауза нажата.");
                //    }
                //    else
                //    {
                //        f = false;
                //        Console.WriteLine("Игра продолжена.");
                //        st.Start();
                //    }
                //});


                if (st.ElapsedMilliseconds >= 5000)
                {
                    cat.setEat(-5);
                    if (cat.isDead)
                    {
                        st.Stop();
                        cat.catDead();
                        Console.Read();
                        return;
                    }
                    drawConsole(cat);
                    st.Restart();
                }

                Task.Factory.StartNew(() =>
                {
                    while (Console.ReadKey().Key != ConsoleKey.Q) ;
                    overeat = cat.setEat(10);
                    drawConsole(cat, overeat);
                    st.Stop();
                    Thread.Sleep(5000); //задержка чтобы прочитать
                    st.Start();
                });



            }


        }


    }
}
