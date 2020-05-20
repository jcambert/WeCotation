using System;

/// <summary>
/// This file was generated by the yeoman generator "generator-micros"
/// @author: Ambert Jean-Christophe
/// @email: jc.ambert@free.fr
/// @created_on: Fri May 15 2020 14:01:25 GMT+0200 (GMT+02:00)
/// </summary>
namespace WeCotation.domain.Parametres.Messages.Commands
{

    public class CreateParametre : ParametreBaseCommand
    {
        
        public override Guid Id { get; set; }
        
        public string Code {get;}
public string Nom {get;}
public string Type {get;}
public string Aide {get;}
        



        public CreateParametre(
            Guid id,string code,string nom,string type,string aide) : base()
        {
            
            Id = id;
            
            Code =code; 
Nom =nom; 
Type =type; 
Aide =aide; 

           
        }
    }
}