using System.Diagnostics;

namespace Unit13Final
{
    class Program
    {
        static void Main(string[] args)
        {
            //запускаем счетчик
            var watch = Stopwatch.StartNew();
            
            List<string> list = new List<string>();
            list = File.ReadLines("C:/Users/Dzh/Desktop/Text1.txt").ToList();
            Console.WriteLine($"Вставка в  List<T> заняла: {watch.Elapsed.TotalMilliseconds}  мс");


            LinkedList<string> listLinked = new LinkedList<string>();
            listLinked.AddFirst(File.ReadAllText("C:/Users/Dzh/Desktop/Text1.txt"));
            Console.WriteLine($"Вставка в  LinkedList<T> заняла: {watch.Elapsed.TotalMilliseconds}  мс");

        }
    }
}