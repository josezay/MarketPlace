using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Marketplace.Framework;

namespace Marketplace.Domain
{
    public class Money : Value<Money>
    {
        private const string DefaultCurrency = "BRL";
        
        public static Money FromDecimal(decimal amount, string currency = DefaultCurrency) { return new Money(amount, currency); }
        public static Money FromString(string amount, string currency = DefaultCurrency)
        {
            return new Money(decimal.Parse(amount), currency);
        }
        protected Money(decimal amount, string currencyCode = DefaultCurrency)
        {
            if (decimal.Round(amount, 2) != amount)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount não pode ter mais de duas casas decimais");
            }
            
            Amount = amount;
            CurrencyCode = currencyCode;
        }

        public decimal Amount { get; }
        private string CurrencyCode { get; }

        public Money Add(Money summand)
        {
            if (CurrencyCode != summand.CurrencyCode)
            {
                throw new CurrencyMismatchedException("Não é possível somar dois montantes com moedas diferentes");
            }
            return new Money(Amount + summand.Amount);
        }
        public Money Subtract(Money subtrahend)
        {
            if (CurrencyCode != subtrahend.CurrencyCode) { 
                throw new CurrencyMismatchedException("Não é possível subtrair montantes entre duas moedas diferentes");
            }
            return new Money(Amount - subtrahend.Amount);
        }

        public static Money operator +(Money summand1, Money summand2) => summand1.Add(summand2);
        public static Money operator -(Money minuend, Money subtrahend) => minuend.Subtract(subtrahend);

        public class CurrencyMismatchedException : Exception
        {
            public CurrencyMismatchedException(string message) : base(message) { }
        }
    }
}
