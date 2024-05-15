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
        public DateTime CreationTime { get; }

        public FileProperties(string fileName, string fileExtension)
        {
            FileID = count;
            FileName = fileName;
            FileExtension = fileExtension;
            CreationTime = DateTime.Now;
            count++;
        }

        public virtual string GetFileDetails()
        {
            return "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n\n" +
                $"File ID: {FileID}" +
                $"\nFile Name And Extension: {FileName}" +
                $".{FileExtension}" +
                $"\nCreation Time: {CreationTime}" +
                "\n\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~";
        }

        public override string ToString()
        {
            return GetFileDetails();
        }
    }
}
