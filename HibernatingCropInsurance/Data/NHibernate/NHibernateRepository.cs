using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NHibernate;

namespace HibernatingCropInsurance.Data.NHibernate
{
    public class NHibernateRepository : IRepository
    {
        private readonly ISession _session;

        public NHibernateRepository(ISession session)
        {
            _session = session;
        }

        public IQueryOver<T, T> All<T>() where T : class
        {
            return _session.QueryOver<T>();
        }

        public void Save<T>(T item) where T : class
        {
            throw new NotImplementedException();
        }

        public void SaveList<T>(IList<T> items) where T : class
        {
            throw new NotImplementedException();
        }

        public void Delete<T>(T item) where T : class
        {
            throw new NotImplementedException();
        }

        public void Delete<T>(int id) where T : class
        {
            throw new NotImplementedException();
        }
    }
}