using System;
/// <summary>
/// This file was generated by the yeoman generator "generator-micros"
/// @author: Ambert Jean-Christophe
/// @email: jc.ambert@free.fr
/// @created_on: Sun May 10 2020 20:32:31 GMT+0200 (GMT+02:00)
/// </summary>
namespace WeCotation.domain.TypeMatieres.Messages.Commands
{
    public class DeleteTypeMatiere: TypeMatiereBaseCommand
    {
        
        public override Guid Id { get; set; }
        public DeleteTypeMatiere(Guid id) : base()
        {
            this.Id = id;
        }
        

    }
}