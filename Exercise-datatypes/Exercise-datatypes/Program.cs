using System;

namespace Exercise_datatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            
//---------------area of rectangle-------------------------
            float length, width;
            double area;
           Console.WriteLine("Enter length");
            string input = Console.ReadLine();
            length= float.Parse(input);
            width = float.Parse(input);
            area = length * width;
            Console.WriteLine("\nthe Area of their rectangle is: " + area + "\n");

            //-------------- Search And remove Alice Word-------------------------
            string str = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";


            string upperCaseWord = str.ToUpper();
           string[] words = upperCaseWord.Split("ALICE");
            
            Console.WriteLine(upperCaseWord);
            foreach (var word in words)
            {
                
                Console.WriteLine($" The new Sentence without Alice : \n \n { word}");
                
            }
            
        }

    }
}
  

