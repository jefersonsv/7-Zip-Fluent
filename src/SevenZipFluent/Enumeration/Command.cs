using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SevenZipFluent.Enumeration
{
    /// <summary>
    /// https://sevenzip.osdn.jp/chm/cmdline/commands/index.htm
    /// </summary>
    public enum Command
    {
        [Description("a")]
        Add,
        [Description("b")]
        Benchmark,
        [Description("d")]
        Delete,

        /// <summary>
        /// https://sevenzip.osdn.jp/chm/cmdline/commands/extract.htm
        /// </summary>
        [Description("e")]
        Extract,

        [Description("h")]
        Hash,
        [Description("i")]
        Information,
        [Description("l")]
        List,
        [Description("rn")]
        Rename,
        [Description("t")]
        Test,
        [Description("u")]
        Update,
        [Description("x")]
        ExtractFullPath,
    }
}
