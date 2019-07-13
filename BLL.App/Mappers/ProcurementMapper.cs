using System;
using System.Collections;
using System.Collections.Generic;
using Contracts.BLL.Base.Mappers;
using externalDTO = DAL.App.DTO;
using internalDTO = BLL.App.DTO;

namespace BLL.App.Mappers
{
    public class ProcurementMapper : IBaseBLLMapper
    {
        //TODO CREATE MAPPERS
        public TOutObject Map<TOutObject>(object inObject) where TOutObject : class
        {
            if (typeof(TOutObject) == typeof(externalDTO.Procurement))
            {
                return MapFromInternal((internalDTO.Procurement) inObject) as TOutObject;
            }

            if (typeof(TOutObject) == typeof(externalDTO.Procurement))
            {
                return MapFromExternal((externalDTO.Procurement) inObject) as TOutObject;
            }
            throw new InvalidCastException($"Can't convert from {inObject.GetType().FullName} to {typeof(TOutObject).FullName}");
        }
        public static externalDTO.Procurement MapFromInternal(internalDTO.Procurement procurement)
        {
            var res = procurement == null
                ? null
                : new externalDTO.Procurement
                {
                    Id = procurement.Id,
                    Name = procurement.Name, 
                    ProcurementObjects = 
                    {
                    res.ProcurementObjects.Add(ob);
                    };
            
                };
            for (int i = 0; i < procurement.ProcurementObjects.Count; i++)
            {
                res.ProcurementObjects.Add(ob);

            }
            return res;
        }

        public static ICollection<externalDTO.ProcurementObject> MapObjects(internalDTO.Procurement procurement)
        {
            ICollection<externalDTO.ProcurementObject> procurementObjects = new ICollection();
            for (int i = 0; i < procurement.ProcurementObjects.Count; i++)
            {
                procurementObjects.Add(ProcurementObjectMapper.MapFromDAL(procurement.ProcurementObjects[i]));
            }
        }
    }
}