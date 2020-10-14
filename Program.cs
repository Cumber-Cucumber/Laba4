using System;

namespace Laba4
{
    class Program
    {
        static void Main(string[] args)
        {
            Array<IComparable>.Output_Autor();

            Array<int> arr1 = new Array<int>();

            arr1.Add(2);
            arr1.Add(4);
            arr1.Add(6);
            arr1.Add(11);
            arr1.Add(13);
            arr1.Add(15);
            arr1.Add(2);

            arr1.Remove(2);

            arr1.Output();

            StatisticOperation.Out_Count(arr1);

            Array<int> arr2 = new Array<int>();

            arr2.Add(2);
            arr2.Add(4);
            arr2.Add(6);
            arr2.Add(11);
            arr2.Add(13);
            arr2.Add(15);
            arr2.Add(2);

            arr2.Remove(2);

            arr2.Output();

            StatisticOperation.Out_Count(arr2);

            Console.WriteLine("Разница между макс и мин элементами 2 массива: " + StatisticOperation.Dif_MaxMin(arr2) + "\n");

            string str = "osuoi1oioilioai1oiaeenoia aavuiu1uiukaateaa0oiuiouroi ";
            Console.WriteLine("Было: " + str + "\n" + "Стало: " + StatisticOperation.Del_Gl(str) + "\n");
            str = StatisticOperation.Del_Gl(str);
            Console.WriteLine("Было: " + str + "\n" + "Стало: " + StatisticOperation.Del_FF(str) + "\n");


            Console.WriteLine("sadfasf " + Convert.ToString(arr1!=arr2));
        }
    }
}
