using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace task2
{
    public class CSVFileHandler : IFileHandler
    {
        public virtual List<int> readNumbers(String fileName)
        {
            StreamReader reader = new StreamReader(fileName);

            String line;
            List<int> res = new List<int>();

            while ((line = reader.ReadLine()) != null) {
                String[] numbers = line.Split(',');

                foreach (String s in numbers) {
                    res.Add(Int32.Parse(s));
                }
            }

            reader.Close();

            return res;
        }

        public virtual void writeNumbers(String fileName, List<int> numbers)
        {
            StreamWriter writer = new StreamWriter(fileName);

            writer.Write(String.Join(",", numbers));

            writer.Close();
        }
    }
}

