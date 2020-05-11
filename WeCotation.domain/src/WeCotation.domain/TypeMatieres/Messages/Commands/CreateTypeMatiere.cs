using System;
/// <summary>
/// This file was generated by the yeoman generator "generator-micros"
/// @author: Ambert Jean-Christophe
/// @email: jc.ambert@free.fr
/// @created_on: Sun May 10 2020 20:32:31 GMT+0200 (GMT+02:00)
/// </summary>
namespace WeCotation.domain.TypeMatieres.Messages.Commands
{

    public class CreateTypeMatiere : TypeMatiereBaseCommand
    {
        
        public override Guid Id { get; set; }
        
        public string  Nom{get;}
        public float  Densite{get;}
        public other  Matiere{get;}
        



        public CreateTypeMatiere(Guid id,string ?nom ,float densite ,other matiere ) : base()
        {
            
            Id = id;
            
            Nom = ?nom ;
            Densite = densite ;
            Matiere = matiere ;
            
        }
    }
}