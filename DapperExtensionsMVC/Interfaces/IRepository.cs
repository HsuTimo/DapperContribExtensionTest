using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperExtensionsMVC.Interfaces
{
    public interface IRepository
    {
        List<TModel> GetAll<TModel>() where TModel : class;
        TModel GetById<TModel>(int id) where TModel : class;
        void Create<TModel>(TModel obj) where TModel : class;
        void Delete<TModel>(TModel obj) where TModel : class;
        void Update<TModel>(TModel obj) where TModel : class;
    }
}
