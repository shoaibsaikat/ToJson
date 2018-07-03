using System;
using System.IO;

namespace FileParserWithDelimiter
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;

            string[] lines = File.ReadAllLines(@"C:\Users\mirahman\Desktop\ePRO UIText-en-us to other languages.txt");

            using (StreamWriter file = new StreamWriter(@"C:\Users\mirahman\Desktop\ePRO UIText-japanese.json"))
            {
                file.Write('{');
                // getting key
                foreach (var line in lines)
                {
                    var tokens = line.Split('\t');
                    try
                    {
                        var key = tokens[0];
                        var value = tokens[5];
                        var result = "\"" + key + "\": \"" + value + "\",";
                        file.WriteLine(result);
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine(e);
                    }
                }
                file.Write('}');
            }
            //Console.ReadLine();
        }
    }
}
