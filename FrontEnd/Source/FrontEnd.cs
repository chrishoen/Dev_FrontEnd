using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.InteropServices; 

namespace MainApp
{
    //**************************************************************************
    //**************************************************************************
    //**************************************************************************
    // This is a front end example class. It calls functions that reside in
    // the back end dll.

    public class FrontEnd
    {
        //**********************************************************************
        //**********************************************************************
        //**********************************************************************
        // Members
        
        //**********************************************************************
        //**********************************************************************
        //**********************************************************************
        // Call the back end function.

        public void doGetStatus()
        {
            int tStatus = BackEnd.getBackEndStatus();
            
            Console.WriteLine("BackEndStatus     {0}", tStatus);
        }

    };

}