using Tyuiu.MokhamedAA.Sprint2.Task3.V20.Lib;
namespace Tyuiu.MokhamedAA.Sprint2.Task3.V20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();



            
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите x: ");
            double x = Convert.ToDouble(Console.ReadLine());



            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.Calculate(x));
            Console.ReadKey();

        }
    }
}


