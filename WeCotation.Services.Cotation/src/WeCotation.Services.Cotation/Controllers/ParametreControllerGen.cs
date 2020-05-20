#region using
using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MicroS_Common.Types;
using MicroS_Common.Controllers;
using MicroS_Common.Dispatchers;
using WeCotation.domain.Parametres.Dto;
using WeCotation.domain.Parametres.Queries;
using Microsoft.Extensions.Configuration;
#endregion

/// <summary>
/// This file was generated by the yeoman generator "generator-micros"
/// @author: Ambert Jean-Christophe
/// @email: jc.ambert@free.fr
/// @created_on: Fri May 15 2020 14:01:25 GMT+0200 (GMT+02:00)
/// </summary>
namespace WeCotation.Services.Parametres.Controllers
{
    [Route("parametres")]
    public partial class ParametresController : BaseController
    {
        public ParametresController(IDispatcher dispatcher,IConfiguration config) : base(dispatcher,config)
        {
        }

        [HttpGet("")]
        public async Task<ActionResult<PagedResult<ParametreDto>>> Get([FromQuery] BrowseParametres query)
            => Collection(await QueryAsync(query));

        [HttpGet("{id}")]
        public async Task<ActionResult<ParametreDto>> Get([FromRoute] GetParametre query)
            => Single(await QueryAsync(query));
        
        
    }
}