using Application.contracts;
using Application.Features.Categories.Commands.CreaateCategory;
using Dtos.category;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Categories.Commands.UpdateCategory
{
    public class UpdateCategoryCommandHandler : IRequestHandler<UpdateCategoryCommand, bool>
    {
        private readonly ICategoryRepository i;
        public UpdateCategoryCommandHandler(ICategoryRepository _i)
        {
            this.i = _i;

        }
        public async Task<bool> Handle(UpdateCategoryCommand request, CancellationToken cancellationToken)
        {
            var cat =await i.GetByIDAsync(request.id);
            if (cat == null) 
            {
                return false;
            }else
            {
                cat.Name = request.name;
                return await i.updateAsync(cat);
            }
           
        }
    }
}
