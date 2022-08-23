using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpCoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Program to Group a list of References and find the next Reference for each reference

            //Write a.Net Core Console Application that accepts a list of strings containing data in the following formats:

            string[] sampleList = { "S1000112345", "SP21003456", "SP39263456", "120013579VA", "SP00003456", "S3126112345", "SPREFERENCE", "XYZ250783579", "391543579", "130013579" };
            Console.WriteLine("Given list of array : ");
            foreach (var item in sampleList)
            {
                Console.Write(" " + item + " ");
            }
            Console.WriteLine("\n");

            string selectedstring = "";
            List<string> stringsWithLettersAndNumbers = new List<string>();
            List<string> stringStartOrEndsWithLetter = new List<string>();
            List<string> stringWithnumbers = new List<string>();
            List<string> remainingStrings = new List<string>();
            int numCount = 0;
            int letterCount = 0;
            foreach (var removedstrings in sampleList)
            {
                selectedstring = removedstrings;
                char[] chararray = selectedstring.ToCharArray();
                for (int j = chararray.Length - 1; j >= 0; j--)
                {
                    if (Char.IsLetter(chararray[j]))
                    {
                        stringStartOrEndsWithLetter.Add(selectedstring.ToString());
                        break;
                    }
                    else
                    {
                        remainingStrings.Add(selectedstring.ToString());
                        break;
                    }
                }
            }

            foreach (var removedNumberStrings in remainingStrings)
            {
                numCount = 0;
                letterCount = 0;
                selectedstring = removedNumberStrings;
                char[] chararray = selectedstring.ToCharArray();
                for (int j = chararray.Length - 1; j >= 0; j--)
                {
                    if (Char.IsDigit(chararray[j]))
                    {
                        numCount++;
                    }
                    else
                    {
                        letterCount++;
                    }
                }
                if (letterCount == 0 && numCount >0)
                {
                    stringWithnumbers.Add(selectedstring.ToString());
                }
                else
                {
                    stringsWithLettersAndNumbers.Add(selectedstring.ToString());
                }
            }

            //An item that starts with a letter or combination of letters and numbers, but always ends with a number(E.g., “S3126112345”, “SP39263456”)
            Console.WriteLine("An item that starts with a letter or combination of letters and numbers, but always ends with a number:");
            foreach (var item in stringsWithLettersAndNumbers)
            {
                Console.Write("  " + item);
            }
            Console.WriteLine("\n");

            //An item that contains only numbers(E.g., “250783579”, “391543579”)
            Console.WriteLine("An item that contains only numbers:");
            foreach (var item in stringWithnumbers)
            {
                Console.Write("  " + item);
            }
            Console.WriteLine("\n");

            //An item that contains only letters, or ends always ends with letter(s)(E.g., “SPREFERENCE”, “SPREF123XYZ”)
            Console.WriteLine("An item that contains only letters, or ends always ends with letter:");
            foreach (var item in stringStartOrEndsWithLetter)
            {
                Console.Write("  " + item);
            }
            Console.WriteLine("\n");

            //Ignore the items that contain only letters or ends with letter(s)
            Console.WriteLine("Ignore the items that contain only letters or ends with letter(s):");
            foreach (var item in stringStartOrEndsWithLetter)
            {
                Console.Write("  " + item);
            }
            Console.WriteLine("\n");

            //  For the items that contain combination of letters and numbers (but end with number) do the following:
            //a) Split the string such that 2nd part contains only trailing numbers, and the 1st part contains the remaining string:

            Console.WriteLine("Split the string such that 2nd part contains only trailing numbers, and the 1st part contains the remaining string:");
            foreach (var item in stringsWithLettersAndNumbers)
            {
                string tempNum = "";
                string tempString = "";
                Char[] chararray = item.ToCharArray();
                for (int k = chararray.Length - 1; k >= 0; k--)
                {
                    if (char.IsDigit(chararray[k]))
                    {
                        tempNum = chararray[k] + tempNum;
                    }
                    else if (char.IsLetter(chararray[k]))
                    {
                        if (tempNum.Length > 0)
                        {
                            break;
                        }

                    }

                }
                for (int j = 0; j < (item.Length - tempNum.Length); j++)
                {
                    tempString = tempString + chararray[j];
                }

                Console.Write("First part : " + tempString + "  ");
                Console.WriteLine("Second part : " + tempNum);
            }
            Console.WriteLine("\n");

            //b) Group these strings based on their 1st part of the split.

            Console.WriteLine("Group these strings based on their 1st part of the split:");
            var sampleListData = stringsWithLettersAndNumbers.ToList();
            var orderedData = sampleListData.OrderBy(x=>x.Substring(0,2));
            foreach (var item in orderedData)
            {
                Console.Write("  " + item);
            }
            Console.WriteLine("\n");

            //Find the next logical sequence for each item in the list (except for those items which contain only letters or end with letter(s))
            Console.WriteLine("The next logical sequence for each item in the list:");
            List<string> totalListNotEndwithLetters = new List<string>();
            totalListNotEndwithLetters.AddRange(stringsWithLettersAndNumbers);
            totalListNotEndwithLetters.AddRange(stringWithnumbers);
            foreach (var item in stringsWithLettersAndNumbers)
            {
                string tempNum = "";
                string tempString = "";
                Char[] chararray = item.ToCharArray();
                for (int k = chararray.Length - 1; k >= 0; k--)
                {
                    if (char.IsDigit(chararray[k]))
                    {
                        tempNum = chararray[k] + tempNum;
                    }
                    else if (char.IsLetter(chararray[k]))
                    {
                        if (tempNum.Length > 0)
                        {
                            break;
                        }

                    }

                }
                for (int j = 0; j < (item.Length - tempNum.Length); j++)
                {
                    tempString = tempString + chararray[j];
                }

                double tempnumberAddition = double.Parse(tempNum) + 1;

                Console.WriteLine("Old String : " + item + "  Next Logical Sequence : "+ tempString+tempnumberAddition.ToString());
            }

            Console.ReadLine();

        }
    }
}
