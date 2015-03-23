using System;
using System.Collections.Generic;

namespace task2
{
    public class DefaultWorker
    {
        protected IFileHandler fileHandler;
        protected ISorter sorter;

        public DefaultWorker(IFileHandler fileHandler, ISorter sorter)
        {
            this.fileHandler = fileHandler;
            this.sorter = sorter;
        }

        public void process(String inputFileName, String outputFileName)
        {
            List<int> numbers = this.fileHandler.readNumbers(inputFileName);
            numbers = sorter.sort(numbers);
            this.fileHandler.writeNumbers(outputFileName, numbers);
        }
    }
}

