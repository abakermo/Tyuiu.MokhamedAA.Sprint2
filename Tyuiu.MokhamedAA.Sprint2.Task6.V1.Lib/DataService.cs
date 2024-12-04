using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.MokhamedAA.Sprint2.Task6.V1.Lib
{
    public class DataService : ISprint2Task6V1
    {

        public int FindMonthDaysCount(int value)
        {
            int month = 0;
            switch (value)
            {
                case 2:
                    month = 29;
                    break;
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    month = 31;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    month = 30;
                    break;
            }
            return month;
        }
    }
}