using BLL.App.Services;
using BLL.Base.Helpers;
using Contracts.BLL.App.Services;
using Contracts.DAL.App;

namespace BLL.App.Helpers
{
    public class AppServiceFactory : BaseServiceFactory<IAppUnitOfWork>
    {
        public AppServiceFactory()
        {
            RegisterServices();
        }

        private void RegisterServices()
        {
            // Register all your custom services here!
            AddToCreationMethods<IProcurementService>(uow => new ProcurementService(uow));
            AddToCreationMethods<IProcurementObjectService>(uow => new ProcurementObjectService(uow));
            AddToCreationMethods<IProcurementObjectRowService>(uow => new ProcurementObjectRowService(uow));
        }

    }
    
}