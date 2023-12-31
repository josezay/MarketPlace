﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Marketplace.Framework;

namespace Marketplace.Domain
{
    public class ClassifiedAdId : Value<ClassifiedAdId>
    {
        private readonly Guid _value;

        public ClassifiedAdId(Guid value)
        {
            if (value == Guid.Empty) throw new ArgumentNullException("ClassifiedAdId não pode ser vazio", nameof(value));
            _value = value;
        }
    }
}
