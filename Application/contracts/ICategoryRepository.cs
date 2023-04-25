using Application.Features.Categories.Queries.GetAllCategories;
using Domain;
using Dtos.category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.contracts
{
    public interface ICategoryRepository:IReposatory<category,int>
    {
       Task<IEnumerable<category>> FilterByAsync(string? filter=null);


    }
}
