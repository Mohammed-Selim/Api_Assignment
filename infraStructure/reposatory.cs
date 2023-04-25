using Application.contracts;
using DComtext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infraStructure
{
    public class reposatory<TE, Tid> : IReposatory<TE, Tid> where TE : class
    {
        protected readonly Context con;
        private readonly DbSet<TE> dbset;
        public reposatory(Context _con)
        {
            dbset = _con.Set<TE>();
            con = _con;

        }
        public async Task<TE> createAsync(TE entity)
        {
            //  return (await dbset.AddAsync(entity)).Entity;
            var data = (await dbset.AddAsync(entity)).Entity;
            await savechangesAsync();
            return data;
        } 
        public async Task<TE> createOnDBAsync(TE entity)
        {
            var data=(await dbset.AddAsync(entity)).Entity;
            await savechangesAsync();
            return data;
            
        }

        public async Task<bool> deleteAsync(Tid id)
        {
            var i=await dbset.FindAsync(id);
           if( i != null)
            {
                dbset.Remove(i);
               await savechangesAsync();
                return true;
            }
           return false;
            
        }

        public async Task<TE?> GetByIDAsync(Tid id)
        {
            return await dbset.FindAsync(id);
        }

        public async Task<int> savechangesAsync()
        {
          return await con.SaveChangesAsync();
        }

        public async Task<bool> updateAsync(TE entity)
        {
            var en = dbset.Update(entity);
            if(en != null) 
            {
               await savechangesAsync();
                return true;
            }
            else
            {
                return false;
            }
        }

       
    }
}
