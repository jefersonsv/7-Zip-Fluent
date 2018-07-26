using System;
using System.Collections.Generic;
using System.Text;
using SevenZipFluent.Enumeration;

namespace SevenZipFluent.Interface
{
    public interface IArgument
    {
        IArgument Archive(string filename);
        IArgument OutputDirectory(string path);
        IArgument OverwriteMode(OverwriteMode overwriteMode);
        IArgument RecursiveMode(RecursiveMode recursiveMode);
        IArgument RecursiveMode(RecursiveMode recursiveMode, string[] wildCards);
        string Build();
    }
}
