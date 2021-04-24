using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace RSA_Cipher.Classes
{
    public static class TextOperationServices
    {
        #region Method return list of text divided into 7 letters each in case last not 7 will be added


        public static IEnumerable<String> SplitInParts(string s, Int32 partLength)
        {
            if (s == null)
                throw new ArgumentNullException(nameof(s));
            if (partLength <= 0)
                throw new ArgumentException("Part length has to be positive.", nameof(partLength));

            for (var i = 0; i < s.Length; i += partLength)
                yield return s.Substring(i, Math.Min(partLength, s.Length - i));
        }


        #endregion


        #region Method to return a list of array of full binary numbers of each word of 7 letters  

        public static List<byte[]> GetASCIICode(List<string> userList)
        {
            List<byte[]> list = new List<byte[]>();

            for (int i = 0; i < userList.Count; i++)
            {
                list.Add(Encoding.ASCII.GetBytes(userList[i]));
            }

            return list;

        }



        #endregion

        #region Method that return a list of  binary number of each of the 7 letters word 
        //for each array of bytes of the word of 7 length we wiil turn each char to binary 

        public static List<List<int>> GetListOfBinary(List<byte[]> userArray)
        {
            List<List<int>> BinaryNumbers = new List<List<int>>();
            List<int> BinaryNumbers2 = new List<int>();

            byte currentByte = 0;
            int currentBinary = 0;

            for (int i = 0; i < userArray.Count; i++)
            {


                BinaryNumbers2 = new List<int>();
                for (int j = 0; j < userArray[i].Length; j++)
                {
                    currentByte = userArray[i][j];
                    currentBinary = int.Parse(Convert.ToString(currentByte, 2));
                    BinaryNumbers2.Add(currentBinary);
                }
                BinaryNumbers.Add(BinaryNumbers2);



            }
            return BinaryNumbers;
        }



        #endregion

        #region Method return a list of list of strings that repersent each string  binary number of 7 letters with 000 begining 

        public static List<List<string>> GetListOfFullBinary(List<List<int>> userArray)
        {
            List<List<string>> FullBinaryNumber = new List<List<string>>();
            List<string> newNumbers = new List<string>();

            string currentByte = string.Empty;
            string currentBinary = string.Empty;

            for (int i = 0; i < userArray.Count; i++)
            {


                newNumbers = new List<string>();
                for (int j = 0; j < userArray[i].Count; j++)
                {
                    currentByte = userArray[i][j].ToString();
                    currentBinary = $"000{currentByte}";
                    newNumbers.Add(currentBinary);
                }
                FullBinaryNumber.Add(newNumbers);



            }
            return FullBinaryNumber;
        }


        #endregion

        #region Method for returning a list of strings each string represent full binary number of the 7 letters 


        public static List<string> GetFullBinaryNumberMerged(List<List<string>> userList)
        {
            string FinalBigBinaryNumber = string.Empty;
            List<string> MergedListBinay = new List<string>();
            for (int i = 0; i < userList.Count; i++)
            {
                FinalBigBinaryNumber = string.Empty;

                for (int j = 0; j < userList[i].Count; j++)
                {
                    FinalBigBinaryNumber = FinalBigBinaryNumber + userList[i][j];
                }
                MergedListBinay.Add(FinalBigBinaryNumber);
            }

            return MergedListBinay;

        }


        #endregion

        #region Method to convert Binary To Decimal 
        static BigInteger binaryToDecimal(BigInteger n)
        {
            BigInteger num = n;
            BigInteger dec_value = 0;

            // Initializing base1
            // value to 1, i.e 2^0
            BigInteger base1 = 1;

            BigInteger temp = num;
            while (temp > 0)
            {
                BigInteger last_digit = temp % 10;
                temp = temp / 10;

                dec_value += last_digit * base1;

                base1 = base1 * 2;
            }

            return dec_value;
        }
        #endregion

        #region Method for retruning final full decimal number of each block of 7 char 
        public static List<BigInteger> GetFullTextNumber(List<string> userList)
        {
            List<BigInteger> FullTextNumber = new List<BigInteger>();
            BigInteger Number = 0;
            for(int i = 0; i < userList.Count;i++)
            {
                Number = 0;
                Number = binaryToDecimal(BigInteger.Parse(userList[i]));
                FullTextNumber.Add(Number);
            }

            return FullTextNumber;
        }


        #endregion

        #region function to Convert Decimal To Binary Method 



        public static string decToBinary(BigInteger n)
        {
            // array to store binary number
            BigInteger[] binaryNum = new BigInteger[400];
            string BinaryNumber = string.Empty;
            // counter for binary array
            int i = 0;
            while (n > 0)
            {

                // storing remainder in binary array
                binaryNum[i] = n % 2;
                n = n / 2;
                i++;
            }

            // printing binary array in reverse order
            for (int j = i - 1; j >= 0; j--)
            {
                BinaryNumber = BinaryNumber + binaryNum[j];
            }


            return BinaryNumber;
        }
        #endregion





    }
}
