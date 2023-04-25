using Application.contracts;
using Domain;
using Dtos.category;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Categories.Commands.CreaateCategory
{
    public class CeateCategoryCommandHandller : IRequestHandler<CeateCategoryCommand, CategoryDto>
    {
        private readonly ICategoryRepository i;
        public CeateCategoryCommandHandller(ICategoryRepository _i)
        {
            this.i = _i;

        }
        public async Task<CategoryDto> Handle(CeateCategoryCommand request, CancellationToken cancellationToken)
        {
            //category parentcat = null;
            //if(parentcat!= null)
            //{
            //     parentcat = await i.GetByIDAsync(request.ParenCatId.Value);
            //}

            //var cat = new category(request.id,request.name, parentcat);
            var cat = new category(request.id, request.name);
              cat =await i.createAsync(cat);
            return  new CategoryDto() { ID = cat.ID, Name = cat.Name };
        }
        //!!
    }
}
