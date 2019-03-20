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
    // This class provides definitions of functions that are exported by the
    // back end dll. A call to one of these is a call to the function in the
    // dll.

    public class BackEnd
    {
        //**********************************************************************
        //**********************************************************************
        //**********************************************************************
        // Constants.

        // The name of this DLL, used below.
        public const string cDLLName = "BackEndDLL";

        // Error codes.
        public const int cTargetError1 = -101;
        public const int cCameraError1 = -102;
        public const int cPnPCheckArgumentsError1 = -103;
        public const int cStage4NotReachedError1 = -104;

        //**********************************************************************
        //**********************************************************************
        //**********************************************************************
        // Initialize the dll. Read a settings file, initialize resources, and
        // launch threads. This must be called before any other functions in
        // the dll can be called. Return true if successful.
        // 
        // The settings file contains sections of commands that are used to 
        // set dll settings variables.
        // 
        // A section within the settings file is supplied as input.
        // 
        // First this reads the default section of the file and then reads the
        // input section. This allows having default settings with overrides
        // for some specific variables.
        [DllImport(cDLLName)]
        public static extern bool initializeBackEnd();

        //**********************************************************************
        //**********************************************************************
        //**********************************************************************
        // Finalize the dll. Finalize resources and terminate threads. This
        // must be called before the process termination section force
        // terminates any running threads. Return true if successful.

        [DllImport(cDLLName)]
        public static extern bool finalizeBackEnd();

        //**********************************************************************
        //**********************************************************************
        //**********************************************************************
        // Get the current status. This is passed in a status record which
        // is filled with the current status. The record must first be
        // created by the caller. 

        [DllImport(cDLLName)]
        public static extern int getBackEndStatus();
    };
}