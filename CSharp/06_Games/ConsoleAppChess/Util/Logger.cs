using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppChess.Util
{
    internal class Logger
    {
        private static ILogger _logger;

        private Logger()
        {
            
        }

        public static ILogger GetLogger()
        {
            if (_logger == null)
            {
                string FilePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\ConsoleChess\\";
                if (!Directory.Exists(FilePath))
                {
                    Directory.CreateDirectory(FilePath);
                }

                string FileName = "ChessLog.txt";
                _logger = new LoggerConfiguration()
                    .WriteTo.File(FilePath + FileName)
                    .MinimumLevel.Debug()
                    .CreateLogger();
            }

            return _logger;
        }
    }
}
