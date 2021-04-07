using System;

namespace WhiteboardEx_SD9_Kurt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Whiteboard Solutions Container.");

            int[] newArray = { 4, 8, 9, 2, 3, 5 };
            ArrayToCSV(newArray);
            Console.WriteLine(csv);
            //Class1 newReview = new Class1(7,8);
            //(int pubField, int privField) = newReview;
            //

            //int[] unsortedArray = { 1, 3, 4, 5, 7 };
            //Console.WriteLine(unsortedArray);
            //for (int i = 0; i < (unsortedArray.Length - 1); i++)
            //{
            //    int h = unsortedArray[i];
            //    int j = unsortedArray[i + 1];
            //    if (h > j)
            //    {
            //        unsortedArray[i] = j;
            //        unsortedArray[i + 1] = h;
            //        Console.WriteLine($"h = {h}\n i = {i}\n j = {j}");
            //    }
            //    else
            //    {
            //        i++;
            //    }
            //    Console.WriteLine(unsortedArray);
            //}
            //Console.WriteLine(unsortedArray);



            static string ArrayToCSV(int[] intArray)
            {
                string csv = "";
                foreach (int num in intArray)
                {
                    csv += num + ",";
                }

                return csv;
                
            }
        }

    }
}
