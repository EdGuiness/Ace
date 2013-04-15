using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quirks
{
public class Foo
{
}

public class Bar : Foo
{
}

public class TestFooBar
{
    public void test()
    {
        Foo foo = new Foo();
        Bar bar = new Bar();

        Object list = new List<string>();

        var test = bar as Foo;  // OK, casts bar as Foo

        var test1 = list as Foo;  // OK, but test1 is null

        var test2 = (Foo)list;  // Throws an Exception
    }
}

}
