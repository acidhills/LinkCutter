﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DataEntities
{
    public class User
    {
        public int Id { get; set; }
        public virtual ICollection<Link> Links { get; set; } 
    }
}
