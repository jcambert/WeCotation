using MicroS_Common.Types;
using System;
using WeCotation.domain.Articles.Dto;

/// <summary>
/// This file was generated by the yeoman generator "generator-micros"
/// @author: Ambert Jean-Christophe
/// @email: jc.ambert@free.fr
/// @created_on: Wed May 13 2020 11:51:54 GMT+0200 (GMT+02:00)
/// </summary>
namespace WeCotation.domain.Articles.Queries
{
    public class GetArticle : IQuery<ArticleDto>
    {
        #region public properties
        
            public Guid Id { get; set; }
        
        #endregion
        
    }
}