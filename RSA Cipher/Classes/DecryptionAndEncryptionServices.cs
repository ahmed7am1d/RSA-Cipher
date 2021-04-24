using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace RSA_Cipher.Classes
{
    public static class DecryptionAndEncryptionServices
    {
        #region Function to generate big random  number in between (n to n)


        static public BigInteger RandomIntegerBelowBigger(BigInteger LowerBound, BigInteger HigherBound)
        {
            byte[] bytes = HigherBound.ToByteArray();
            BigInteger R;
            Random random = new Random();
            do
            {
                random.NextBytes(bytes);
                bytes[bytes.Length - 1] &= (byte)0x7F; //force sign bit to positive
                R = new BigInteger(bytes);
            } while (R >= HigherBound || R <= LowerBound);

            return R;
        }



        #endregion

        #region Function to Generate RandomPrimeNumber between 10^15 and 10^16-1



        static public ulong GetRandomPrimeNumber()
        {
            BigInteger highBound = 9999999999999999; //10^16 -1 
            BigInteger lowBound = 1000000000000000;// 10^15
            ulong ulong_a = 0;
            ulong ulong_b = 0;
            ulong decimal_number = 0;
            ulong ulong_number = 0;
            bool isPrime = true;
            do
            {
                decimal_number = (ulong)(RandomIntegerBelowBigger(lowBound, highBound));
                //Convert.ToDecimal(Console.ReadLine());
                DateTime date = DateTime.Now;

                if (decimal_number <= ulong.MaxValue)
                {
                    ulong_number = Convert.ToUInt64(decimal_number);
                    if (ulong_number < 2)
                    {
                        //Console.WriteLine(ulong_number + " is not a prime number");
                        isPrime = false;
                    }
                    else if (ulong_number == 2 || ulong_number == 3)
                    {
                        // Console.WriteLine(ulong_number + " is a prime number");
                        isPrime = true;

                    }
                    else if (ulong_number % 2 == 0)
                    {
                        // Console.WriteLine(ulong_number + " is not a prime number and is divisible by 2");
                        isPrime = false;
                    }
                    else
                    {
                        ulong_a = Convert.ToUInt64(Math.Ceiling(Math.Sqrt(ulong_number)));
                        for (ulong_b = 3; ulong_b <= ulong_a; ulong_b += 2)
                        {
                            if (ulong_number % ulong_b == 0)
                            {
                                //Console.WriteLine(ulong_number + " is not a prime number and is divisible by " + ulong_b);
                                isPrime = false;
                                goto terminate_ulong_primality_test;

                            }
                        }
                        //Console.WriteLine(ulong_number + " is a prime number");
                        isPrime = true;
                    }
                terminate_ulong_primality_test:
                    {
                    }
                }
                else
                {
                    if (decimal_number % 2 == 0)
                    {
                        // Console.WriteLine(decimal_number + " is not a prime number and is divisible by 2");
                        isPrime = false;
                    }
                    else
                    {
                        ulong_a = Convert.ToUInt64(Math.Ceiling(Math.Sqrt(ulong.MaxValue) * Math.Sqrt(Convert.ToDouble(decimal_number / ulong.MaxValue))));
                        for (ulong_b = 3; ulong_b <= ulong_a; ulong_b += 2)
                        {
                            if (decimal_number % ulong_b == 0)
                            {
                                // Console.WriteLine(decimal_number + " is not a prime number and is divisible by " + ulong_b);
                                isPrime = false;
                                goto terminate_decimal_primality_test;

                            }
                        }
                        //Console.WriteLine(decimal_number + " is a prime number");
                        isPrime = true;
                    }
                terminate_decimal_primality_test:
                    {
                    }
                }
                //Console.WriteLine("elapsed time: " + (DateTime.Now - date));


            } while (isPrime == false);

            // return the prime number
            return decimal_number;

        }

        #endregion

        #region function to calculate the GCD between two numbers 

        static public BigInteger GCD(BigInteger a, BigInteger b)
        {
            BigInteger Remainder;

            while (b != 0)
            {
                Remainder = a % b;
                a = b;
                b = Remainder;
            }

            return a;
        }


        #endregion

        #region function to find inverse multiplicative modulo

        static public BigInteger modInverse(BigInteger a, BigInteger m)
        {
            BigInteger m0 = m;
            BigInteger y = 0, x = 1;

            if (m == 1)
                return 0;

            while (a > 1)
            {
                // q is quotient
                BigInteger q = a / m;

                BigInteger t = m;

                // m is remainder now, process
                // same as Euclid's algo
                m = a % m;
                a = t;
                t = y;

                // Update x and y
                y = x - q * y;
                x = t;
            }

            // Make x positive
            if (x < 0)
                x += m0;

            return x;
        }

        #endregion


        //encrpyion 

        #region fuction that return a list of cipher Text of each block
        static public List<BigInteger> GetCipherListText(List<BigInteger> s, BigInteger e, BigInteger n)
        {
            List<BigInteger> CipherText = new List<BigInteger>();
            BigInteger currentInteger = 0;

            for (int i = 0; i < s.Count; i++)
            {
                currentInteger = BigInteger.ModPow(s[i], e, n);
                CipherText.Add(currentInteger);
            }

            return CipherText;

        }
        #endregion

        //decryption 

        #region fuction that decrypte Cipher and return it as decimal representation of the words
        static public List<BigInteger> GetOTDecrypted(List<BigInteger> s, BigInteger d, BigInteger n)
        {
            List<BigInteger> OpenTextDecrypted = new List<BigInteger>();
            BigInteger currentInteger = 0;

            for (int i = 0; i < s.Count; i++)
            {
                currentInteger = BigInteger.ModPow(s[i], d, n);
                OpenTextDecrypted.Add(currentInteger);
            }

            return OpenTextDecrypted;

        }




        #endregion


        #region function Get vaild binary number form 

        public static string GetVaildBinaryNumber(string BinaryNumber)
        {
            string CopyUser = BinaryNumber;
            List<byte> byteList = new List<byte>();
            byteList.Add((byte)Convert.ToUInt64(ulong.Parse(CopyUser).ToString(), 2));

            string DecimalBye = string.Empty;


            for (int i = 0; i < byteList.Count; i++)
            {
                DecimalBye = DecimalBye + byteList[i];
            }


            if (int.Parse(DecimalBye) > 127)
            {

              

                if (CopyUser.Length == 10 && CopyUser[0] == '0' && CopyUser[1] == '1' && CopyUser[9] == '0')
                {
                    CopyUser = CopyUser.Remove(7, 2);
                    CopyUser = "00" + CopyUser;
                }
                if (CopyUser.Length == 10)
                {
                    CopyUser = CopyUser.Remove(9);
                    CopyUser = "0" + CopyUser;
                }
                else if (BinaryNumber.Length == 9)
                {
                    CopyUser = "0" + CopyUser;
                }


            }

            return CopyUser;
        }


        #endregion


        public static List<string> GetFullMergedBinaryNumber(List<BigInteger> list)
        {

            List<string> FullMergedBinaryNumber = new List<string>();


            for (int i = 0; i < list.Count; i++)
            {


                FullMergedBinaryNumber.Add(TextOperationServices.decToBinary(list[i]));

                FullMergedBinaryNumber[i] = "000" + FullMergedBinaryNumber[i];


            }

            return FullMergedBinaryNumber;

        }

        public static List<List<string>> GetBinaryOfEachFullBinaryBlock(List<string> s)
        {
            List<List<string>> vs1 = new List<List<string>>();
            //1- string one will be divide into list contain 7 blocks each index of string one 
            for (int i = 0; i < s.Count; i++)
            {

                vs1.Add(TextOperationServices.SplitInParts(s[i], 10).ToList());
            }



            return vs1;
        }

        public static List<List<byte>> GetASCIIlaterFromBin(List<List<string>> s)
        {
            List<List<byte>> vs = new List<List<byte>>();
            List<byte> vs1 = new List<byte>();

            for (int i = 0; i < s.Count; i++)
            {
                vs1 = new List<byte>();
                for (int j = 0; j < s[i].Count; j++)
                {


                    vs1.Add((byte)Convert.ToUInt64(ulong.Parse(GetVaildBinaryNumber(s[i][j])).ToString(), 2));

                }
                vs.Add(vs1);

            }


            return vs;

        }

        public static string GetWordFromASCII(List<List<byte>> s)
        {
            List<string> finalWords = new List<string>();
            string FullOTDecrpted = string.Empty;

            for (int i = 0; i < s.Count; i++)
            {
                finalWords.Add(Encoding.ASCII.GetString(s[i].ToArray()));
            }
            //detect each @ and turn it to space 

            for (int i = 0; i < finalWords.Count; i++)
            {

                finalWords[i] = finalWords[i].Replace("@", " ");


            }

            //merge all string in one string 

            for (int i = 0; i < finalWords.Count; i++)
            {

                FullOTDecrpted = FullOTDecrpted + finalWords[i];


            }

            return FullOTDecrpted;
        }


    }
}
