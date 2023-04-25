using Application.contracts;
using Application.Features.Categories.Queries.CategoryDetailes;
using Dtos.category;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Categories.Commands.DeleteCategory
{
    public class DeleteCategoryCommandHandller : IRequestHandler<DeleteCategoryCommand, bool>
    {
        private readonly ICategoryRepository   Icat;
        public DeleteCategoryCommandHandller(ICategoryRepository _cat)
        {
            Icat = _cat;
        }

        public async Task<bool> Handle(DeleteCategoryCommand request, CancellationToken cancellationToken)
        {
            var c = await Icat.deleteAsync(request.CategoryId);
            return await Task.FromResult(c);
        }
    }
}
