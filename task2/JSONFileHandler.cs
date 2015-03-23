using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;

namespace task2
{
    public class NumbersFile
    {
        public List<int> numbers;
    }

    public class JSONFileHandler : IFileHandler
    {
        public virtual List<int> readNumbers(String fileName)
        {
            StreamReader reader = new StreamReader(fileName);

            var obj = JsonConvert.DeserializeObject<NumbersFile>(reader.ReadToEnd());
            List<int> res = new List<int>();

            foreach (int n in obj.numbers) {
                res.Add(n);
            }

            reader.Close();

            return res;
        }

        public virtual void writeNumbers(String fileName, List<int> numbers)
        {
            JsonTextWriter writer = new JsonTextWriter(new StreamWriter(fileName));

            writer.WriteStartObject();
            // writer.WriteLine(JsonConvert.SerializeObject(res));
            writer.WritePropertyName("numbers");
            writer.WriteStartArray();

            foreach (int s in numbers) {
                writer.WriteValue(s);
            }

            writer.WriteEndObject();

            writer.Close();
        }
    }
}

