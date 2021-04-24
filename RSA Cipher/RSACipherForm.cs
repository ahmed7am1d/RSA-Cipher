using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RSA_Cipher.Classes;
using System.Numerics;
namespace RSA_Cipher
{
    public partial class Form1 : Form
    {


        BigInteger ee;
        BigInteger d;
        BigInteger p;
        BigInteger q;
        BigInteger phi;
        BigInteger n;
        string CurrentUserCipherWord;
        List<BigInteger> CipherToDecrypted;

        public Form1()
        {
            InitializeComponent();
            CipherToDecrypted = new List<BigInteger>();

        }

        #region Button Encrypte 


        private void btnEncrypte_Click(object sender, EventArgs e)
        {
            //reset result of encryption for each new encryption
            if (TextBoxKeyResult.Text != string.Empty)
            {
                TextBoxKeyResult.Text = string.Empty;
            }

            //before doing Encrypte we have to :
            //1- make sure Message is not empty 
            //2- the key e and the key n and d are not empty 
            if (TextBoxMessage.Text == string.Empty)
            {
                MessageBox.Show("Please Provide the Message first!", "Missing Info!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if ((TextBoxKeyE.Text == string.Empty || TextBoxKeyE.Text == "0") || (TextBoxKeyN.Text == "0" || TextBoxKeyN.Text == string.Empty) || (TextBoxKeyD.Text == "0" || TextBoxKeyD.Text == string.Empty))
            {
                MessageBox.Show("Please Provide The Key N and The Key E with D or Generate Randomly to Encrypte", "Missing Info!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //else if e and n and message is provided we will encrypte the message and show the result if they are vaild 
            else
            {
                ee = BigInteger.Parse(TextBoxKeyE.Text);
                d = BigInteger.Parse(TextBoxKeyD.Text);
                n = BigInteger.Parse(TextBoxKeyN.Text);

                //1- TEXT THE MESSAGE DIVIDED INTO BLOCKS 
                richTextBox1.Text = string.Empty;
                List<string> DivdedUserTextSeven = TextOperationServices.SplitInParts(TextBoxMessage.Text, 7).ToList();
                List<byte[]> bytesOfEachWord = TextOperationServices.GetASCIICode(DivdedUserTextSeven);
                List<List<int>> BinaryNumbers = TextOperationServices.GetListOfBinary(bytesOfEachWord);
                List<List<string>> FullBinaryNumber = TextOperationServices.GetListOfFullBinary(BinaryNumbers);
                List<string> FullMergedBinaryNumbers = TextOperationServices.GetFullBinaryNumberMerged(FullBinaryNumber);
                List<BigInteger> FullDecimalOpenText = TextOperationServices.GetFullTextNumber(FullMergedBinaryNumbers);

                //showing the full representation of open text in numeric form
                for (int i = 0; i < FullDecimalOpenText.Count; i++)
                {
                    //to avoid confustion of many spaces 
                    if (i == FullDecimalOpenText.Count)
                    {
                        richTextBox1.Text = richTextBox1.Text + FullDecimalOpenText[i].ToString();
                    }
                    else if (i == 0)
                    {
                        richTextBox1.Text = richTextBox1.Text + FullDecimalOpenText[i].ToString();
                    }

                    else
                    {
                        richTextBox1.Text = richTextBox1.Text + " " + FullDecimalOpenText[i].ToString();
                    }

                }

                //build the cipher blocks
                List<BigInteger> CipherBlocks = DecryptionAndEncryptionServices.GetCipherListText(FullDecimalOpenText, ee, n);

                //showing the full representation of Cipher Text
                for (int i = 0; i < CipherBlocks.Count; i++)
                {
                    //to avoid confustion of many spaces 
                    if (i == CipherBlocks.Count)
                    {
                        TextBoxKeyResult.Text = TextBoxKeyResult.Text + CipherBlocks[i].ToString();
                    }
                    else if (i == 0)
                    {
                        TextBoxKeyResult.Text = TextBoxKeyResult.Text + CipherBlocks[i].ToString();
                    }

                    else
                    {
                        TextBoxKeyResult.Text = TextBoxKeyResult.Text + " " + CipherBlocks[i].ToString();
                    }

                }


            }
        }
        #endregion

        #region Button Generate Random Key
        private void btnGenerateRandomKeys_Click(object sender, EventArgs e)
        {

            //reset all values 
            ee = 0;
            d = 0;
            phi = 0;
            n = 0;
            q = 0;
            p = 0;
            //generate random keys 
            //1- build p and q 

            do
            {
                p = DecryptionAndEncryptionServices.GetRandomPrimeNumber();
                q = DecryptionAndEncryptionServices.GetRandomPrimeNumber();
            } while (p == q);
            //2- build n and build phi
            n = p * q;

            //3- build phi 
            phi = (p - 1) * (q - 1);

            //4- build e 
            do
            {
                ee = DecryptionAndEncryptionServices.RandomIntegerBelowBigger(1, phi);
            } while (DecryptionAndEncryptionServices.GCD(ee, phi) != 1);

            //5- build d 
            d = DecryptionAndEncryptionServices.modInverse(ee, phi);
            //put all results 
            TextBoxKeyE.Text = ee.ToString();
            TextBoxKeyN.Text = n.ToString();
            TextBoxKeyD.Text = d.ToString();

        }
        #endregion

        #region Button Clear Field


        private void btnClearField_Click(object sender, EventArgs e)
        {
            //clear everyvalue reset 
            ee = 0;
            d = 0;
            p = 0;
            q = 0;
            phi = 0;
            n = 0;
            //clear text boxes to 0 
            TextBoxMessage.Text = string.Empty;
            TextBoxKeyResult.Text = string.Empty;
            TextBoxKeyE.Text = "0";
            TextBoxKeyN.Text = "0";
            TextBoxKeyD.Text = "0";
            TextBoxDecryptedText.Text = string.Empty;
            richTextBox1.Text = string.Empty;
            richTextBox3.Text = string.Empty;
            TextBoxMessageToDecrypte.Text = string.Empty;
        }

        #endregion

        #region Button Decrypte
        private void btnDecrypte_Click(object sender, EventArgs e)
        {

            //making sure  message is availbe 
            //the message should be numbers 
            //the 3 keys should be provided 
            if (TextBoxMessageToDecrypte.Text == string.Empty)
            {
                MessageBox.Show("Please Provide the Numeric Cipher Message to be Decrypted", "Missing Info!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //ELSE if text provided we will check if it is only numbers or not 
                if (TextBoxMessageToDecrypte.Text.Any(Char.IsLetter))
                {
                    MessageBox.Show("To Decrypte A message you need to provide the Numeric Cipher Numbers!", "Wrong Input!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                //else if text is only numbers 
                //                we will have string
                //this string will accept only letters
                //when it reaches space it will be added to list
                //and repedately:) until length of the message
                else
                {
                    if ((TextBoxKeyE.Text == "0" || TextBoxKeyE.Text == string.Empty) || (TextBoxKeyN.Text == "0" || TextBoxKeyN.Text == string.Empty) || (TextBoxKeyN.Text == "0" || TextBoxKeyN.Text == string.Empty))
                    {
                        MessageBox.Show("Provide the Key e and n with d to build d or generate Random Keys!!", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    //RESEt when user want another decryption
                    CurrentUserCipherWord = string.Empty;
                    CipherToDecrypted = new List<BigInteger>();
                    TextBoxDecryptedText.Text = string.Empty;
                    richTextBox3.Text = string.Empty;

                    //then assign E to text and n to text and build d 
                    //then do decryption process
                    ee = BigInteger.Parse(TextBoxKeyE.Text);
                    n = BigInteger.Parse(TextBoxKeyN.Text);
                    d = BigInteger.Parse(TextBoxKeyD.Text);


                    try
                    {

                        for (int i = 0; i < TextBoxMessageToDecrypte.Text.Length; i++)
                        {

                            if (!char.IsWhiteSpace(TextBoxMessageToDecrypte.Text[i]))
                            {
                                CurrentUserCipherWord = CurrentUserCipherWord + TextBoxMessageToDecrypte.Text[i];
                            }
                            else if (char.IsWhiteSpace(TextBoxMessageToDecrypte.Text[i]) && CurrentUserCipherWord != " " && i != TextBoxMessageToDecrypte.TextLength)
                            {
                                CipherToDecrypted.Add(BigInteger.Parse(CurrentUserCipherWord));
                                CurrentUserCipherWord = string.Empty;

                            }

                        }
                        //to add last element if it is not space 
                        CipherToDecrypted.Add(BigInteger.Parse(CurrentUserCipherWord));
                    }
                    catch (System.FormatException w)
                    {
                        MessageBox.Show("Please Provide the Start of Cipher without space and end of cipher without space", "Wrong Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                    //decrypte :) 
                    List<BigInteger> OTDecryptedBlocks = DecryptionAndEncryptionServices.GetOTDecrypted(CipherToDecrypted, d, n);

                    //show result 
                    for (int i = 0; i < OTDecryptedBlocks.Count; i++)
                    {
                        TextBoxDecryptedText.Text = TextBoxDecryptedText.Text + " " + OTDecryptedBlocks[i];
                    }


                    //show result back to text form 
                    List<string> FullBinaryMergedN = DecryptionAndEncryptionServices.GetFullMergedBinaryNumber(OTDecryptedBlocks);
                    List<List<string>> FullBinary7Blocks = DecryptionAndEncryptionServices.GetBinaryOfEachFullBinaryBlock(FullBinaryMergedN);
                    List<List<byte>> FullAsciiCode = DecryptionAndEncryptionServices.GetASCIIlaterFromBin(FullBinary7Blocks);
                    string finalList = DecryptionAndEncryptionServices.GetWordFromASCII(FullAsciiCode);
                    richTextBox3.Text = finalList;



                }


            }



        }

        #endregion

        #region Event allowing only letters for OT box


        private void TextBoxMessage_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            //{
            //    e.Handled = true;
            //}
        }



        #endregion

        #region Event allowing only Digits for CT box to decrypte and white spaces
        private void TextBoxMessageToDecrypte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        #endregion

        #region Event allowing only numbers to be provided for N and K and D


        private void TextBoxKeyN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TextBoxKeyE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void TextBoxKeyD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion


    }
}

