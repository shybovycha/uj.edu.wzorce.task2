using System;
using System.Collections.Generic;

namespace task2
{
    public interface IFileHandler
    {
        List<int> readNumbers(String fileName);

        void writeNumbers(String fileName, List<int> numbers);
    }
}

