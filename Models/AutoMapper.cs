using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Reflection;

namespace Dto_AutoMapper.Models;
public class AutoMapper<T, D>
{
    Type modelClass = typeof(T);
    Type dtoClass = typeof(D);

    public void Map(D dtoObj, T modelObj)
    {
        foreach (var dtoProp in dtoClass.GetProperties())
        {
            foreach (var modelProp in modelClass.GetProperties())
            {
                if (dtoProp.Name == modelProp.Name)
                {
                    dtoProp.SetValue((D)dtoObj, dtoProp.GetValue((T)modelObj));
                }
            }
        }
    }
}
