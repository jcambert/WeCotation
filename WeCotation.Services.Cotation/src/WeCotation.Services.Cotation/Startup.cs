using MicroS_Common.Services.Service;
using Microsoft.Extensions.Configuration;
using System;
using WeCotation.domain;

namespace WeCotation.Services.Cotation
{
    public class Startup : ServiceStartup
    {
        public Startup(IConfiguration configuration) : base(configuration)
        {
        }

        protected override Type DomainType =>typeof(DomainProfile);
    }
}
