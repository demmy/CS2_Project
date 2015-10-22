﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public enum PermissionType
    {
        ListClient = 1,
        NewClient = 2,
        EditClient = 3,

        ListOrder = 4,
        NewOrder = 5,
        EditOrder = 6,

        ListGoods = 7,
        NewGoods = 8,
        EditGoods = 9,

        ListUser = 10,
        NewUser = 11,
        EditUser = 12,

        ListRoles = 13,
        NewRole = 14,
        EditRole = 15,

        None = 0
    }
}