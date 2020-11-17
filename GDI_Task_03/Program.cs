using System;

namespace GDI_Task_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int mistakes = 0;
            string pass = "Пушкин А.С.";
            string EnterPass;
            bool res = true;

            Console.WriteLine("Введите пароль:");
            Console.WriteLine("+ - подсказка");

            do
            {
                Console.WriteLine($"> Попыток {3 - mistakes}");
                EnterPass = Convert.ToString(Console.ReadLine());
                if (EnterPass == "+")
                {
                    Console.WriteLine("Фамилия и иницифлы автора поэмы 'Руслан и Людмила'");
                }else if(pass == EnterPass)
                {
                    res = false;
                }else
                {
                    mistakes++;
                    if(mistakes == 3)
                    {
                        Console.WriteLine("Вы привысили лимит попыток. Повторите попытку позже. Нажмите Enter для продолжения.");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }
                }

            } while (res);

            Console.WriteLine("Вход выполнен успешно. Нажмите Enter для получения секретного сообщения.");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Сущность в виде бобрика");
            Console.WriteLine("________________¶¶¶¶¶¶¶¶¶_________________");
            Console.WriteLine("_______________¶¶¶¶¶¶¶¶¶¶¶________________");
            Console.WriteLine("______________¶¶¶¶¶¶¶¶¶¶¶¶¶_______________");
            Console.WriteLine("_____________¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶______________");
            Console.WriteLine("___________¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶_____________");
            Console.WriteLine("_________¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶___________");
            Console.WriteLine("________¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶__________");
            Console.WriteLine("_______¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶_________");
            Console.WriteLine("___¶¶¶¶¶__________________________¶¶¶¶¶___");
            Console.WriteLine("_¶¶¶¶¶¶¶¶¶______________________¶¶¶¶¶¶¶¶__");
            Console.WriteLine("_¶¶_____¶¶______________________¶¶____¶¶¶_");
            Console.WriteLine("¶¶__¶¶¶¶__________________________¶¶¶¶_¶¶_");
            Console.WriteLine("¶¶_¶¶¶_____________________________¶¶¶_¶¶_");
            Console.WriteLine("¶¶_¶¶_______________________________¶¶_¶¶_");
            Console.WriteLine("_¶¶____________________________________¶¶_");
            Console.WriteLine("_¶¶__________¶¶¶_________¶¶¶__________¶¶__");
            Console.WriteLine("___________¶¶¶¶¶¶¶_____¶¶¶¶¶¶¶¶___________");
            Console.WriteLine("_________¶¶¶¶¶¶¶¶¶¶____¶¶¶¶¶¶¶¶¶__________");
            Console.WriteLine("________¶¶¶¶____¶¶¶____¶¶¶___¶¶¶¶_________");
            Console.WriteLine("________¶¶¶¶_¶¶¶_¶¶____¶¶_¶¶¶_¶¶¶¶________");
            Console.WriteLine("________¶¶¶_¶¶¶¶_¶¶____¶¶_¶¶¶¶_¶¶¶________");
            Console.WriteLine("_______¶¶¶¶¶_¶¶¶_¶¶____¶¶_¶¶¶_¶¶¶¶¶_______");
            Console.WriteLine("_______¶¶¶¶¶¶___¶¶_____¶¶¶___¶¶¶¶¶¶_______");
            Console.WriteLine("_______¶¶¶¶¶¶¶¶¶¶¶______¶¶¶¶¶¶¶¶¶¶¶_______");
            Console.WriteLine("______¶¶¶¶¶¶¶¶¶¶¶__¶¶¶¶__¶¶¶¶¶¶¶¶¶¶¶______");
            Console.WriteLine("______¶¶¶¶¶¶¶¶¶¶_¶¶¶¶¶¶¶__¶¶¶¶¶¶¶¶¶¶______");
            Console.WriteLine("______¶¶¶¶¶¶¶¶¶__¶¶¶¶¶¶¶___¶¶¶¶¶¶¶¶¶______");
            Console.WriteLine("_____¶¶¶¶¶¶¶¶_____¶¶¶¶¶¶_____¶¶¶¶¶¶¶¶_____");
            Console.WriteLine("______¶¶¶¶_________¶¶¶¶_________¶¶¶¶______");
            Console.WriteLine("____________________¶¶____________________");
            Console.WriteLine("____________________¶¶____________________");
            Console.WriteLine("____________¶¶______¶¶______¶¶____________");
            Console.WriteLine("____________¶¶¶_____¶¶____¶¶¶_____________");
            Console.WriteLine("______________¶¶¶___¶¶__¶¶¶¶______________");
            Console.WriteLine("________________¶¶¶¶¶¶¶¶¶¶________________");
            Console.WriteLine("_________________¶__¶___¶_________________");
            Console.WriteLine("_________________¶__¶___¶_________________");
            Console.WriteLine("_________________¶__¶___¶_________________");
            Console.WriteLine("_________________¶__¶___¶_________________");
            Console.WriteLine("_________________¶¶¶¶¶¶¶¶_________________");


        }
    }
}
