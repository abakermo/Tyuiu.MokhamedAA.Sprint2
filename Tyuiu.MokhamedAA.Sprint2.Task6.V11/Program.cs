using Tyuiu.MokhamedAA.Sprint2.Task6.V11.Lib;
namespace Tyuiu.MokhamedAA.Sprint2.Task6.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int g, m, n;
            DataService ds = new DataService();
            
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                               *");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* Введите G:                                                                     *");
            g = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("* Введите M:                                                                     *");
            m = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("* Введите N:                                                                     *");
            n = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                     *");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine(ds.FindDateOfNextDay(g, m, n));

            Console.ReadLine();
        }
    }
}
