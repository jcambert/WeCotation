using MicroS_Common.Controllers;
using MicroS_Common.Dispatchers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace WeCotation.Services.Cotation.Controllers
{
    [Route("")]
    public class HomeController: BaseController
    {
        public HomeController(IDispatcher dispatcher,IConfiguration config):base(dispatcher,config)
        {

        }
    }
}
