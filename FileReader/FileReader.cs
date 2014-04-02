using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace File_Reader
{
    public class FileReader
    {
        string line;
        List<String> input = new List<string>();

        public FileReader() { }
        
        public List<String> readFile(string fileName){
            System.IO.StreamReader file = new System.IO.StreamReader(@fileName);
            while ((line = file.ReadLine()) != null)
            {
                System.Console.WriteLine (line);
                input.Add(line);
            }
            file.Close();
            return input;
        }
    }
}
