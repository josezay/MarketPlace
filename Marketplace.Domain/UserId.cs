using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketplace.Domain
{
    public class UserId
    {
        private readonly Guid _value;

        public UserId(Guid value)
        {
            if (value == Guid.Empty) { throw new ArgumentNullException("ÙserId não pode ser vazio", nameof(value)); }
            _value = value;
        }
    }
}
