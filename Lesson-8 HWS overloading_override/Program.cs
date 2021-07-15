using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8_HWS_overloading_override
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Qst 8

            Computer c = new Computer();
            SmartComp sc = new SmartComp();
            c.TurnOff(); //2 Options
            sc.TurnOff();//3 Options

            #endregion
        }



    }
}