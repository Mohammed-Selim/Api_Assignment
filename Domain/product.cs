using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class product
    {
     

        public Guid ID { get; set; }
        [MinLength(5), MaxLength(50)]
        public string Name { get; set; }

        public string? imageUrl { get; set; }
        [ MaxLength(500)]
        public string? Description { get; set; }
        public int? Quantity { get; set; }
        [Range(1,100)]
        public byte? Discount { get; set; }
        public float? UnitWeight { get; set; }
        public float? Price { get; set; }
         

        private readonly IList<category> categorys;
        public IEnumerable<category>? Categorys
        {
            get
            {
                return categorys;

            }
        }

        private readonly IList<images>? images;
        public IEnumerable<images> Images
        {
            get
            {
                return images;

            }
        }
 
        //public product(string name, string imageUrl,category? category, string description, int quantity, byte discount, float unitWeight, float price)
        //{
        //    Name = name;
        //    this.imageUrl = imageUrl;
        //    Description = description;
        //    Quantity = quantity;
        //    Discount = discount;
        //    UnitWeight = unitWeight;
        //    Price = price;
        //    categorys = new List<category>();
        //    categorys.Add(category);
        //    images = new List<images>();

        //}
     //   private product() : this(null!, null!, null!, null!,0,0,0,0 ) { }
        public bool AddCategory(category c)
        {
            var cat = categorys.FirstOrDefault(a => a.ID == c.ID);
            if (cat == null)
            {
                categorys.Add(c);
                return true;

            }
            else { return false; }
        }
        public bool Addimage(images i)
        {
            var im = images.FirstOrDefault(a => a.url == i.url);
            if (im == null)
            {
                images.Add(im);
                return true;

            }
            else { return false; }
        }


    }
}
