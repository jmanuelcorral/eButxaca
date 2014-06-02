using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eButxaca.OWIN.Hosting
{
    class Program
    {
        static void Main(string[] args){
            
            string baseAddress = "http://localhost:9000/";
            using (eButxaca.API.Bootstrapper.Init(baseAddress))
            {
                Console.Write("Servidor web Iniciado en "+ baseAddress);
                Console.ReadKey();
            }
             
        }
    }
}
