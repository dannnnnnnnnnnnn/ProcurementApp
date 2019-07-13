using Contracts.DAL.Base.Repositories;
using DAlAppDTO = DAL.App.DTO;


namespace Contracts.DAL.App.Repositories
{
    public interface IProcurementObjectRepository : IProcurementObjectRepository<DAlAppDTO.ProcurementObject>
    {
    }

    public interface IProcurementObjectRepository<TDALEntity> : IBaseRepository<TDALEntity>
        where TDALEntity : class, new()
    {
        
    }
}