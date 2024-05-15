using System;

namespace ConsoleApp3
{
    internal class PdfFile : FileProperties
    {
        public string FontInformation { get; set; }

        public PdfFile(string fileName, string fontInformation) : base(fileName, "pdf")
        {
            FontInformation = fontInformation;
        }

        public virtual string GetPdfFileDetails()
        {
            return base.ToString() +
                "\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~" +
                "\nPDF Specific Details:" +
                $"\n\tFont Information: {FontInformation}" +
                "\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~";
        }

        public override string ToString()
        {
            return GetPdfFileDetails();
        }
    }
}
