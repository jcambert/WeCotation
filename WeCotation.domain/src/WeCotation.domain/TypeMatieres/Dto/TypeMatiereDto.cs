using System;
using System.Collections.Generic;

using WeCotation.domain.Matieres.Domain;

/// <summary>
/// This file was generated by the yeoman generator "generator-micros"
/// @author: Ambert Jean-Christophe
/// @email: jc.ambert@free.fr
/// @created_on: Sun May 10 2020 20:32:31 GMT+0200 (GMT+02:00)
/// </summary>
namespace WeCotation.domain.TypeMatieres.Dto
{
    public class TypeMatiereDto
    {

        #region private variables
        
            private ISet<Matiere> _Matiere=new HashSet<Matiere>();
        
        #endregion

        #region public properties
        
         public Guid Id { get; set; }
        
        
        public string Nom  {get;set;}
        
        public float Densite  {get;set;}
        
        
            public IEnumerable<Matiere> Matieres{
                get=>_Matiere;
                set=>_Matiere=new HashSet<Matiere>(value);
            }
        
        #endregion


    }
}
