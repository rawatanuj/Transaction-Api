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
            client.BaseAddress = new Uri("http://40.88.220.221");
            return client;
        }

        public HttpClient RuleApi()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://52.224.84.160");
            return client;
        }
    }
}
