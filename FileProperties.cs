using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class FileProperties
    {
        static int count = 1;
        public int FileID { get; }
        public string FileName { get; set; }
        public string FileExtension { get; set; }
        public StringBuilder FilesStringValues { get; set; }
        public DateTime CreationTime { get; }

        public FileProperties(string fileName, string fileExtension, StringBuilder filesStringValues)
        {
            FileID = count;
            FileName = fileName;
            FileExtension = fileExtension;
            FilesStringValues = filesStringValues;
            CreationTime = DateTime.Now;
            count++;
        }

        public FileProperties()
        {
            FileID = 0;
            FileName = "Unknown";
            FileExtension = "Unknown";
            FilesStringValues = new StringBuilder();
            CreationTime = DateTime.Now;
        }

        public override string ToString()
        {
            return "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n\n" +
                $"File ID: {FileID}" +
                $"\nFile Name And Extension: {FileName}" +
                $".{FileExtension}" +
                $"\nCreation Time: {CreationTime}" +
                $"\nFile String Values: \n{FilesStringValues}" +
                "\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~";
        }
    }
}
