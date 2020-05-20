using AutoMapper;
using MicroS_Common.Handlers;
using MicroS_Common.Mongo;
using System.Threading.Tasks;
using WeCotation.domain.Parametres.Dto;
using WeCotation.domain.Parametres.Queries;
using WeCotation.Services.Repositories;

/// <summary>
/// This file was generated by the yeoman generator "generator-micros"
/// @author: Ambert Jean-Christophe
/// @email: jc.ambert@free.fr
/// @created_on: Fri May 15 2020 14:01:25 GMT+0200 (GMT+02:00)
/// </summary>
namespace WeCotation.Services.Parametres.Handlers
{
    /// <summary>
    /// Get Parametre Handler
    /// </summary>
    public partial class GetParametreHandler :  IQueryHandler<GetParametre, ParametreDto>
    {
        

        #region Constructors
        public GetParametreHandler(
            IBrowseParametreRepository repository,
             IMapper mapper)
        {
            Repository = repository;
            Mapper = mapper;
        }
        #endregion

        #region public properties
        public IBrowseParametreRepository Repository{get;}
        public IMapper Mapper{get;}
        #endregion

        #region public functions
        /// <summary>
        ///  Handle the command with context
        /// </summary>
        /// <param name="command">The command to handle</param>
        /// <param name="context">The correlation context</param>
        /// <returns></returns>
        public async Task<ParametreDto> HandleAsync(GetParametre query)
        {
            var model = await Repository.GetAsync(query.Id);

            return model == null ? null : Mapper.Map<ParametreDto>(model);

        }
        #endregion
    }
}