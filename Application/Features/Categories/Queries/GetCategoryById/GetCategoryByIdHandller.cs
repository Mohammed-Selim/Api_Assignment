using Application.contracts;
using Dtos.category;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Categories.Queries.CategoryDetailes
{
    public class GetCategoryByIdHandller : IRequestHandler<GetCategoryById, CategoryDetailsDto>
    {
        private readonly ICategoryRepository i;
        public GetCategoryByIdHandller(ICategoryRepository _i)
        {
            this.i = _i;
        }
        public async Task<CategoryDetailsDto> Handle(GetCategoryById request, CancellationToken cancellationToken)
        {
            var cat =await i.GetByIDAsync(request.Id);
            return new CategoryDetailsDto(cat.ID, cat.Name);
          
        }
    }
}
