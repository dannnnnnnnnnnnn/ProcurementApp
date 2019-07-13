using System;
using Contracts.BLL.Base.Mappers;
using internalDTO = DAL.App.DTO;
using externalDTO = BLL.App.DTO;

namespace BLL.App.Mappers
{
    public class ProcurementObjectRowMapper : IBaseBLLMapper
    {
        public TOutObject Map<TOutObject>(object inObject) where TOutObject : class
        {
            if (typeof(TOutObject) == typeof(externalDTO.ProcurementObjectRow))
            {
                return MapFromInternal((internalDTO.ProcurementObjectRow) inObject) as TOutObject;
            }

            if (typeof(TOutObject) == typeof(externalDTO.ProcurementObjectRow))
            {
                return MapFromExternal((externalDTO.ProcurementObjectRow) inObject) as TOutObject;
            }
            throw new InvalidCastException($"Can't convert from {inObject.GetType().FullName} to {typeof(TOutObject).FullName}");
        }

        public static externalDTO.ProcurementObjectRow MapFromInternal(internalDTO.ProcurementObjectRow procurementObjectRow)
        {
            var res = procurementObjectRow == null
                ? null
                : new externalDTO.ProcurementObjectRow
                {
                    Id = procurementObjectRow.Id,
                    Year = procurementObjectRow.Year,
                    Amount = procurementObjectRow.Amount,
                    Price = procurementObjectRow.Price,
                    ProcurementObject = ProcurementObjectMapper.MapFromDAL(procurementObjectRow.ProcurementObject),
                    ProcurementObjectId = procurementObjectRow.ProcurementObjectId,
                    Sum = procurementObjectRow.Sum
                };
            return res;
        }

        public static internalDTO.ProcurementObjectRow MapFromExternal(externalDTO.ProcurementObjectRow procurementObjectRow)
        {
            var res = procurementObjectRow == null ? null : new internalDTO.ProcurementObjectRow
                {
                    Id = procurementObjectRow.Id,
                    Amount = procurementObjectRow.Amount,
                    Price = procurementObjectRow.Price,
                    ProcurementObject = ProcurementObjectMapper.MapFromBLL(procurementObjectRow.ProcurementObject),
                    ProcurementObjectId = procurementObjectRow.ProcurementObjectId,
                    Sum = procurementObjectRow.Sum,
                    Year = procurementObjectRow.Year
                };
            return res;
        }
    }
}