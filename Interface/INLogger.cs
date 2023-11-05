using System.Collections.Generic;
using System;

namespace OurTestApi.Interface
{
    public interface INLogger
    {
        void LogInfo(string message);
        void LogError(string message);
    }
}
