using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectPoolCS
{
    public interface IObjectPool
    {
        object borrowObject();

        void returnObject(object obj);
    }
}
