using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface ICategoryDal : IEntityRepository<Category>
    {
       
    }
}
