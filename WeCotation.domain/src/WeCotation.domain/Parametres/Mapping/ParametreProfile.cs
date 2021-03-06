using AutoMapper;
using WeCotation.domain.Parametres.Domain;
using WeCotation.domain.Parametres.Dto;

using WeCotation.domain.Parametres.Messages.Commands;
using WeCotation.domain.Parametres.Messages.Events;

/// <summary>
/// This file was generated by the yeoman generator "generator-micros"
/// @author: Ambert Jean-Christophe
/// @email: jc.ambert@free.fr
/// @created_on: Fri May 15 2020 14:01:25 GMT+0200 (GMT+02:00)
/// </summary>
namespace WeCotation.domain.Parametres.Mapping
{
    public class ParametreProfile:Profile
    {
        public ParametreProfile()
        {
            CreateMap<Parametre, ParametreDto>();//.ConstructUsing(e => new ParametreDto() { Id = e.Id,Code = e.Code,Nom = e.Nom,Type = e.Type,Aide = e.Aide  });
            
            CreateMap<CreateParametre, Parametre>();//.ConstructUsing(e => new Parametre(e.Id,e.Code,e.Nom,e.Type,e.Aide));
            CreateMap<CreateParametre, ParametreCreated>();//.ConstructUsing(e => new ParametreCreated(e.Id,e.Code,e.Nom,e.Type,e.Aide));
            CreateMap<UpdateParametre, ParametreUpdated>();//.ConstructUsing(e => new ParametreUpdated(e.Id,e.Code,e.Nom,e.Type,e.Aide));
            CreateMap<DeleteParametre, ParametreDeleted>();//.ConstructUsing(e => new ParametreDeleted(e.Id));            
            
        }
    }
}
