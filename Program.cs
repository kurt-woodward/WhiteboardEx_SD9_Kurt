using System;

namespace WhiteboardEx_SD9_Kurt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Whiteboard Solutions Container.");

            Class1 newReview = new Class1(7,8);
            (int pubField, int privField) = newReview;

        }

    }
}
