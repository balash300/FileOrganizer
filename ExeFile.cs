using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class ExeFile : FileProperties
    {
        public string Architecture { get; set; }
        public string Technologies { get; set; }

        public ExeFile(string fileName, string architecture, string technologies) : base(fileName, "exe")
        {
            Architecture = architecture;
            Technologies = technologies;
        }

        public override string GetFileDetails()
        {
            return base.GetFileDetails() +
                "\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~" +
                "\nEXE Specific Details:" +
                $"\n\tArchitecture: {Architecture}" +
                $"\n\tTechnologies: {Technologies}" +
                "\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~";
        }
    }
}
