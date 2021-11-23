using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectDumperExperimenting
{
    class PlainOldObject
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public PlainOldObject(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
