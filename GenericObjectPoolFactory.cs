using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectPoolCS
{
    class GenericObjectPoolFactory : IObjectPoolFactory
    {
        protected IPoolableObjectFactory _factory = null;

        public GenericObjectPoolFactory(IPoolableObjectFactory pof)
        {
            _factory = pof;
        }

        public IObjectPool createPool()
        {
            return new GenericObjectPool(_factory);
        }
    }
}
