using Dtos.category;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Categories.Commands.CreaateCategory
{
    public class CeateCategoryCommand:IRequest<CategoryDto>
    {
        public int id { get; set; }
        public string name { get; set; }
        public int? ParenCatId  { get; set; }
       

        public CeateCategoryCommand(int id, string name, int? parenCatId=null)
        {
            this.id = id;
            this.name = name;
            ParenCatId = parenCatId;
        }
    }
}
