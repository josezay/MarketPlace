﻿using Marketplace.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketplace.Domain
{
    public class ClassifiedAdTitle : Value<ClassifiedAdTitle>
    {
        public static ClassifiedAdTitle FromString(string title) => new ClassifiedAdTitle(title);
        private readonly string _value;
        private ClassifiedAdTitle(string value)
        {
            if (value.Length > 100)
            {
                throw new ArgumentOutOfRangeException("Título não pode ter mais de 100 caracteres", nameof(value);
            }
            _value = value;
        }
    }
}
