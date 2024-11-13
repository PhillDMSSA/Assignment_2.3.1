using System.IO;


namespace Assignment_2._3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create a variable for the text file
            string filePath = @"C:\Users\phillipdeleon\Documents\Text.txt";
            // saves entire list of text file inside array
            //string[] lines = File.ReadAllLines(filePath); 
            //define new list of type string
            List<string> lines = new List<string>();
            lines = File.ReadAllLines(filePath).ToList(); //Converts an array to list

            foreach (string line in lines)  //outputs the text from textfile
            {
                Console.WriteLine(line);
            }

            lines.Add("Phillip Deleon 27 935 Bel Aire"); //adds text to text file
            File.WriteAllLines(filePath, lines); //saves written input to text file



        }
    }
}
