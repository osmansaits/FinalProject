using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
        
    }
}
