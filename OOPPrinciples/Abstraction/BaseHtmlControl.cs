using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Abstraction
{
    public abstract class BaseHtmlControl
    {
        public string ID { get; set; }
        public string CssClass { get; set; }

        public string Style { get; set; }

        public string Tag { get; set; }

        public BaseHtmlControl(string tag)
        {
            this.Tag = tag;
        }
        public abstract string Output();
        protected string GetTagStart()
        {
            return $"<{Tag}>";
        }

        protected string GetTagEnd()
        {
            return $"</{Tag}>";
        }
    }
}
