using System;
using System.Collections.Generic;
using WeCotation.domain.Matieres.Domain;
/// <summary>
/// This file was generated by the yeoman generator "generator-micros"
/// @author: Ambert Jean-Christophe
/// @email: jc.ambert@free.fr
/// @created_on: Sun May 10 2020 20:32:31 GMT+0200 (GMT+02:00)
/// </summary>
namespace WeCotation.domain.TypeMatieres.Messages.Events
{
    public class TypeMatiereUpdated : TypeMatiereCreated
    {
        public TypeMatiereUpdated(Guid id,string ?nom,float densite,List<Matiere> matieres) 
        : base(id,?nom,densite,matieres)
        {
        }
    }
}
