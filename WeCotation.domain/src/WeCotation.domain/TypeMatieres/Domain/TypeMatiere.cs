using System;
using System.Collections.Generic;
using MicroS_Common.Types;
using MicroS_Common.Mongo;

using WeCotation.domain.Matieres.Domain;

/// <summary>
/// This file was generated by the yeoman generator "generator-micros"
/// @author: Ambert Jean-Christophe
/// @email: jc.ambert@free.fr
/// @created_on: Sun May 10 2020 20:32:31 GMT+0200 (GMT+02:00)
/// </summary>
namespace WeCotation.domain.TypeMatieres.Domain
{
    [MongoDocument("typematiere")]
    public class TypeMatiere  :BaseEntity
    {
        #region private variables
        
            private ISet<Matiere> _Matiere=new HashSet<Matiere>();
        
        #endregion


        #region public properties
        
        public string Nom {get;set;} 
        
        public float Densite {get;set;} 
        
        
            public IEnumerable<Matiere> Matieres{
                get=>_Matiere;
                set=>_Matiere=new HashSet<Matiere>(value);
            }
        
        #endregion

        #region Constructeur
        public TypeMatiere():base(){}
        
        public TypeMatiere(string ?nom,float densite)
            : base()
        {
             
            Nom = ?nom; 
            Densite = densite;
        }
        
        #endregion
        #region public functions
        #endregion

    }
}
