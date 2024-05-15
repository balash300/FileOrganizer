using System.Text;

using static ConsoleApp3.FileProperties;
using static ConsoleApp3.QuestionHandler;
using static ConsoleApp3.Enums;
using static ConsoleApp3.PdfFile;
using System.Runtime.InteropServices;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool t = true;
            List<FileProperties> file = new List<FileProperties>();
            FileType fileType;
            int i = 1;
            while (t)
            {
                Console.Write("\nDo you want to enter the file name yourself? (y/n): ");
                string str1 = Console.ReadLine();
                ValidateYesNoInput(str1);
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
                fileType = (FileType)int.Parse(ValidateNumericInput(fileExtension));
                fileExtension = fileType.ToString();
                Console.WriteLine("\n--------------------------------------------------------------------");
                if (fileType == FileType.pdf)
                {
                    Console.Write("\nFont Type\n\n\t1-Arial\n\t2-TimesNewRoman\n\t3-CourierNew\n\nEnter the font information in the PDF file: ");
                    string fontInformation = Console.ReadLine();
                    FontType fontType = (FontType)int.Parse(ValidateNumericInput(fontInformation));
                    fontInformation = fontType.ToString();

                    PdfFile pdfFile = new PdfFile(fileName, fontInformation);
                    file.Add(pdfFile);
                }
                else if (fileType == FileType.exe)
                {
                    Console.Write("\nArchitecture Type\n\n\t1-32 bit\n\t2-64 bit\n\nEnter the architecture of the EXE file: ");
                    string architecture = Console.ReadLine();
                    ValidateNumericInputForFont(architecture);
                    if (architecture == "1")
                    {
                        architecture = "32 bit";
                    }
                    else
                    {
                        architecture = "64 bit";
                    }
                    Console.Write("\nTechnologies\n\n\t1-Java\n\t2-C#\n\t3-Python\n\nEnter the technologies used in the EXE file: ");
                    string technologies = Console.ReadLine();
                    TechnologyType technologyType = (TechnologyType)int.Parse(ValidateNumericInput(technologies));
                    technologies = technologyType.ToString();
                    ExeFile exeFile = new ExeFile(fileName, architecture, technologies);
                    file.Add(exeFile);
                }
                else if (fileType == FileType.txt)
                {
                    string fileContent = "";
                    bool t2 = true;
                    while (t2)
                    {
                        Console.Write("\nDo you want to add information to the file? (y/n): ");
                        string inf = Console.ReadLine();
                        ValidateYesNoInput(inf);

                        if (inf.Equals("n"))
                        {
                            t2 = false;
                        }
                        else if (inf.Equals("y"))
                        {
                            Console.Write("\nEnter new information into the file: \n\n\t");
                            string str = Console.ReadLine();
                            fileContent += "\n\t" + str;
                        }
                    }
                    TxtFile txtFile = new TxtFile(fileName, fileContent);
                    file.Add(txtFile);
                }                
                Console.WriteLine("\n--------------------------------------------------------------------\n");
                Console.Write("Exit the program (y/n): ");
                string last = Console.ReadLine();
                ValidateYesNoInput(last);
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
