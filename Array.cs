using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Laba4
{
    public class Array<Type> where Type : IComparable
    {
        public class Owner_Class
        {
            public int ID;
            public string name;
            public string organisation;
            public Owner_Class(int ID, string name, string organisation)
            {
                this.ID = ID;
                this.name = name;
                this.organisation = organisation;
            }
            public static Owner_Class owner = new Owner_Class(1, "Cumber Cucumber", "Annaly Internetov");
        }

        public class Date
        {
            public static string date = "12.10.2020";
        }

        public static void Output_Autor()
        {
            Console.WriteLine("Работу выполнил: №" + Convert.ToString(Owner_Class.owner.ID) + " " + Owner_Class.owner.name + " from " + Owner_Class.owner.organisation);
            Console.WriteLine("Дата выполнения: " + Date.date);
            Console.WriteLine("--------------------------------------------------------------------------------------------------------\n");
        }



        private List<Type> arr = new List<Type>();

        protected uint count = 0;
        public uint Count { get { return count; } protected set { count = value; } }

        public void Add(Type num) // Добавление элемента
        {
            arr.Add(num);
            Count++;
        }

        public void Remove(Type num) // Удаление элемента
        {
            arr.Remove(num);
            Count--;
        }
        public void Output() // Вывод массива

        {
            Console.WriteLine("Массив содержит: ");
            foreach (Type el in arr)
            {
                Console.Write(el + " ");
            }
            Console.WriteLine();
        }
        public IEnumerator<Type> GetEnumerator()
        {
            return arr.GetEnumerator();
        }

        public static Array<Type> operator -(Array<Type> array, Type num) // arr2 = arr2 - 4
        {
            array.Remove(num);
            return array;
        }

        public static bool operator >(Array<Type> array, Type num) // if(arr1 > 2) { } (true)
        {
            foreach (Type el in array)
            {
                if (el.CompareTo(num) == 0)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator <(Array<Type> array, Type num)
        {
            return true;
        }

        public static bool operator !=(Array<Type> array1, Array<Type> array2) // 
        {
            int v = 0;
            int n = 0;
            if (array1.Count != array2.Count)
                return true;
            foreach (Type el1 in array1)
            {
                foreach (Type el2 in array2)
                {
                    if (v == n)
                    {
                        if (el1.CompareTo(el2) == 0)
                        {
                            break;
                        }
                        else
                            return true;
                    }
                    n++;
                }
                v++;
            }
            return false;
        }
        public static bool operator ==(Array<Type> array1, Array<Type> array2) // if(arr1 > 2) { } (true)
        {
            return true;
        }

    }

    public static class StatisticOperation
    {
        public static void Out_Count(Array<int> array) // Количество элементов
        {
            Console.WriteLine("Количество элементов массива: " + array.Count + "\n");
        }

        public static int Sum_El(Array<int> array) // Сумма элементов
        {
            int sum = 0;
            foreach (int el in array)
            {
                sum += el;
            }
            return sum;
        }

        public static int Dif_MaxMin(Array<int> array) // Разница между максимальным и минимальным элементом
        {
            int max_el = -100000;
            int min_el = 100000;
            foreach (int el in array)
            {
                if (el > max_el)
                {
                    max_el = el;
                }
                if (el < min_el)
                {
                    min_el = el;
                }
            }
            return max_el - min_el;
        }

        public static string Del_Gl(this string str) // Метод расширения
        {
            string result_str = str.Replace("a", "");
            result_str = result_str.Replace("e", "");
            result_str = result_str.Replace("u", "");
            result_str = result_str.Replace("i", "");
            result_str = result_str.Replace("o", "");
            result_str = result_str.Replace("A", "");
            result_str = result_str.Replace("E", "");
            result_str = result_str.Replace("U", "");
            result_str = result_str.Replace("I", "");
            result_str = result_str.Replace("O", "");
            return result_str;
        }

        public static string Del_FF(this string str) // Метод расширения
        {
            str = str.Remove(0, 5);
            return str;
        }

    }
}
