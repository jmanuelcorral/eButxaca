using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace eButxaca.OWIN.Service
{
    public partial class Service1 : ServiceBase
    {

         
        string baseAddress = "http://localhost:9000/";
        private IDisposable app;
            
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            app = eButxaca.API.Bootstrapper.Init(baseAddress);
        }

        protected override void OnStop()
        {
            app.Dispose();
        }
    }
}
