using MicroS_Common.Messages;
using System;
/// <summary>
/// This file was generated by the yeoman generator "generator-micros"
/// @author: Ambert Jean-Christophe
/// @email: jc.ambert@free.fr
/// @created_on: Wed May 13 2020 11:51:54 GMT+0200 (GMT+02:00)
/// </summary>
namespace WeCotation.domain.Articles.Messages.Events
{
    [MessageNamespace("articles")]
    public class ArticleBaseRejectedEvent : BaseRejectedEvent
    {
        public ArticleBaseRejectedEvent(Guid id, string reason, string code) : base(id, reason, code)
        {
        }
    }
}
