using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelismExam1.Console
{
    public class Process
    {
        public async Task<List<string>> GetDataAsync()
        {
            var lines = new List<string>();
            using (var stream = new StreamReader(File.OpenRead(@"data.csv")))
            {
                string line;
                while ((line = await stream.ReadLineAsync()) != null)
                {
                    await Task.Delay(5000);
                    lines.Add(line);
                }
            }

            return lines;
        }
    }
}
