using Quartz;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NetCore_Quartz
{
    public class HelloJob : IJob
    {
        public async Task Execute(IJobExecutionContext context)
        {
            await Console.Out.WriteLineAsync($"{DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")} - Greetings from I Love my job!");
        }
    }
}
