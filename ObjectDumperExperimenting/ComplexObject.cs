using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectDumperExperimenting
{
    class ComplexObject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public PlainOldObject AnotherObject { get; set; }
        public ComplexObject(int id, string name, PlainOldObject anotherObject)
        {
            Id = id;
            Name = name;
            AnotherObject = anotherObject;
        }
    }
}
