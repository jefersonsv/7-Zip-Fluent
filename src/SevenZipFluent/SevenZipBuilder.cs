using System;
using System.Collections.Generic;
using System.Text;
using SevenZipFluent.Enumeration;
using SevenZipFluent.Interface;

namespace SevenZipFluent
{
    public sealed class SevenZipBuilder : IGoal, ICommand, IArgument
    {
        readonly SevenZip _instance = new SevenZip();

        public ICommand CreateSevenCmd()
        {
            _instance.CreateCommandLine = true;
            return this;
        }

        public ICommand CreateSevenCmd(string sevenZipExecutable)
        {
            _instance.SevenZipExecutable = sevenZipExecutable;
            return this;
        }

        public ICommand CreateSevenArguments()
        {
            _instance.CreateArguments = true;
            return this;
        }

        public IArgument Add()
        {
            _instance.Command = Command.Add;
            return this;
        }

        public IArgument Benchmark()
        {
            _instance.Command = Command.Benchmark;
            return this;
        }

        public IArgument Delete()
        {
            _instance.Command = Command.Delete;
            return this;

        }

        public IArgument Extract()
        {
            _instance.Command = Command.Extract;
            return this;
        }

        public IArgument Hash()
        {
            _instance.Command = Command.Hash;
            return this;
        }

        public IArgument Information()
        {
            _instance.Command = Command.Information;
            return this;
        }

        public IArgument List()
        {
            _instance.Command = Command.List;
            return this;
        }

        public IArgument Rename()
        {
            _instance.Command = Command.Rename;
            return this;
        }

        public IArgument Test()
        {
            _instance.Command = Command.Test;
            return this;
        }

        public IArgument Update()
        {
            _instance.Command = Command.Update;
            return this;
        }

        public IArgument ExtractFullPath()
        {
            _instance.Command = Command.ExtractFullPath;
            return this;
        }

        public IArgument File(string filename)
        {
            _instance.ArchiveFilename = filename;
            return this;
        }

        public IArgument Archive(string filename)
        {
            _instance.ArchiveFilename = filename;
            return this;
        }

        public IArgument OutputDirectory(string path)
        {
            _instance.OutputDirectory = path;
            return this;
        }

        public IArgument OverwriteMode(OverwriteMode overwriteMode)
        {
            _instance.OverwriteMode = overwriteMode;
            return this;
        }

        public IArgument RecursiveMode(RecursiveMode recursiveMode)
        {
            _instance.RecursiveMode = recursiveMode;
            return this;
        }

        public IArgument RecursiveMode(RecursiveMode recursiveMode, string[] wildCards)
        {
            _instance.RecursiveMode = recursiveMode;
            _instance.RecursiveWildCards = wildCards;
            return this;
        }

        public string Build()
        {
            return _instance.Build();
        }
    }
}
