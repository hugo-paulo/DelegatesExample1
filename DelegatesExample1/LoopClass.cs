using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading;

namespace DelegatesExample1
{
    //Signalton pattern
    public sealed class LoopClass
    {
        //This is a Delegate declaration.
        //Difference between Task and Action, Action like void type has not return type. Task has a return type (ie return string, object, etc...)
        private static Action _LoopEndMessage;
        private static int _loopLength;

        
        //Note optional parameters must be listed last
        public LoopClass(Action LoopEndMessage, int loopLength = 0)
        {
            _loopLength = loopLength;

            //This will hold the function we pass we initialise this class in the Program class in main
            _LoopEndMessage = LoopEndMessage; 
        }

        public void RunLoop()
        {
            for (int i = 0; i < _loopLength; i++)
            {
                Console.WriteLine(i);
            }

            //Call the Delegqate function
            _LoopEndMessage();
        }        
        
    }
}
