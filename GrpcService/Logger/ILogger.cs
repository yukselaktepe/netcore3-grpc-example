using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrpcService.Logger
{
    public interface ILogger
    {
        void Log(string logName, string message, string path = "");
    }
}
