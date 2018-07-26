using System;
using System.Collections.Generic;
using System.Text;
using SevenZipFluent.Enumeration;
using SevenZipFluent.Interface;

namespace SevenZipFluent
{
    public static class Builder
    {
        static SevenZipBuilder __args = new SevenZipBuilder();
        static SevenZipBuilder __cmd = new SevenZipBuilder();

        public static SevenZipBuilder Argument
        {
            get { return __args; }
        }

        public static SevenZipBuilder CommandLine
        {
            get { return __cmd; }
        }
    }
}