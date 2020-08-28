using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z13_DI
{
    public class DBDataProvider : IDataProvider
    {
        public Context Context { get; private set; }
        public DBDataProvider(Context context)
        {
            Context = context;
        }
        public int GetData()
        {
            return Context.Models.FirstOrDefault().Amount;
        }
    }
}
