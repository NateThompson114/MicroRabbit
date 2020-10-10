using MicroRabbit.Transfer.Data.Context;
using System.Collections.Generic;
using MicroRabbit.Transfer.Domain.Interfaces;
using MicroRabbit.Transfer.Domain.Models;

namespace MicroRabbit.Transfer.Data.Repository
{
    public class TransferRepository : ITransferRepository
    {
        private readonly TransferDbContext _ctx;
        public TransferRepository(TransferDbContext ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<TransferLog> GetTransferLogs()
        {
            return _ctx.TransferLogs;
        }

        public void Add(TransferLog transferLog)
        {
            _ctx.TransferLogs.Add(new TransferLog
            {
                FromAccount = transferLog.FromAccount,
                ToAccount = transferLog.ToAccount,
                TransferAmount = transferLog.TransferAmount
            });

            _ctx.SaveChanges();
        }
    }
}
