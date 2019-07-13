using Contracts.BLL.App.Repositories;
using Contracts.BLL.App.Services;
using Contracts.DAL.App.Repositories;
using Contracts.DAL.Base;

namespace Contracts.DAL.App
{
    public interface IAppUnitOfWork : IBaseUnitOfWork
    {
        IProcurementRepository Procurements { get; }
        IProcurementObjectRepository ProcurementObjects { get; }
        IProcurementObjectRowRepository ProcurementObjectRows { get; }
    }
}