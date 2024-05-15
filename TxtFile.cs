﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class TxtFile : FileProperties
    {
        public string FileContent { get; set; }
        public TxtFile(string fileName, string fileContent) : base(fileName, "txt")
        {
            FileContent = fileContent;
        }

        public virtual string GetTxtFileDetails()
        {
            return base.ToString() +
                "\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~" +
                "\nTXT Specific Details:" +
                $"\n\tFile Content: {FileContent}" +
                "\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~";
        }

        public override string ToString()
        {
            return GetTxtFileDetails();
        }
    }
}
