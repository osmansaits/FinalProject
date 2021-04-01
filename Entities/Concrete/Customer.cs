using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entities.Concrete
{
    public class Customer : IEntity
    {   //CustomerId veri tabanında string olduğu için string kodlanmıştır.
        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CompanyName { get; set; }
        public string City { get; set; }          
    }
}
