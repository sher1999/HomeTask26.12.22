using Domain;
using System.Collections.Generic;
using System.ComponentModel;


var p1 = new Person("Juan");
var p2 = new Person("Sara");
var p3 = new Person("Carlos");

var list=new List<Person>(); 
list.Add(p1);
list.Add(p2);
list.Add(p3);

foreach (var item in list)
{
    Console.WriteLine(item.ToString());
}