using System;
using System.Collections.Generic;
using System.Text;
using WeCotation.domain.Articles.Messages.Events;

namespace WeCotation.domain.articles.Messages.Events
{
    public class ArticleDuplicatedEvent:ArticleBaseEvent
    {
        public string Code { get; }

        public ArticleDuplicatedEvent (string code)
        {
            Code = code;
        }
  
    }
}
