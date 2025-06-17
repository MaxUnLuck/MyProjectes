using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp8_1
{
    class CountOfWindowControl
    {
        static CountOfWindowControl singelton = new CountOfWindowControl();
        public static CountOfWindowControl Singelton()
        {
            if (singelton == null)
            {
                singelton = new CountOfWindowControl();
            }
            return singelton;
        }
        static CountOfWindowControl()
        {
            
        }
        public bool AboutProgram = false;
        public bool AdminUserControl = false;
        public bool CreateOrder = false;
        public bool EditOrder = false;
        public bool SewOrder = false;
    }
}
