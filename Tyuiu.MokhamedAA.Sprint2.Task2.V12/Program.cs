using Tyuiu.MokhamedAA.Sprint2.Task2.V12.Lib;
namespace Tyuiu.MokhamedAA.Sprint2.Task2.V12
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("***********************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                *");
        Console.WriteLine("***********************************************************************************");

        Console.WriteLine(" Введите значение Х = ");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(" Введите значение Y = ");
        int y = Convert.ToInt32(Console.ReadLine());

        DataService ds = new DataService();
        bool res = ds.CheckDotInShadedArea(x, y);

   
        Console.WriteLine("***********************************************************************************");
        Console.WriteLine("*РЕЗУЛЬТАТ:                                                                       *");
        Console.WriteLine("***********************************************************************************");

        if (res)
        {
            Console.WriteLine(" Точка находится в заштрихованной области");
        }
        else
        {
            Console.WriteLine(" Точка не находится в заштрихованной области");
        }

        Console.ReadKey();

    }
}
