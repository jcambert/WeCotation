using AutoMapper;
using MicroS_Common.Handlers;
using MicroS_Common.Mongo;
using System.Threading.Tasks;
using WeCotation.domain.TypeMatieres.Dto;
using WeCotation.domain.TypeMatieres.Queries;
using WeCotation.Services.Repositories;

/// <summary>
/// This file was generated by the yeoman generator "generator-micros"
/// @author: Ambert Jean-Christophe
/// @email: jc.ambert@free.fr
/// @created_on: Sun May 10 2020 15:33:43 GMT+0200 (GMT+02:00)
/// </summary>
namespace WeCotation.Services.TypeMatieres.Handlers
{
    /// <summary>
    /// Get TypeMatiere Handler
    /// </summary>
    public partial class GetTypeMatiereHandler :  IQueryHandler<GetTypeMatiere, TypeMatiereDto>
    {
        

        #region Constructors
        public GetTypeMatiereHandler(
            IBrowseTypeMatiereRepository repository,
             IMapper mapper)
        {
            Repository = repository;
            Mapper = mapper;
        }
        #endregion

        #region public properties
        public IBrowseTypeMatiereRepository Repository{get;}
        public IMapper Mapper{get;}
        #endregion

        #region public functions
        /// <summary>
        ///  Handle the command with context
        /// </summary>
        /// <param name="command">The command to handle</param>
        /// <param name="context">The correlation context</param>
        /// <returns></returns>
        public async Task<TypeMatiereDto> HandleAsync(GetTypeMatiere query)
        {
            var model = await Repository.GetAsync(query.Id);

            return model == null ? null : Mapper.Map<TypeMatiereDto>(model);

        }
        #endregion
    }
}