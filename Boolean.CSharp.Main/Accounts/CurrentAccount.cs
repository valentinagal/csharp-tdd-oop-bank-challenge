﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.Boolean.CSharp.Main.Accounts
{
    public class CurrentAccount : Account, IAccount
    {
    public CurrentAccount() : base() { }

        public bool isSavingAccount => false;
    }
}
