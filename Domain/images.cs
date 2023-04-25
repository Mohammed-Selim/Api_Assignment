using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class images
    {
 
        public int ID { get; set; }
     
        public string url { get; set; }

        public float length { get; set; }
        public float width { get; set; }
        public float height { get; set; }
       
        public product product { get; set; }
        
        //public category category { get; set; }
        public images(string url, float length, float width, float height, product product)
        {
            this.url = url;
            this.length = length;
            this.width = width;
            this.height = height;
            this.product = product;
        }
  
        private images() : this(null!,0,0,0, null!) { }

      
    }
}
