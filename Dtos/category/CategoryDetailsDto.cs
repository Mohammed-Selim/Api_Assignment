using Domain;
using Dtos.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dtos.category
{
    public class CategoryDetailsDto
    {
      
        public int ID { get; set; }
       
        public string Name { get; set; }
 
        public string? Description { get; set; }

        //public CategoryDto? ParentCategory { get; set; }
        

        //public  IEnumerable<CategoryDto>? subcategories { get; set; }
        //public CategoryDto? parentCategory { get; set; }

        //public IEnumerable<ProductDto> products { get; set; }
        public CategoryDetailsDto(int iD, string name)
        {
            ID = iD;
            Name = name;
        }

     
    }
}
