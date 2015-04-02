﻿using System;

namespace WebVella.ERP.Core
{
    public class MongoCurrencyField : MongoBaseField, ICurrencyField
    {
        public new decimal DefaultValue { get; set; }

        public decimal MinValue { get; set; }

        public decimal MaxValue { get; set; }

        public CurrencyTypes Currency { get; set; }

        public decimal Value { get; set; }
    }
}