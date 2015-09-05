using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Item
{
    string name {get; set;}
    List<ItemAttribute> Attributes { get; set; }

    public Item()
    {
        Attributes = new List<ItemAttribute>();
    }

    public ItemAttribute getAttribute(string id)
    {
        foreach (ItemAttribute ia in Attributes)
        {
            if (ia.Name == id)
            {
                return ia;
            }
        }
        return null;
    }

    public void addAttribute(string id, string type, object value)
    {
        if (id != null && type != null && value != null)
        {
            ItemAttribute ia = new ItemAttribute(id, type, value);
            Attributes.Add(ia);
        }
    }

    public void addAttribute(ItemAttribute ia)
    {
        if (ia != null) {
            Attributes.Add(ia);
        }
    }

    public bool dropAttribute(string id)
    {
        ItemAttribute ia = getAttribute(id);

        if (ia != null)
        {
            return this.Attributes.Remove(ia);
        }

        return false;
    }
}
