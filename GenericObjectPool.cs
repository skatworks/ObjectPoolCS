using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectPoolCS
{
    class GenericObjectPool : IObjectPool
    {
        private IPoolableObjectFactory _factory = null;
        private LinkedList<object> _pool = null;

        public GenericObjectPool(IPoolableObjectFactory pof)
        {
            _factory = pof;
            _pool = new LinkedList<object>();
        }

        public object borrowObject()
        {
            object obj;
            try
            {
                if (_pool?.Count > 0)
                {
                    obj = _pool.FirstOrDefault();
                    _pool.RemoveFirst();
                } else
                {
                    obj = _factory.makeObject();
                }
            } catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                obj = null;
            }

            return obj;
        }

        public void returnObject(object obj)
        {
            _pool.AddLast(obj);
        }
    }
}
