using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.contracts
{
    public interface IProductReposatory:IReposatory<product,Guid>
    {
       Task< IEnumerable<product>> FilterByAsync(string? filter =null, int? fromprice = null, int? toprice = null, bool? isavailable = null);
    }
}
