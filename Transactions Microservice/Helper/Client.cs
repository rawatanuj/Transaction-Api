using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Transactions_Microservice.Helper
{
    public class Client
    {
        public HttpClient AccountDetails()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://52.224.198.245");
            return client;
        }

        public HttpClient RuleApi()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://40.76.163.146");
            return client;
        }
    }
}
