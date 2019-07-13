using Contracts.BLL.App.Services;
using Contracts.BLL.Base;

namespace Contracts.BLL.App
{
    public interface IAppBLL : IBaseBLL
    {
        IProcurementService Procurements { get; }
        IProcurementObjectService ProcurementObjects { get; }
        IProcurementObjectRowService ProcurementObjectRows { get; }
    }
}