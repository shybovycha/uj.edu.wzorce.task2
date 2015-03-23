using System;
using System.Collections.Generic;
using System.Xml;

namespace task2
{
    public class XMLFile : IFileFormat
    {
        String fileName;

        public XMLFile(String fileName)
        {
            this.fileName = fileName;
        }

        public List<int> readNumbers()
        {

        }
    }
}

