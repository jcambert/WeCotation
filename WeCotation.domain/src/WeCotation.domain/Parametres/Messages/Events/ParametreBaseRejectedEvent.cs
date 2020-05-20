using MicroS_Common.Messages;
using System;
/// <summary>
/// This file was generated by the yeoman generator "generator-micros"
/// @author: Ambert Jean-Christophe
/// @email: jc.ambert@free.fr
/// @created_on: Fri May 15 2020 14:01:25 GMT+0200 (GMT+02:00)
/// </summary>
namespace WeCotation.domain.Parametres.Messages.Events
{
    [MessageNamespace("parametres")]
    public class ParametreBaseRejectedEvent : BaseRejectedEvent
    {
        public ParametreBaseRejectedEvent(Guid id, string reason, string code) : base(id, reason, code)
        {
        }
    }
}
