using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using EnumsNET;
using SevenZipFluent.Enumeration;

namespace SevenZipFluent
{
    internal class SevenZip
    {
        public Command Command { get; set; }

        public string SevenZipExecutable { get; set; }
        public bool CreateCommandLine { get; set; }
        public bool CreateArguments { get; set; }
        public string ArchiveFilename { get; set; }
        public string ArchivePatternFilter { get; set; }
        //public ExtractCommands ExtractCommands { get; set; }
        public OverwriteMode? OverwriteMode { get; set; }
        public RecursiveMode? RecursiveMode { get; set; }

        /// <summary>
        /// <see cref="https://sevenzip.osdn.jp/chm/cmdline/switches/list_tech.htm"/>
        /// </summary>
        public bool ShowTechnicalInformation { get; set; }
        public bool DisableParsingOfArchive { get; set; }
        public string[] RecursiveWildCards { get; set; }
        public string OutputDirectory { get; set; }

        public string Build()
        {
            StringBuilder sb = new StringBuilder();

            // Create string
            if (this.CreateCommandLine)
            {
                if (string.IsNullOrEmpty(this.SevenZipExecutable))
                    sb.Append(" 7z.exe");
                else
                    sb.Append($" \"{this.SevenZipExecutable}\"");
            }
            else if (this.CreateArguments)
                sb.Append("");
            else
                throw new InvalidOperationException("You must choose between command line or argument");

            // Command
            var cmdAtt = this.Command.GetAttributes().Get<DescriptionAttribute>();
            sb.Append(" " + cmdAtt.Description);

            // Disable Archiving?
            if (this.DisableParsingOfArchive)
                sb.Append(" -an");

            // Show technical information
            if (this.ShowTechnicalInformation)
                sb.Append(" -slt");

            // Archive filename
            if (!string.IsNullOrEmpty(this.ArchiveFilename))
                sb.Append($" \"{this.ArchiveFilename}\"");

            // Overwrite?
            if (this.OverwriteMode != null)
            {
                var ov = this.OverwriteMode.Value
                    .GetAttributes()
                    .Get<DescriptionAttribute>();
                sb.Append(" " + ov.Description);
            }

            // Output directory?
            if (!string.IsNullOrEmpty(this.OutputDirectory))
            {
                sb.Append($" -o\"{this.OutputDirectory.Trim()}\"");
            }

            // Filter archive pattern
            if (!string.IsNullOrEmpty(this.ArchivePatternFilter))
            {
                sb.Append($" {this.ArchivePatternFilter.Trim()}");
            }

            // Recursive 
            if (this.RecursiveMode != null)
            {
                var att = this.RecursiveMode.Value.GetAttributes().Get<DescriptionAttribute>();
                sb.Append(" " + att.Description);

                if (this.RecursiveWildCards != null)
                    foreach (var item in this.RecursiveWildCards)
                        sb.Append($" {item}");
            }

            return sb.ToString().Trim();
        }
    }
    ///// <summary>
    ///// <see cref="https://sevenzip.osdn.jp/chm/cmdline/commands/extract.htm"/>
    ///// </summary>
    //public enum ExtractCommands
    //{
    //    /// <summary>
    //    /// <see cref="https://sevenzip.osdn.jp/chm/cmdline/switches/ar_include.htm"/>
    //    /// </summary>
    //    [Description("-ai")]
    //    IncludeArchives,

    //    /// <summary>
    //    /// <see cref="https://sevenzip.osdn.jp/chm/cmdline/switches/ar_exclude.htm"/>
    //    /// </summary>
    //    [Description("-ax")]
    //    ExcludeArchives,

    //    /// <summary>
    //    /// <see cref="https://sevenzip.osdn.jp/chm/cmdline/switches/include.htm"/>
    //    /// </summary>
    //    [Description("-i")]
    //    Include,

    //    /// <summary>
    //    /// <see cref="https://sevenzip.osdn.jp/chm/cmdline/switches/method.htm"/>
    //    /// </summary>
    //    [Description("-m")]
    //    Method,

    //    /// <summary>
    //    /// <see cref="https://sevenzip.osdn.jp/chm/cmdline/switches/password.htm"/>
    //    /// </summary>
    //    [Description("-p")]
    //    Password,

    //    /// <summary>
    //    /// <see cref="https://sevenzip.osdn.jp/chm/cmdline/switches/stdin.htm"/>
    //    /// </summary>
    //    [Description("-si")]
    //    UseSrdIn,

    //    /// <summary>
    //    /// <see cref="https://sevenzip.osdn.jp/chm/cmdline/switches/sni.htm"/>
    //    /// </summary>
    //    [Description("-sni")]
    //    StoreNTSecurityInformation,

    //    /// <summary>
    //    /// <see cref="https://sevenzip.osdn.jp/chm/cmdline/switches/sns.htm"/>
    //    /// </summary>
    //    [Description("-sns")]
    //    StoreNTFSAlternateStreams,

    //    /// <summary>
    //    /// <see cref="https://sevenzip.osdn.jp/chm/cmdline/switches/stdout.htm"/>
    //    /// </summary>
    //    [Description("-so")]
    //    UseStdOut,

    //    /// <summary>
    //    /// <see cref="https://sevenzip.osdn.jp/chm/cmdline/switches/spf.htm"/>
    //    /// </summary>
    //    [Description("-spf")]
    //    UseQualifiedFilePath,

    //    /// <summary>
    //    /// <see cref="https://sevenzip.osdn.jp/chm/cmdline/switches/type.htm"/>
    //    /// </summary>
    //    [Description("-t")]
    //    TypeOfArchive,

    //    /// <summary>
    //    /// <see cref="https://sevenzip.osdn.jp/chm/cmdline/switches/exclude.htm"/>
    //    /// </summary>
    //    [Description("-x")]
    //    Exclude,

    //    /// <summary>
    //    /// <see cref="https://sevenzip.osdn.jp/chm/cmdline/switches/yes.htm"/>
    //    /// </summary>
    //    [Description("-y")]
    //    AssumeYesAllQueries
    //}
}
