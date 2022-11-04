using System;
/**/

namespace lab05
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("TASK 1");
            MyMatrix matrix1 = new MyMatrix(3, 3);
            Console.WriteLine("Print");
            matrix1.Show();
            Console.WriteLine();
            Console.WriteLine("Enter new lines and columns size: ");
            int first = Convert.ToUInt16(Console.ReadLine());
            int second = Convert.ToUInt16(Console.ReadLine());
            matrix1.ChangeSize(first, second);
            matrix1.Show();
            Console.WriteLine();
            Console.WriteLine("Print Partialy");
            matrix1.ShowPartialy(2, 2);

            Console.WriteLine("TASK 2");
            Console.WriteLine("List realization");
            MyList<int> test_list_1 = new(3);
            Console.WriteLine($"Elements: {test_list_1.Count}");
            Console.WriteLine($"Capacity: {test_list_1.Capacity}");
            test_list_1.Add(1);
            test_list_1.Add(2);
            test_list_1.Add(3);
            Console.WriteLine($"Elements: {test_list_1.Count}");
            Console.WriteLine($"Capacity: {test_list_1.Capacity}");
            test_list_1.Add(5);
            Console.WriteLine($"Elements: {test_list_1.Count}");
            Console.WriteLine($"Capacity: {test_list_1.Capacity}");
            foreach (int i in test_list_1)
            {
                Console.Write(i);
            }
            Console.WriteLine();
            MyList<int> test_list_2 = new(7, 8, 6, 2, 5);
            Console.WriteLine($"Elements: {test_list_2.Count}");
            Console.WriteLine($"Capacity: {test_list_2.Capacity}");
            for (int i = 0; i < test_list_2.Count; ++i)
            {
                Console.Write(test_list_2[i]);
            }
            Console.WriteLine();
            Console.WriteLine("TASK 3");
            Console.WriteLine("Dictionary realization");



            MyDictionary<int, int> test_dectionary = new();
            Console.WriteLine($"Capacity {test_dectionary.Capacity}");
            Console.WriteLine($"Size {test_dectionary.Count}");
            test_dectionary.Add(1, 5);
            Console.WriteLine($"Capacity {test_dectionary.Capacity}");
            Console.WriteLine($"Size {test_dectionary.Count}");
            foreach (var i in test_dectionary)
            {
                Console.WriteLine($"Key: {i.Key} Value: {i.Value}");
            }

            test_dectionary.Add(1, 8);
            test_dectionary.Add(2, 3);
            Console.WriteLine($"Capacity {test_dectionary.Capacity}");
            Console.WriteLine($"Size {test_dectionary.Count}");
            test_dectionary.Add(3, -15);
            test_dectionary.Add(4, 1);
            test_dectionary.Add(1, 10);
            test_dectionary.Add(6, 10);
            Console.WriteLine($"Capacity {test_dectionary.Capacity}");
            Console.WriteLine($"Size {test_dectionary.Count}");
            foreach (var i in test_dectionary)
            {
                Console.WriteLine($"Key: {i.Key} Value: {i.Value}");
            }

        }
    }
}

