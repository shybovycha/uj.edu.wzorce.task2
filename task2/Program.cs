using System;

namespace task2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            ArgumentsParser argvParser = new ArgumentsParser(args);

            argvParser.parse();

            DefaultWorker worker = WorkerBuilder.build(argvParser.fileType, argvParser.sortingAlgorithm);

            worker.process(argvParser.inputFile, argvParser.outputFile);
        }
    }
}
