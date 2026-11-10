using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListSpaceMissionControl
{
    internal class Destination
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Mission { get; set; }

        public Destination(int id, string name, string mission)
        {
            Id = id;
            Name = name;
            Mission = mission;

        }

        public override string ToString()
        {
            return $" {Id} : {Name} ( {Mission})";
        }

    }
}
