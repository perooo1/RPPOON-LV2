using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPOON_LV2
{
    ///////////////////////////////////////////////////////////  Z4
    /*
    class FileLogger:ILogger
    {
        string filePath;

        public FileLogger(string filePath)
        {
            this.FilePath = filePath;
        }

        public string FilePath { get => filePath; private set => filePath = value; }

        public void Log(string message)
        {
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter(this.filePath))
            {
                writer.WriteLine(message);
            }
        }
    }
    */
    ///////////////////////////////////////////////////////////  Z5
    
    class FileLogger : ILogger
    {
        string filePath;

        public FileLogger(string filePath)
        {
            this.FilePath = filePath;
        }

        public string FilePath { get => filePath; private set => filePath = value; }

        public void Log(ILogable data)
        {
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter(this.filePath))
            {
                writer.WriteLine(data.GetStringRepresentation());
            }
        }
    }
    
}
