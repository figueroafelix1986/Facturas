using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factura.Commons
{
    public static class Validator
    {
        public static bool IsTexboxsEmpty(string[] values)
        {
            return !values.Any(x => string.IsNullOrWhiteSpace(x));
        }
    }
}
