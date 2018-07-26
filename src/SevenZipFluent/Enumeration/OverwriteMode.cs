using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SevenZipFluent.Enumeration
{
    /// <summary>
    /// <see cref="https://sevenzip.osdn.jp/chm/cmdline/switches/overwrite.htm"/>
    /// </summary>
    public enum OverwriteMode
    {
        [Description("-aoa")]
        OverwriteAll,

        [Description("-aos")]
        SkipExtractExisting,

        [Description("-aou")]
        AutoRenameExtractingFile,

        [Description("-aot")]
        AutoRenameExistingFile
    }
}
