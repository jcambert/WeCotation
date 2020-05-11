using AutoMapper;
using MicroS_Common.Handlers;
using MicroS_Common.RabbitMq;
using MicroS_Common.Repository;
using MicroS_Common.Types;
using System.Threading.Tasks;
using WeCotation.domain.TypeMatieres.Domain;
using WeCotation.domain.TypeMatieres.Messages.Commands;
using WeCotation.domain.TypeMatieres.Messages.Events;
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
    /// Update TypeMatiere Handler
    /// </summary>
    public partial class UpdateTypeMatiereHandler : DomainCommandHandler<UpdateTypeMatiere, TypeMatiere>
    {
        #region Constructors
        public UpdateTypeMatiereHandler(
            IBusPublisher busPublisher, 
            IMapper mapper, 
            IBrowseTypeMatiereRepository repo) : base(busPublisher, mapper, repo)
        {
        }
        #endregion
        #region Protected Overrides functions
        /// <summary>
        /// Check if the model exist by Command
        /// </summary>
        /// <param name="command">The command in wich information can be use do check if the model exist in database</param>
        /// <returns>Nothing</returns>
        protected override async Task CheckExist(TypeMatiere domain)
        {
            if (!await Repository.ExistsAsync(domain.Id))
            {
                throw new MicroSException("product_not_found",$"TypeMatiere with id: '{domain.Id}' was not found.");
            }
        }
        #endregion
        #region Public Overrides functions
        /// <summary>
        ///  Handle the command with context
        /// </summary>
        /// <param name="command">The command to handle</param>
        /// <param name="context">The correlation context</param>
        /// <returns></returns>
        public override async Task HandleAsync(UpdateTypeMatiere command, ICorrelationContext context)
        {
            
            await base.HandleAsync(command, context);
            var product = GetDomainObject(command);
            await Repository.UpdateAsync(product);
            await BusPublisher.PublishAsync(CreateEvent<TypeMatiereUpdated>(command), context);
        }
        #endregion
    }
}
