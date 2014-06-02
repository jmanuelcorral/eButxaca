using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eButxaca.API
{
    public static class Bootstrapper
    {

        public static IDisposable Init(string baseAddress)
        {
            return WebApp.Start<Startup>(url: baseAddress);
        }

    }
}
