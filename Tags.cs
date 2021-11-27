using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Linq;
using StringList = System.Collections.Generic.List<string>;
namespace BoBo2DGameEngine
{
    public enum Tag
    {
        Untagged
    };
    public sealed class Tags
    {
        static readonly StringList stringList = new() { "Untagged" };
        public void AddTag(string tag)
        {
            if (stringList.Contains(tag))
                return;

            stringList.Add(tag);
            stringList.ConvertAll(delegate (string x) { return (Tag)Enum.Parse(typeof(Tag), x); });
        }
    }
}
