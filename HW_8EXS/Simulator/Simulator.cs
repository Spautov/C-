using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Airport;

namespace TrainingFlight
{
    public class Simulator
    {
        private Plane _Boing747;

        public Simulator()
        {
            _Boing747 = Plane.GetPlane();
        }

        public void ToFly()
        {
            ShowMenu();
            ConsoleKeyInfo keyInfo;
            while (true)
            {
                try
                {
                    keyInfo = GetKey();
                    Console.WriteLine();
                    Selected(keyInfo);
                }
                catch (СollapseException e)
                {
                    Console.WriteLine(e.Message);
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        private void ShowMenu()
        {
            Console.WriteLine("Добавить диспетчера: Shift+a");
            Console.WriteLine("Удалить диспетчера: Shift+r");
            Console.WriteLine("Взлететь: Shift+u");
            Console.WriteLine("Посадить самолет: Shift+d");
            Console.WriteLine("Набрать высоту на 250 м: Up");
            Console.WriteLine("Снизить высоту на 250 м: Down");
            Console.WriteLine("Набрать высоту на 500 м: Shift+Up");
            Console.WriteLine("Снизить высоту на 500 м: Shift+Down");
            Console.WriteLine("Увеличить скорость на 50 км//ч: Right");
            Console.WriteLine("Уменьшить скорость на 50 км//ч: Left");
            Console.WriteLine("Увеличить скорость на 150 км//ч: Shift+Right");
            Console.WriteLine("Уменьшить скорость на 150 км//ч: Shift+Left");
            Console.WriteLine("Выход из программы: Alt+F4");
        }

        private ConsoleKeyInfo GetKey()
        {
            Console.WriteLine("Введите желаемую команду:");
            return Console.ReadKey();
        }

        private void Selected(ConsoleKeyInfo KeyInfo)
        {
            if (KeyInfo.Modifiers == ConsoleModifiers.Alt && KeyInfo.Key == ConsoleKey.F4)
            {
                Environment.Exit(0);
            }

            if ((KeyInfo.Modifiers & ConsoleModifiers.Shift) != 0)
            {
                switch (KeyInfo.Key)
                {
                    case ConsoleKey.LeftArrow:
                    case ConsoleKey.UpArrow:
                    case ConsoleKey.RightArrow:
                    case ConsoleKey.DownArrow:
                        _Boing747.ChangeDataFly(KeyInfo);
                        break;
                    case ConsoleKey.A:
                        AddDisp();
                        break;
                    case ConsoleKey.D:
                        _Boing747.Landing();
                        break;
                    case ConsoleKey.R:
                        RemoveDisp();
                        break;
                    case ConsoleKey.U:
                        _Boing747.Fly();
                        break;
                }
            }
            else
            {
                switch (KeyInfo.Key)
                {
                    case ConsoleKey.LeftArrow:
                    case ConsoleKey.UpArrow:
                    case ConsoleKey.RightArrow:
                    case ConsoleKey.DownArrow:
                        _Boing747.ChangeDataFly(KeyInfo);
                        break;
                }
            }
        }

        private void AddDisp()
        {
            Console.Write("Введите имя диспетчера: ");
            string name = Console.ReadLine();
            _Boing747.AddDispatcher(name);
        }

        private void RemoveDisp()
        {
            Console.Write("Введите имя диспетчера: ");
            string name = Console.ReadLine();
            _Boing747.RemoveDispatcher(name);
        }


    }
}
