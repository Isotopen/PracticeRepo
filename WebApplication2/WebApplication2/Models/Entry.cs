//4a Add Model
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Entry
    {
        //4b Add Properties
        public string Name { get; set; }
        public string Build { get; set; }
        public List<Container> Containers { get; set; }
    }
}