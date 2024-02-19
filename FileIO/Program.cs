using System;
using System.IO;
using System.Text;

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {  
            string line;
            string path = "C:\\Users\\Denim Admin\\Desktop\\textFile.txt";
            
            // Reading
            try
            {
                StreamReader sr = new StreamReader(path);
                line = sr.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                }
                sr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: ", ex.Message);
            }
            finally
            {
                Console.WriteLine("Executing read 'finally' block.");
            }

            // Writing 
            try
            {
                StreamWriter sw = new StreamWriter(path, true, Encoding.ASCII);
                sw.WriteLine("");
                sw.WriteLine("Writing the firstLine on Write Mode.");
                sw.WriteLine("From the StreamWriter class.");
                sw.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: ", ex.Message);

            }
            finally
            {
                Console.WriteLine("Executing write 'finally' block.");
            }

        }
    }
}
