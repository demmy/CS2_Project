﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Permission : BaseEntity
    {
        List<Role> Roles { get; set; }

        public Permission() { Roles = new List<Role>(); }
    }
}
