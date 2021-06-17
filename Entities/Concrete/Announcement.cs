using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class Announcement:IEntity
    {
        public int Id{ get; set; }
        public string Description { get; set; }

        public string Title { get; set; }

        public string Notice { get; set; }
        public DateTime Date { get; set; }
    }
}
