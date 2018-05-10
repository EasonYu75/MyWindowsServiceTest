using MyWindowsServiceTest.Schedulers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace MyWindowsServiceTest
{
    public partial class WindowsServiceTest : ServiceBase
    {
        private TestScheduler _TestScheduler = new TestScheduler();

        public WindowsServiceTest()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            _TestScheduler.Start();
        }

        protected override void OnStop()
        {
            if (_TestScheduler != null)
            {
                _TestScheduler.Stop();
            }
        }
    }
}
