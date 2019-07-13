using BLL.Base;
using Contracts.BLL.App;
using Contracts.BLL.App.Services;
using Contracts.BLL.Base.Helpers;
using Contracts.DAL.App;

namespace BLL.App
{
    public class AppBLL : BaseBLL<IAppUnitOfWork>, IAppBLL
    {
        protected readonly IAppUnitOfWork AppUnitOfWork;
        
        public AppBLL(IAppUnitOfWork appUnitOfWork, IBaseServiceProvider serviceProvider) : base(appUnitOfWork, serviceProvider)
        {
            AppUnitOfWork = appUnitOfWork;
        }

        public IProcurementService Procurements => ServiceProvider.GetService<IProcurementService>();
        public IProcurementObjectService ProcurementObjects => ServiceProvider.GetService<IProcurementObjectService>();
        public IProcurementObjectRowService ProcurementObjectRows => ServiceProvider.GetService<IProcurementObjectRowService>();
    }
}