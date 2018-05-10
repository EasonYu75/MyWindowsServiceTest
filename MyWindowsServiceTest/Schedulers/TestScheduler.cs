using MyWindowsServiceTest.Jobs;
using Quartz;
using Quartz.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWindowsServiceTest.Schedulers
{
    class TestScheduler 
    {
        public void Start()
        {
            IScheduler scheduler = StdSchedulerFactory.GetDefaultScheduler().Result;
            scheduler.Start();

            IJobDetail job = JobBuilder.Create<TestJob>().Build();

            ITrigger trigger = TriggerBuilder.Create()
                   .WithSimpleSchedule(a => a.WithIntervalInMinutes(1).RepeatForever())
                   .Build();

            scheduler.ScheduleJob(job, trigger);
        }

        public void Stop()
        {
            IScheduler scheduler = StdSchedulerFactory.GetDefaultScheduler().Result;
            scheduler.Shutdown();
        }
    }
}
