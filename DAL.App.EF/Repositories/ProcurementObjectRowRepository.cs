using System;
using Contracts.DAL.Base.Mappers;
using DAL.Base.EF.Repositories;

namespace DAL.App.EF.Repositories
{
    public class ProcurementObjectRowRepository : BaseRepository<DAL.App.DTO.ProcurementObjectRow, Domain.ProcurementObjectRow, AppDbContext>
    {
        public ProcurementObjectRowRepository(AppDbContext repositoryDbContext, IBaseDALMapper mapper) : base(repositoryDbContext, mapper)
        {
        }
    }
}