
using System;
using System.Collections.Generic;
using System.Text;

using Ris;
using Some;

namespace MainApp
{
    //**************************************************************************
    //**************************************************************************
    //**************************************************************************
    class Init
    {

        //**********************************************************************
        //**********************************************************************
        //**********************************************************************

        public static void initialize(string[] args)
        {
            Console.WriteLine("ThreadTest BEGIN");
            initializePrint();
            Global.initialize();
        }

        //**********************************************************************
        //**********************************************************************
        //**********************************************************************

        public static void finalize()
        {
            Global.finalize();
            Console.WriteLine("ThreadTest END");
        }

        //**********************************************************************
        //**********************************************************************
        //**********************************************************************

        public static void initializePrint()
        {
            Prn.initializeForWinForm();

            Prn.setFilter(Prn.SocketInit1, false);
            Prn.setFilter(Prn.SocketInit2,  true);
            Prn.setFilter(Prn.SocketRun1,   true);
            Prn.setFilter(Prn.SocketRun2,  false);
            Prn.setFilter(Prn.SocketRun3,  false);
            Prn.setFilter(Prn.SocketRun4,  false);

            Prn.setFilter(Prn.ThreadRun1,   true);
            Prn.setFilter(Prn.ThreadRun2,  false);
            Prn.setFilter(Prn.ThreadRun3,  false);
            Prn.setFilter(Prn.ThreadRun4,  false);

            Prn.setFilter(Prn.View11, true);
            Prn.setFilter(Prn.View12, true);
            Prn.setFilter(Prn.View13, true);
            Prn.setFilter(Prn.View14, true);

        }
    }
}
