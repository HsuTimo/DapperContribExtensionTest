using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperExtensionsMVC.Interfaces
{
    public interface IRepository
    {
        Task<List<TModel>> GetAllAsync<TModel>() where TModel : class;
        Task<TModel> GetByIdAsync<TModel>(int id) where TModel : class;
        Task CreateAsync<TModel>(TModel obj) where TModel : class;
        Task DeleteAsync<TModel>(TModel obj) where TModel : class;
        Task UpdateAsync<TModel>(TModel obj) where TModel : class;
    }
}
