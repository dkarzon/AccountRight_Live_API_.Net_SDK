﻿using System;
using MYOB.AccountRight.SDK.Contracts.Version2.GeneralLedger;

namespace MYOB.AccountRight.SDK.Contracts.Version2.Sale
{
    public class ProfessionalInvoiceLine : InvoiceLine
    {
        public DateTime? Date { get; set; }
        public AccountLink Account { get; set; }
    }
}