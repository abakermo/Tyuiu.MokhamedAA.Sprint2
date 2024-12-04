using Tyuiu.MokhamedAA.Sprint2.Task7.V5.Lib;
namespace Tyuiu.MokhamedAA.Sprint2.Task7.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            

            Console.WriteLine("Введите значение  Х: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение  Y: ");
            double y = Convert.ToDouble(Console.ReadLine());




            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            bool res = ds.CheckDotInShadedArea(x, y);

            if (res)
            {
                Console.WriteLine("Точка находится в заштрихованной области");
            }
            else
            {
                Console.WriteLine("Точка НЕ находится в заштрихованной области");
            }

            Console.ReadKey();
        }
    }
}
