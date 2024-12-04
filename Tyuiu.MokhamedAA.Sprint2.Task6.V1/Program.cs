using Tyuiu.MokhamedAA.Sprint2.Task6.V1.Lib;
namespace Tyuiu.MokhamedAA.Sprint2.Task6.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите номер месяца:");
            int values = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.FindMonthDaysCount(values));
            Console.ReadKey();
        }
    }
}
