using System.Linq;
namespace Unit13final
{
    class Program
    {
        static void Main(string[] args)
        {
            //читаем текс
            string text = File.ReadAllText("C:/Users/Dzh/Desktop/Text1.txt");
            //удаляем знаки пункуации
            var noPunctuationText = new string(text.Where(c => !char.IsPunctuation(c)).ToArray());
            //заносим текст в список удаляя пустые строки (RemoveEmptyEntries)
            List<string> Text1 = text.ToLower().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            //группипуем
            var query = Text1.GroupBy(x => x)
              .Where(g => g.Count() > 1400)
              .Select(y => new { Слово = y.Key, Колличество = y.Count() })
              .ToList();
            //выводим результат
            foreach (var itog in query)
            {
                Console.WriteLine(itog);
            }
        }
    }
}