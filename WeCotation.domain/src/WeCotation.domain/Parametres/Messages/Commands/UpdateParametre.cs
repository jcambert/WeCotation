using System;

/// <summary>
/// This file was generated by the yeoman generator "generator-micros"
/// @author: Ambert Jean-Christophe
/// @email: jc.ambert@free.fr
/// @created_on: Fri May 15 2020 14:01:25 GMT+0200 (GMT+02:00)
/// </summary>
namespace WeCotation.domain.Parametres.Messages.Commands
{
    public class UpdateParametre : CreateParametre
    {
        
        public UpdateParametre(Guid id,string code,string nom,string type,string aide) : base(id,code,nom,type,aide)
        {
        }
    }
}