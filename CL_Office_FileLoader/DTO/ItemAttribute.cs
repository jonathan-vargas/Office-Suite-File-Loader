using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ItemAttribute
{
    public const string INTEGER_TYPE = "INTEGER";
    public const string STRING_TYPE = "STRING";

    public object Value { get; set; }
    public string Type { get; set; }
    public string Name { get; set; }

    public ItemAttribute()
    {
        this.Name = this.Type = null;
        this.Value = null;
    }

    public ItemAttribute(string name, string type, object value)
    {
        this.Name = name;
        this.Type = type;
        this.Value = value;
    }
}
