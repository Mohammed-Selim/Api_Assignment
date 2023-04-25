using Dtos.category;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Categories.Queries.CategoryDetailes
{
    public class GetCategoryById :IRequest<CategoryDetailsDto>
    {
        public int Id { get; set; }
    }
}
