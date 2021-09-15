using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testGitHub3.Classes
{
    public static class Messages
    {
        public static void direBonjour(string destinataire)
        {
            MessageBox.Show("Bonjour " + destinataire);
        }
    }
}
