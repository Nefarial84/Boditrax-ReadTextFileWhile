using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace ReadTeaxtFileWhile
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                StreamReader myReader = new StreamReader("\\boo\\Values1.txt");
                String line = "";

                while (line != null)
                {

                    line = myReader.ReadLine();
                    if (line != null)
                        Console.WriteLine(line);

                    myReader.Close();
                                  }
            }
            catch(FileNotFoundException e)
            {
                Console.WriteLine("Could not locate file - are you sure you are looking for the correct file?");
            }
            catch(DirectoryNotFoundException e)
            {
                Console.WriteLine("Could not find Directory - are you sure you the Directory exists?");
            }
            catch (Exception e)
            {
                Console.WriteLine("We have experianced an error - {0}", e.Message);
            }
            finally
            {
                Console.WriteLine("Perform any clean up to roll back data or close conections to any files or data bases");
            }



            Console.ReadLine();


        }
    }
}
