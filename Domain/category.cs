using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class category
    {
  

        public int ID { get; set; }
        [MinLength(10), MaxLength(50)]
        public string Name { get; set; }
        [MinLength(100), MaxLength(500)]
        public string? Description { get; set; }

        public category? ParentCategory { get; set; }
       // public images Image { get; set; }

        private readonly IList<category> subcategories;
        public IEnumerable<category> subCategories
        {
            get
            {
                return subcategories;

            }
        }


        private readonly IList<product> products;

        public category(int iD, string name,  category? parentCategory=null)
        {
            ID = iD;
            Name = name;
            
            ParentCategory = parentCategory;
        }

        public category()
        {
        }

        public IEnumerable<product> Products
        {
            get
            {
                return products;

            }
        }
        

        //public category(string name, string? description =null, category? parentCategory=null)
        //{
        //    Name = name;
        //    Description = description;
        //   // Image = image;
        //    ParentCategory = parentCategory;
        //    subcategories= new List<category>();
        //    products = new List<product>();
        //}
        //private category() : this(null!, null!, null!) { }
        public bool AddSubCategory(category c)
        {
            var cat = subcategories.FirstOrDefault(a => a.ID == c.ID);
            if (cat == null)
            {
                subcategories.Add(c);
                return true;

            }
            else { return false; }
        }
        public bool AddProduct(product p)
        {
            var pro = products.FirstOrDefault(a => a.Name == p.Name);
            if (pro == null)
            {
                products.Add(pro);
                return true;

            }
            else { return false; }
        }


    }
}
