﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Core.DataAccess;
using Entities.Concrete;


namespace DataAccess.Abstract
{
    public interface ICategoryDal : IEntityRepository<Category>
    {
       
    }
}
