using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            Console.WriteLine("Словарь содержит {0} элементов", dictionary.Count);
            dictionary["Abs"] = 15;
            Console.WriteLine("Словарь содержит {0} элементов", dictionary.Count);
            Console.WriteLine("Значение ключа {0} равно {1}", "Abs", dictionary["Abs"]);
            dictionary.Add("Abc", 19);
            Console.WriteLine("Словарь содержит {0} элементов", dictionary.Count);
            Console.WriteLine("Значение ключа {0} равно {1}", "Abc", dictionary["Abc"]);
            Console.WriteLine("Словарь содержит ключ {0} - {1}", "Abs", dictionary.ContainsKey("Abs"));
            Console.WriteLine("Словарь содержит ключ {0} - {1}", "Abs1", dictionary.ContainsKey("Abs1"));
            Console.WriteLine("Словарь содержит значение {0} - {1}", 19, dictionary.ContainsValue(19));
            Console.WriteLine("Словарь содержит значение {0} - {1}", 28, dictionary.ContainsValue(28));
            if(dictionary.Remove("Abs"))
            {
                Console.WriteLine("Пара ключ-значение с ключем {0} удалена", "Abs");
            }
            else
            {
                Console.WriteLine("Соответсвие ключу {0} не найдено", "Abs");
            }
            if (dictionary.Remove("Abs1"))
            {
                Console.WriteLine("Пара ключ-значение с ключем {0} удалена", "Abs1");
            }
            else
            {
                Console.WriteLine("Соответсвие ключу {0} не найдено", "Abs1");
            }
            int newValue;
            if (dictionary.TryGetValue("Abc", out newValue))
            {
                Console.WriteLine("Значение ключа {0} равно {1}", "Abc", newValue);
            }
            else
            {
                Console.WriteLine("Ключ {0} отсутствует, значение по умолчанию равно {1}", "Abc", newValue);
            }
            if (dictionary.TryGetValue("Abs", out newValue))
            {
                Console.WriteLine("Значение ключа {0} равно {1}", "Abs", newValue);
            }
            else
            {
                Console.WriteLine("Ключ {0} отсутствует, значение по умолчанию равно {1}", "Abs", newValue);
            }
            dictionary.Clear();
            Console.WriteLine("Словарь содержит {0} элементов", dictionary.Count);
            if (dictionary.TryGetValue("Abc", out newValue))
            {
                Console.WriteLine("Значение ключа {0} равно {1}", "Abc", newValue);
            }
            else
            {
                Console.WriteLine("Ключ {0} отсутствует, значение по умолчанию равно {1}", "Abc", newValue);
            }
        }
    }
}
