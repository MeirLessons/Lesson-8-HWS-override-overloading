using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8_HWS_overloading_override
{
    class Computer
    {
        //Fields - Members
        public string[] allOpenFiles;//File Explorer, Visual Studio
        public bool isTurnOn;

        //Constructors - Ctors
        public Computer()
        {

        }

        public Computer(string[] allFiles)
        {
            isTurnOn = true;
            allOpenFiles = allFiles;
        }

        //Methods
        public void TurnOff()
        {
            allOpenFiles = null;
            isTurnOn = false;
        }

        public void TurnOff(bool forceOff)
        {
            if(allOpenFiles == null)
            {
                TurnOff();
            }
            else
            {
                Console.WriteLine("Are You Sure? y-n");
                string answer = Console.ReadLine();
                if(answer.ToLower() == "y")
                {
                    TurnOff();
                }

            }
        }

    }
}
