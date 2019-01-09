using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Section : Element
    {
  private string title;
    private List<Element> content = new List<Element>();

    public string getName()
    {
        return title;
    }

    public void setName(string name)
    {
        this.title = name;
    }

    public Section(string name)
    {
        this.title = name;
    }

  public void add(Element element)
    {
        this.content.Add(element);
    }

  public void remove(Element element)
    {
        this.content.Remove(element);
    }

  public Element getElement(int index)
    {
        return this.content[index];
    }

  public void print()
    {
        foreach (var element in content)
        {
            element.print();
        }
    }

  public void accept(Visitor visitor)
    {
        visitor.visit(this);
        foreach(var element in content)
        {
            element.accept(visitor);
        }
    }

}

}
