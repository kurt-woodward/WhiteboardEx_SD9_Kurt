using System;

namespace CaesarCipher
{
    class Program
    {
        static int CipherKey = 3;
        static void Main(string[] args)
        {
            string[] plainText = { "C", "A", "T" };
            
            Console.WriteLine($"text to encrypt: {Alpha.C}{Alpha.A}{Alpha.T}");
            Console.WriteLine($"cipher key = {CipherKey}: {crypto(plainText, CipherKey)}");
            CipherKey = -3;
            Console.WriteLine($"cipher key = {CipherKey}: {crypto(plainText, CipherKey)}");
        }

        enum Alpha
        {
            A, B, C, D, E,
            F, G, H, I, J,
            K, L, M, N, O,
            P, Q, R, S, T,
            U, V, W, X, Y, Z
        }

        static string crypto(string[] plainText, int CipherKey)
        {
            string cipherText = "";
            int cipherKey = modularMath(CipherKey);


            foreach (var pt in plainText)
            {
                int alphaInt = (int)Enum.Parse(typeof(Alpha), pt);
                alphaInt += modularMath(cipherKey);
                cipherText += ((Alpha)Enum.Parse(typeof(Alpha), pt) + cipherKey);
            }


            return cipherText;
        }
            static int modularMath(int cipherKey)
            {
                int modulus = (26 + cipherKey) % 26;
                return modulus;            
            }

    }
}
