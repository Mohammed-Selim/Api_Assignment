﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dtos.category
{
    public class CategoryDto
    {
        public int ID { get; set; }
        
        public string Name { get; set; }
     
        public string? Description { get; set; }
      //  public category? ParentCategory { get; set; }

    }
}
