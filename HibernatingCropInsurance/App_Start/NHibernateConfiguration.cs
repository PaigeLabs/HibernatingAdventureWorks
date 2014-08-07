using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using HibernatingCropInsurance.Models;
using NHibernate;
using Ninject.Activation;

namespace HibernatingCropInsurance.App_Start
{
    public class NHibernateConfiguration : IProvider
    {
        private readonly ISessionFactory _sessionFactory;

        public NHibernateConfiguration()
        {
            _sessionFactory = Fluently.Configure()
               .Database(MsSqlConfiguration.MsSql2008
                   .ConnectionString(cnx =>
                       cnx.FromConnectionStringWithKey("DefaultConnection")))
                   .Mappings(m => m.FluentMappings
                       .AddFromAssemblyOf<ApplicationUser>())
                   .BuildSessionFactory();
        }
        public object Create(IContext context)
        {
            return _sessionFactory;
        }

        public Type Type
        {
            get { return typeof (ISessionFactory); }
        }
    }
}