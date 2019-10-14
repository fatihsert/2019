using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Abstraction
{
    public class SpanControl : BaseHtmlControl
    {
        public string Text { get; set; }
        public SpanControl() : base("span")
        {

        }
        public override string Output()
        {
            var startTag = GetTagStart();
            var endTag = GetTagEnd();

            return $"{startTag} {Text} {endTag}";
        }

    }
}
