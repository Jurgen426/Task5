using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationMenu.Models
{
    public class Menu
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ParentId { get; set; }
    }
}