using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ExceptionHandlingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // -----------------------------------------------------------------------------
            // First create an char[], it must contain 6 numbers and 3 letters - name it arr
            // Create a list called numbers that will hold integers
            // Create an string variable with an empty string initializer - name it str

            // using a foeach loop, attempt to parse the elements in your char[] with int.Parse()
            // and Exceptions will be thrown 
            // Below we will set this up 
            // ------------------------------------------------------------------------------
            var arr = new char[] { '4', '5', '2', '6', '1', '9', 'a', 'd', 'q' };
            var numbers = new List<int>();
            string str = "";


            //TODO START HERE:
            
            // Make a foreach loop to iterate through your character array
            
                // Now create a try catch
                
                    // Inside your try block
                        // set your string variable to each array element in your char[] to .ToString()
                        // Now, using int.Parse, parse your string variable and store in an int variable
                        // Then add each int to your list
                
                // in your () of your catch, 
                
                    //Console.WriteLine($"Unable to Parse '{character}'"); //character will be the name of each item in your collection
            foreach (char character in arr)
            {
                try
                {
                    str = character.ToString();
                    int number = int.Parse(str);
                    numbers.Add(number);
                }
                catch (Exception e)
                {
                    Console.WriteLine($"{DateTime.Now}: Unable to Parse '{character}': {e.Message}");
                    /*File.AppendAllText("Log.txt", $"{DateTime.Now.ToString()}: {e.Message}" *//*+ Environment.NewLine*//*);*/
                    LoggerError(e);
                }
            }

            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
        }
        static void LoggerError(Exception error)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"{Environment.NewLine}--------------------{Environment.NewLine}");
            sb.Append($"{error.Message} {DateTime.Now}");
            sb.Append($"{Environment.NewLine}--------------------{Environment.NewLine}");
            var filePath = "";

            File.AppendAllText(filePath + "log.txt", sb.ToString());
        }
    }
}
