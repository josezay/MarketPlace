using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketplace.Domain
{
    public class ClassifiedAd
    {
        public Guid Id { get; private set; }
        private Guid _ownerId;
        private string _title;
        private string _text;
        private decimal _price;

        public ClassifiedAd(Guid id)
        {
            if (id == Guid.Empty) {  throw new ArgumentNullException("Identidade precisa ser especificada", nameof(id)); }
            Id = id;
        }
    }
}
