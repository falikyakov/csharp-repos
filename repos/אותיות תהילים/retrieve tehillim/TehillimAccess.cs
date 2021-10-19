using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace retrieve_tehillim
{
    public class TehillimAccess
    {
        public TehillimAccess(char x)
        {

        }

        public string TehillimOpen()
        {
            string tehillimText = File.ReadAllText(@"C:\Users\Yanky\Desktop\Chaim Yehuda Aryeh.docx");
            

            return tehillimText;
        }

    }
}
