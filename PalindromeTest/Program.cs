using System;
// using System.Linq;
namespace PalindromeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string testString = "";

            string s1 = "dog";
            string s2 = "cat";
            string s3 = "tacocat";
            string s4 = "hotdog";
            string s5 = "amanaplanacanalpanama";



            isPalindrome2(s1);
            isPalindrome2(s2);
            isPalindrome2(s3);
            isPalindrome2(s4);
            isPalindrome2(s5);
        }

        //private static bool isPalindrome2(string testString)
        {
            string rvrs = "";
            for (int i = testString.Length; i <= 0 ; i--)
            {
                rvrs += testString[i];
            }

            Console.WriteLine($"Palindrome test {testString} <> {isPalindrome(testString)}");
            return true;
        }

        private static bool isPalindrome(string testString)
        {
            string palindrome = testString;
            for (int i = 0; i < testString.Length/2; i++)
            {
                for (int j = testString.Length; j > 0; j--)
                {
                    int last = testString.Length - 1;
                    if (testString[i] != testString[last - i]) return false;
                }

            }
            return true;
            //// string palindrome = (string)testString.Reverse();
            //if (testString == palindrome)
            //{
            //Console.WriteLine($"{testString} is a palindrome!");
            //    return true;
            //}
            //else
            //{
            //    Console.WriteLine($"{testString} is NOT a palindrome!");
            //    return false;
            //}
        }
    }
}
