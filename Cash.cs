using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace Wrappers
{
    public class Cash
    {
        [DllImport("chib.cash.ctxfz.dll", CharSet = CharSet.Ansi)]
        public static extern void X_Report();

        [DllImport("chib.cash.ctxfz.dll", CharSet = CharSet.Ansi)]
        public static extern void Z_Report();

        [DllImport("chib.cash.ctxfz.dll", CharSet = CharSet.Ansi)]
        public static extern void MoneyIn(string summa);

        [DllImport("chib.cash.ctxfz.dll", CharSet = CharSet.Ansi)]
        public static extern void MoneyOut(string summa);

        /*
        [DllImport("chib.cash.ctxfz.dll", CharSet = CharSet.Ansi)]
        public static extern int setparams(String checkText);

        [DllImport("chib.cash.ctxfz.dll", CharSet = CharSet.Ansi)]
        public static extern int setparamsfz(String buffer, int bankComiss,
            int isPreCheck, int isCashlessCheck, int isECheck,
            String clientPhone, String clientEmail,
            String service, String cashier, String agentPhone,
            String operatorOper, String operatorName, String operatorAddress,
            String operatorInn, String operatorPhone);
        */
    }
}
