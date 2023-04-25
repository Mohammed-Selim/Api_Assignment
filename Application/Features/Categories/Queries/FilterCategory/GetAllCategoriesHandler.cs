using Application.contracts;
using Dtos.category;
using MediatR;

namespace Application.Features.Categories.Queries.GetAllCategories
{
    public class GetAllCategoriesHandler : IRequestHandler<GetAllCategoriesquery, IEnumerable<CategoryDto>>
    {
        private readonly ICategoryRepository I;
        public GetAllCategoriesHandler(ICategoryRepository i)
        {
            I = i;
        }
        public async Task<IEnumerable<CategoryDto>> Handle(GetAllCategoriesquery request, CancellationToken cancellationToken)
        {
            //List <CategoryDto> result = new List<CategoryDto>();
            // List<category> categories = I.GetAllCategories();
            // foreach (category category in categories) 
            // {
            //     result.Add(new CategoryDto() { ID = category.ID, Name = category.Name });
            // }
            // return result;

            return (await I.FilterByAsync(request.filter))
                .Select(c => new CategoryDto() { ID = c.ID, Name = c.Name ,Description=c.Description });
        }
    }
}
