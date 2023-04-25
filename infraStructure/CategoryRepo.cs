using Application.contracts;
using DComtext;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace infraStructure
{
    public class CategoryRepo : reposatory<category, int>, ICategoryRepository
    {
        public CategoryRepo(Context con) : base(con)
        {
        }

        public async Task<IEnumerable<category>> FilterByAsync(string? filter = null)
        {
            IEnumerable<category> result = null;
           if (filter != null)
            {
                result = con.categories.Where(a=>a.Name.Contains(filter));
                return  result;

            }
            else 
            {
                result = con.categories;
                return result;
            }
          
        }
    }
}
