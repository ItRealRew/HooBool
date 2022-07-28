using System;
using System.Threading.Tasks;

namespace WebAssemblyBlazorChromeExtension.Services
{
    public class StopWatch
    {
        DateTime startedTime;

        public void StartTime() => startedTime = DateTime.Now;

        public string GetCurrentTime() => new DateTime(DateTime.Now.Subtract(startedTime).Ticks).ToString("mm:ss");
    }
}