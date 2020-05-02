using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiPPOON_PP.Classes
{
    public static class CallBack
    {
        public delegate void callbackEvent(string Reload);
        public static callbackEvent callbackEventHandler;
    }
}
