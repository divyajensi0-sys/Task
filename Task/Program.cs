using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Reverse a String
            string str = "hello";
            string rev = "";

            for (int i = str.Length - 1; i >= 0; i--)
            {
                rev = rev + str[i];
            }

            Console.WriteLine("Reversed string: " + rev);


            //Palindrome
            string str3 = "madam";
            string rev2 = "";

            for (int i = str3.Length - 1; i >= 0; i--)
            {
                rev2 = rev2 + str3[i];
            }

            if (str3 == rev2)
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not a palindrome");
            }

            //Reverse the order of words in a string

            string str1 = "I love coding";
            string word = "";
            string result = "";

            for (int i = 0; i <= str.Length; i++)
            {
                if (i == str1.Length || str1[i] == ' ')
                {
                    result = word + " " + result;
                    word = "";
                }
                else
                {
                    word = word + str[i];
                }
            }

            Console.WriteLine(result.Trim());


            //Reverse each word in a string
            string str2 = "hello world";
            string word1 = "";

            for (int i = 0; i <= str2.Length; i++)
            {
                if (i == str2.Length || str2[i] == ' ')
                {
                    for (int j = word1.Length - 1; j >= 0; j--)
                    {
                        Console.Write(word1[j]);
                    }

                    if (i < str2.Length)
                    {
                        Console.Write(" ");
                    }

                    word1 = "";
                }
                else
                {
                    word1 = word1 + str[i];
                }

                //Count the occurrence of each character
                string str4 = "hello";

                for (int j = 0; j < str.Length; j++)
                {
                    bool counted = false;

                    for (int k = 0; k < i; k++)
                    {
                        if (str[j] == str[k])
                        {
                            counted = true;
                            break;
                        }
                    }

                    if (counted)
                    {
                        continue;
                    }

                    int count = 0;

                    for (int k = 0; k < str.Length; j++)
                    {
                        if (str[j] == str[k])
                        {
                            count++;
                        }
                    }

                    Console.WriteLine(str[i] + " = " + count);


                }


                //Remove duplicate characters from a string
                string str5 = "programming";
                string result1 = "";

                for (int h = 0; h < str.Length; h++)
                {
                    bool found = false;

                    for (int j = 0; j < result.Length; j++)
                    {
                        if (str[i] == result[j])
                        {
                            found = true;
                            break;
                        }
                    }

                    if (!found)
                    {
                        result = result + str[i];
                    }
                }

                Console.WriteLine(result);



            }
        }
    }
}

