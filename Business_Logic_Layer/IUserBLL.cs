﻿using Data_Access_Layer.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic_Layer
{
    public interface IUserBLL
    {
        List<User> GetUsers();
    }
}
