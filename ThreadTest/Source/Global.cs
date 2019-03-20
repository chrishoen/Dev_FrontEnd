using System;
using System.Text;

namespace Some
{
    //******************************************************************************
    //******************************************************************************
    //******************************************************************************
    // ProtoComm global object

    public class Global
    {
        //******************************************************************************
        // Members.

        public static Some.TimerThread  mTimerThread;

        //******************************************************************************
        // Initialize.

        public static void initialize()
        {
            mTimerThread = new Some.TimerThread();
            mTimerThread.start();
        }

        //******************************************************************************
        // Finalize.

        public static void finalize()
        {
            mTimerThread.stop();
        }
    };
}
