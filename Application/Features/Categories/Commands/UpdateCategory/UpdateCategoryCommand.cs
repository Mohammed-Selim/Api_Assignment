using Dtos.category;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Categories.Commands.UpdateCategory
{
    public class UpdateCategoryCommand : IRequest<bool>
    {
        public int id { get; set; }
        public string name { get; set; }
        public int? ParenCatId { get; set; }
    }
}
