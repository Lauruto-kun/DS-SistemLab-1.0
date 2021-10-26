using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDS_SistemLab2._0.Interface2
{
    interface IDAO2<T>
    {       
            ///<typeparam name="T" ></typeparam>
                void Insert(T t);

                void Update(T t);

                void Delete(T t);

                List<T> List();

                T GetById(int id);

            
        
    }
}
