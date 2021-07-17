using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session8Assignment
{
    public abstract class Computer
    {
        public abstract string BootUp();
        public abstract string ShutDown();
    }
    
    class SuperComputer : Computer
    {
        public override string BootUp()
        {
            return "Booting up Super Computer";
        }

        public override string ShutDown()
        {
            return "Shutting down Super Computer";
        }
    }
    class MainfraimComputer : Computer
    {
        public override string BootUp()
        {
            return "Booting up Mainfraim Computer";
        }

        public override string ShutDown()
        {
            return "Shutting down Mainfraim Computer";
        }
    }
    class MicroComputers : Computer
    {
        public override string BootUp()
        {
            return "Booting up Micro Computers";
        }

        public override string ShutDown()
        {
            return "Shutting down MicroComputers";
        }
    }
    sealed class Pen : Computer
    {
        public sealed override string BootUp()
        {
            return "Booting up Pen";
        }
        public sealed override string ShutDown()
        {
            return "Shutting down Pen";
        }
        public string StartWriting()
        {
            return "Start writing";
        }
        public string StopWriting()
        {
            return "Stop writing";
        }
    }
}
