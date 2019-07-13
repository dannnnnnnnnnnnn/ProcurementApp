using BLL.App.Mappers;
using BLL.Base.Services;
using Contracts.BLL.App.Services;
using Contracts.BLL.Base.Mappers;
using Contracts.DAL.App;

namespace BLL.App.Services
{
    public class ProcurementObjectRowService : BaseEntityService<BLL.App.DTO.ProcurementObjectRow, DAL.App.DTO.ProcurementObjectRow, IAppUnitOfWork>, IProcurementObjectRowService

    {
        public ProcurementObjectRowService(IAppUnitOfWork uow) : base(uow, new ProcurementObjectRowMapper())
        {
        }
    }
}