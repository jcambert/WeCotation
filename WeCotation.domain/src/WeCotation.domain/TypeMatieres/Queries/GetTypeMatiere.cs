using MicroS_Common.Types;
using System;
using WeCotation.domain.TypeMatieres.Dto;

/// <summary>
/// This file was generated by the yeoman generator "generator-micros"
/// @author: Ambert Jean-Christophe
/// @email: jc.ambert@free.fr
/// @created_on: Sun May 10 2020 20:32:31 GMT+0200 (GMT+02:00)
/// </summary>
namespace WeCotation.domain.TypeMatieres.Queries
{
    public class GetTypeMatiere : IQuery<TypeMatiereDto>
    {
        #region public properties
        
            public Guid Id { get; set; }
        
        #endregion
        
    }
}
