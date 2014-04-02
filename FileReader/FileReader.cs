using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace File_Reader{
    public class FileReader{
        public FileReader() { }
        
        public List<String> readFile(string fileName){
            string line;
            List<String> input = new List<string>();
            System.IO.StreamReader file = new System.IO.StreamReader(@fileName);
            while ((line = file.ReadLine()) != null){
                System.Console.WriteLine (line);
                input.Add(line);
            }
            file.Close();
            return input;
        }
    }
}
