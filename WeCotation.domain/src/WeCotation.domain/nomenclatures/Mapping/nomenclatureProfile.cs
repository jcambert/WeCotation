using AutoMapper;
using WeCotation.domain.Nomenclatures.Domain;
using WeCotation.domain.Nomenclatures.Dto;

/// <summary>
/// This file was generated by the yeoman generator "generator-micros"
/// @author: Ambert Jean-Christophe
/// @email: jc.ambert@free.fr
/// @created_on: Wed May 13 2020 12:00:12 GMT+0200 (GMT+02:00)
/// </summary>
namespace WeCotation.domain.Nomenclatures.Mapping
{
    public class NomenclatureProfile:Profile
    {
        public NomenclatureProfile()
        {
            this.AllowNullCollections = false;
            this.AllowNullDestinationValues = false;
            CreateMap<Nomenclature, NomenclatureDto>();//.ConstructUsing(e => new NomenclatureDto() {Code = e.Code,Operation = e.Operation,Quantite = e.Quantite  });
            
        }
    }
}