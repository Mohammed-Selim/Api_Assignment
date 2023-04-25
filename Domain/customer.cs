using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    internal class customer
    {

      
        public int ID { get; set; }

        public string Name { get; set; }

 
        public string Email { get; set; }

        public string Password { get; set; }

        
       // public IEnumerable<order> orders { get; set; }
        private readonly IList<product> products;
        public IEnumerable<product> Products
        {
            get
            {
                return products;

            }
        }



    }
}
