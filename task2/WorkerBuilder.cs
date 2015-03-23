using System;

namespace task2
{
    public class WorkerBuilder
    {
        public static DefaultWorker build(String fileType, String sortingMethod)
        {
            IFileHandler fileHandler = createFileHandler(fileType);
            ISorter sorter = createSorter(sortingMethod);

            return new DefaultWorker(fileHandler, sorter);
        }

        protected static IFileHandler createFileHandler(String fileType)
        {
            if (fileType == "csv") {
                return new CSVFileHandler();
            } else if (fileType == "json") {
                return new JSONFileHandler();
            } else {
                throw new ArgumentException(String.Format("Unrecognized file type: {0}", fileType));
            }
        }

        protected static ISorter createSorter(String sortingMethod)
        {
            if (sortingMethod == "insertion") {
                return new InsertionSorter();
            } else if (sortingMethod == "count") {
                return new CountSorter();
            } else {
                throw new ArgumentException(String.Format("Unrecognized sorting method: {0}", sortingMethod));
            }
        }
    }
}
