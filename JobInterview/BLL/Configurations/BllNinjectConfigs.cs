using BLL.Interfaces;
using BLL.Services;
using DAL.Interfaces;
using DAL.Repositoties;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Configurations
{
    public class BllNinjectConfigs : NinjectModule
    {
        private readonly string _connectionString;

        public BllNinjectConfigs(string connectionString)
        {
            _connectionString = connectionString;
        }

        public override void Load()
        {
            Bind<IUnitOfWork>().To<UnitOfWork>().WithConstructorArgument(_connectionString);

            Bind<IJobInterviewService>().To<JobInterviewService>();
        }
    }
}
