using System;
using System.Collections.Generic;
using System.Text;

namespace SevenZipFluent.Interface
{
    public interface ICommand
    {
        IArgument Add();
        IArgument Benchmark();
        IArgument Delete();
        IArgument Extract();
        IArgument Hash();
        IArgument Information();
        IArgument List();
        IArgument Rename();
        IArgument Test();
        IArgument Update();
        IArgument ExtractFullPath();
    }
}
