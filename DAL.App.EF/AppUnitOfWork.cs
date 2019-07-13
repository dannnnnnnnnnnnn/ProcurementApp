using Contracts.BLL.App.Repositories;
using Contracts.DAL.App;
using Contracts.DAL.App.Repositories;
using Contracts.DAL.Base.Helpers;
using DAL.Base.EF;

namespace DAL.App.EF
{
    public class AppUnitOfWork : BaseUnitOfWork<AppDbContext>, IAppUnitOfWork
    {
        
        public AppUnitOfWork(AppDbContext dbContext, IBaseRepositoryProvider repositoryProvider) : base(dbContext, repositoryProvider)
        {
        }

        public IProcurementRepository Procurements =>
            _repositoryProvider.GetRepository<IProcurementRepository>();

        public IProcurementObjectRepository ProcurementObjects =>
            _repositoryProvider.GetRepository<IProcurementObjectRepository>();

        
        public IProcurementObjectRowRepository ProcurementObjectRows => 
            _repositoryProvider.GetRepository<IProcurementObjectRowRepository>();
 
        
    }
}