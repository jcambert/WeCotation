using System;

using System.Collections.Generic;
using WeCotation.domain.Tarifs.Domain;
using WeCotation.domain.Nomenclatures.Domain;
using WeCotation.domain.Operations.Domain;

/// <summary>
/// This file was generated by the yeoman generator "generator-micros"
/// @author: Ambert Jean-Christophe
/// @email: jc.ambert@free.fr
/// @created_on: Wed May 13 2020 11:51:54 GMT+0200 (GMT+02:00)
/// </summary>
namespace WeCotation.domain.Articles.Messages.Commands
{
    public class UpdateArticle : CreateArticle
    {
        
        public UpdateArticle(Guid id,string code,string designation,string indice,string plan,float prix,float densite,int txprep,float txope,float tpprep,float tpope,float tpbase,string type,List<Tarif> tarifs,List<Nomenclature> nomenclatures,List<Operation> operations) : base(id,code,designation,indice,plan,prix,densite,txprep,txope,tpprep,tpope,tpbase,type,tarifs,nomenclatures,operations)
        {
        }
    }
}
