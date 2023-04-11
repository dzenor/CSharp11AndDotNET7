using System;
using System.Collections.Generic;
using System.Text;

namespace Packt.Shared;


public class Person : Object
{
    public string? Name;
    public DateTime DateOfBirth;

    public WondersOfTheAncientWorld FavoriteAncientWonder;

    public List<Person> Children = new List<Person> ();
}
