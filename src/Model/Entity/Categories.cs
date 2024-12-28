using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalFinanceManager.src.Model.Entity
{
    public class Categories
    {
        public int CategoryID { get; set; }
        public int UserID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
