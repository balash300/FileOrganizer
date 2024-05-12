using System.Text;
using System.Xml.Linq;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool t = true;
            List<FileProperties> file = new List<FileProperties>();
            int i = 1;

            while (t)
            {
                Console.Write("\nDo you want to enter the file name yourself? (y/n): ");
                string str1 = Console.ReadLine();

                while (str1 != "y" && str1 != "n")
                {
                    Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    Console.WriteLine("Invalid Input");
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
                    Console.Write("Enter correct input: ");
                    str1 = Console.ReadLine();
                };

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

                while (fileExtension != "1" && fileExtension != "2" && fileExtension != "3")
                {
                    Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    Console.WriteLine("Invalid file extension");
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
                    Console.Write("Enter file extension: ");
                    fileExtension = Console.ReadLine();
                }

                switch (fileExtension)
                {
                    case "1":
                        fileExtension = "pdf";
                        break;
                    case "2":
                        fileExtension = "exe";
                        break;
                    case "3":
                        fileExtension = "txt";
                        break;
                    default:
                        Console.WriteLine("Invalid file extension");
                        break;
                }

                Console.WriteLine("\n--------------------------------------------------------------------");


                StringBuilder filesStringValues = new StringBuilder();
                bool t2 = true;
                while (t2)
                {
                    Console.Write("\nDo you want to add information to the file? (y/n): ");
                    string inf = Console.ReadLine();

                    while (inf != "y" && inf != "n")
                    {
                        Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                        Console.WriteLine("Invalid Input");
                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
                        Console.Write("Enter correct input: ");
                        inf = Console.ReadLine();
                    }

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

                while (last != "y" && last != "n")
                {
                    Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    Console.WriteLine("Invalid Input");
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
                    Console.Write("Enter valid input: ");
                    last = Console.ReadLine();
                }

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
