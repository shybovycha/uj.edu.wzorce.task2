using System;
using System.Collections.Generic;

namespace task2
{
    public class ArgumentsParser
    {
        private string[] args;
        public String inputFile, outputFile, fileType, sortingAlgorithm;

        public ArgumentsParser(string[] args)
        {
            this.args = args;
        }

        public void parse()
        {
            if (args.Length < 4) {
                throw new ArgumentException("Invalid arguments. Expected: [input file] [output file] [csv|json] [insertion|count]");
            }

            this.inputFile = args[0];
            this.outputFile = args[1];
            this.fileType = args[2];
            this.sortingAlgorithm = args[3];
        }
    }
}

