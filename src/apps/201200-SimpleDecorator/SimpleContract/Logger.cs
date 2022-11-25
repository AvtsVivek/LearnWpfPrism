using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleContract
{

    public interface ILogger
    {
        void Log(string line);
    }

    public class InMemoryLogger : ILogger
    {
        public readonly List<string> Lines = new List<string>();
        public void Log(string line) => Lines.Add(line);
    }
}
