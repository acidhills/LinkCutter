﻿using Entities;
using Entities.DataEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Contracts
{
    public interface IUserRepo
    {
        User Create();

        User Get(int id);
    }
}
