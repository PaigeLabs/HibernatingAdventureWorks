using System.Collections.Generic;
using NHibernate;

namespace HibernatingCropInsurance.Data
{
    public interface IRepository
    {
        IQueryOver<T, T> All<T>() where T : class;
        void Save<T>(T item) where T : class;
        void SaveList<T>(IList<T> items) where T : class;
        void Delete<T>(T item) where T : class;
        void Delete<T>(int id) where T : class;
    }
}
