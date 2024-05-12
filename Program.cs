using System.Text;

using static ConsoleApp3.FileProperties;
using static ConsoleApp3.Question;
using static ConsoleApp3.Enums;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool t = true;
            List<FileProperties> file = new List<FileProperties>();
            FileExtension extension;
            int i = 1;

            while (t)
            {
                Console.Write("\nDo you want to enter the file name yourself? (y/n): ");
                string str1 = Console.ReadLine();
                question1(str1);

                string fileName;

                if (str1.Equals("y"))
                {
                    Console.Write("\nEnter file name: ");
                    fileName = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("\nThe file name is set");
                    fileName = "Document" + i;
                    i++;
                };

                Console.WriteLine("\n--------------------------------------------------------------------\n");


                Console.Write("File Extensions\n\n\t1-pdf\n\t2-exe\n\t3-txt\n\nEnter file extension: ");
                string fileExtension = Console.ReadLine();
                

                extension = (FileExtension)int.Parse(question2(fileExtension));
                fileExtension = extension.ToString();
                Console.WriteLine("\n--------------------------------------------------------------------");


                StringBuilder filesStringValues = new StringBuilder();
                bool t2 = true;
                while (t2)
                {
                    Console.Write("\nDo you want to add information to the file? (y/n): ");
                    string inf = Console.ReadLine();
                    question1(inf);

                    if (inf.Equals("n"))
                    {
                        t2 = false;
                    }
                    else if (inf.Equals("y"))
                    {
                        Console.Write("\nEnter new information into the file: \n\n\t");
                        string str = Console.ReadLine();
                        filesStringValues.AppendLine("\t" + str);
                    }
                }


                FileProperties fileProperties = new FileProperties(fileName, fileExtension, filesStringValues);
                file.Add(fileProperties);


                Console.WriteLine("\n--------------------------------------------------------------------\n");
                Console.Write("Exit the program (y/n): ");
                string last = Console.ReadLine();
                question1(last);

                if (last.Equals("y"))
                {
                    t = false;
                    Console.WriteLine("\n--------------------------------------------------------------------\n");

                    foreach (var item in file)
                    {
                        Console.WriteLine(item);
                    }
                }
                Console.WriteLine("\n--------------------------------------------------------------------");
            }
        }
    }
}
