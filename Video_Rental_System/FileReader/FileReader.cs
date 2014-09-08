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
            StreamReader file = new StreamReader(@fileName);
            while ((line = file.ReadLine()) != null){
                input.Add(line);
            }
            file.Close();
            return input;
        }

        public void writeFile(List<string> input, string fileName){
            StreamWriter file = new StreamWriter(@fileName);
            foreach (string item in input){
                file.WriteLine(item);
            }
            file.Close();
        }
    }
}
