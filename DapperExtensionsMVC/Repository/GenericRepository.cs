using Dapper.Contrib.Extensions;
using DapperExtensionsMVC.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperExtensionsMVC.Repository
{
    public class GenericRepository: IRepository
    {
        private readonly IConnectionHelper _connectionHelper;
        public GenericRepository(IConnectionHelper connectionHelper)
        {
            _connectionHelper = connectionHelper;
        }

        public void Create<TModel>(TModel obj) where TModel : class
        {
            using (var connection = _connectionHelper.GetConnection("DefaultConnection"))
            {
                connection.Open();
                connection.Insert(obj);
            }
        }

        public void Delete<TModel>(TModel obj) where TModel : class
        {
            using (var connection = _connectionHelper.GetConnection("DefaultConnection"))
            {
                connection.Open();
                connection.Delete(obj);
            }
        }

        public List<TModel> GetAll<TModel>() where TModel : class
        {
            using (var connection = _connectionHelper.GetConnection("DefaultConnection"))
            {
                connection.Open();
                var list = connection.GetAll<TModel>().ToList();
                return list;
            }
        }

        public TModel GetById<TModel>(int id) where TModel : class
        {
            using (var connection = _connectionHelper.GetConnection("DefaultConnection"))
            {
                connection.Open();
                var obj = connection.Get<TModel>(id);
                return obj;
            }
        }

        public void Update<TModel>(TModel obj) where TModel : class
        {
            using (var connection = _connectionHelper.GetConnection("DefaultConnection"))
            {
                connection.Open();
                connection.Update(obj);
            }
        }
    }
}
