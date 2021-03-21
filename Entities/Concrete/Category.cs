using Core.DataAccess;

using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Category:IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        ///public string Description { get; set; }
        //public string Picture { get; set; }
    }
}
