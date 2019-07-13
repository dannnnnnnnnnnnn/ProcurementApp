using System;
using Contracts.DAL.Base.Mappers;

namespace DAL.App.EF.Mappers
{
    public class ProcurementMapper : IBaseDALMapper
    {
        public TOutObject Map<TOutObject>(object inObject) where TOutObject : class
        {
            if (typeof(TOutObject) == typeof(DAL.App.DTO.Procurement))
            {
                return MapFromDomain((Domain.Procurement) inObject) as TOutObject;
            }

            if (typeof(TOutObject) == typeof(Domain.Procurement))
            {
                return MapFromDAL((DAL.App.DTO.Procurement) inObject) as TOutObject;
            }

            throw new InvalidCastException("No conversion");
        }
    }
}