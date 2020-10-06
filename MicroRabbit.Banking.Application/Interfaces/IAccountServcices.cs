using System;
using System.Collections.Generic;
using System.Text;
using MicroRabbit.Banking.Domain.Models;

namespace MicroRabbit.Banking.Application.Interfaces
{
    public interface IAccountServcices
    {
        IEnumerable<Account> GetAccounts();
    }
}
