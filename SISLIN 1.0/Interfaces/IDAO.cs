using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISLIN_1._0.Interfaces
{
    /// <summary>
    /// Interface (contrato) para IDAO
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    interface IDAO<T>
    {
        void Insert(T t);

        void Update(T t);

        void Delete(T t);

        List<T> List();

        T GetById(int id);
    }
}
