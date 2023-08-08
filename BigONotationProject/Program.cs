using System;

namespace BigOLabs
{
    class Algorithms
    {
       
        //True if the value is even, False if it's odd.
        // Big O: O(1) - Constant
       
        static bool IsEven(int value)
        {
            return value % 2 == 0;
        }

        //Checks if all numbers in the list are lower than 100.
        //True if all numbers are less than 100, False otherwise     
        //Big O: O(n) - Iterates through each number in the list once
        static bool AreAllNumbersLessThan100(List<int> numbers)
        {
            foreach (int num in numbers)
            {
                if (num >= 100)
                {
                    return false;
                }
            }
            return true;
        }

        //True if there are any repeated names, False otherwise.
        //Big O: O(n) - Iterates through the list once to build the dictionary.

        static bool ContainsDuplicates(List<string> names)
        {
            HashSet<string> nameSet = new HashSet<string>();

            foreach (string name in names)
            {
                if (!nameSet.Add(name))
                {
                    return true;
                }
            }
            return false;
        }

        //Manually sorts a list of numbers into ascending order.
        //Big O: O(n^2) 

        static void ManualSort(List<int> numbers)
        {
            int n = numbers.Count;
            bool swapped;

            do
            {
                swapped = false;
                for (int i = 1; i < n; i++)
                {
                    if (numbers[i - 1] > numbers[i])
                    {
                        int temp = numbers[i - 1];
                        numbers[i - 1] = numbers[i];
                        numbers[i] = temp;
                        swapped = true;
                    }
                }
                n--;
            } while (swapped);
        }


        static void Main(string[] args)
        {
            Console.Write("Enter a value: ");
            int inputValue = int.Parse(Console.ReadLine());

            bool isEven = IsEven(inputValue);

            if (isEven)
            {
                Console.WriteLine($"{inputValue} is even.");
            }
            else
            {
                Console.WriteLine($"{inputValue} is odd.");
            }

            List<int> numberList = new List<int> { 45, 83, 92, 72, 58 };

            bool allLessThan100 = AreAllNumbersLessThan100(numberList);

            if (allLessThan100)
            {
                Console.WriteLine("All numbers are less than 100.");
            }
            else
            {
                Console.WriteLine("Some numbers are greater than or equal to 100.");
            }

            List<string> nameList = new List<string> { "Brian", "India", "Brian", "Aiden", "Christian" };

            bool hasDuplicates = ContainsDuplicates(nameList);

            if (hasDuplicates)
            {
                Console.WriteLine("There is a name that is repeated.");
            }
            else
            {
                Console.WriteLine("There are no repeated names.");
            }

            List<int> manualSortList = new List<int> { 5, 2, 9, 1, 5, 6 };

            Console.WriteLine("Original List:");
            PrintList(numberList);

            ManualSort(numberList);

            Console.WriteLine("Sorted List:");
            PrintList(numberList);

            static void PrintList(List<int> numbers)
            {
                foreach (int num in numbers)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }
        }                           
    }
}
