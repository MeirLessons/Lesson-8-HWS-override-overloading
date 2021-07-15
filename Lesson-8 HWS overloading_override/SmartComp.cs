using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8_HWS_overloading_override
{
    class SmartComp : Computer
    {
        public string[] filesInCache;

        public void TurnOff(bool force, bool saveFiles)
        {
            if(force)
            {
                if (allOpenFiles == null)
                    TurnOff();
                else
                {
                    if (saveFiles)
                    {
                        filesInCache = allOpenFiles;
                        TurnOff();
                    }
                }
            }
            else
            {
                if (saveFiles)
                {
                    filesInCache = allOpenFiles;
                    TurnOff();
                }
            }
        }
    }
}
