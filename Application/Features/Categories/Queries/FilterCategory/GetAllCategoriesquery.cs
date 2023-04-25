using Dtos.category;
using MediatR;

namespace Application.Features.Categories.Queries.GetAllCategories
{
    public class GetAllCategoriesquery : IRequest<IEnumerable<CategoryDto>>
    {
        public string? filter { get; set; }
    }
}
