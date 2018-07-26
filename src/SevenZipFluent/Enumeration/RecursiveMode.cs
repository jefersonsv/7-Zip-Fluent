using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SevenZipFluent.Enumeration
{
    /// <summary>
    /// <see cref="https://sevenzip.osdn.jp/chm/cmdline/switches/recurse.htm"/>
    /// </summary>
    public enum RecursiveMode
    {
        [Description("-r")]
        EnableRecursive,

        [Description("-r-")]
        DisableRecursive,
    }
}
