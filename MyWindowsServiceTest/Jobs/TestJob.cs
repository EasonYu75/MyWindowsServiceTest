using NLog;
using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWindowsServiceTest.Jobs
{
    class TestJob : IJob
    {
        Logger logger = LogManager.GetCurrentClassLogger();

        public Task Execute(IJobExecutionContext context)
        {
            // TODO
            logger.Error("TestJob execute success.");

            return Task.FromResult(true);
        }
    }
}
