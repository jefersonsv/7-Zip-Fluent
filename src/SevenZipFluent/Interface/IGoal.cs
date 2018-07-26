using System;
using System.Collections.Generic;
using System.Text;

namespace SevenZipFluent.Interface
{
    interface IGoal
    {
        ICommand CreateSevenCmd();
        ICommand CreateSevenCmd(string sevenZipExecutable);
        ICommand CreateSevenArguments();
    }
}
