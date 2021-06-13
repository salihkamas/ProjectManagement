﻿using Core.DataAccess.Concrete;
using Core.Entities.Concrete;
using DataAccess.Abstract;

using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, ProjectManagementContext>, IUserDal
    {
    }
}
