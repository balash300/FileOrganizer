using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Enums
    {
        public enum FileType
        {
            pdf = 1,
            exe,
            txt
        }

        public enum FontType
        {
            Arial = 1,
            TimesNewRoman,
            CourierNew,
        }

        public enum TechnologyType
        {
            Java = 1,
            CSharp,
            Python,
        }
    }
}
