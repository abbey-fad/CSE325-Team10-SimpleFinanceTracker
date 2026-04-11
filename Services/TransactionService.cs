using System.Collections.Generic;
using CSE325_Team10_SimpleFinanceTracker.Models;

namespace CSE325_Team10_SimpleFinanceTracker.Services
{
    public class TransactionService
    {
        private readonly List<Transaction> _transactions = new();

        public IReadOnlyList<Transaction> Transactions => _transactions;

        public void AddTransaction(Transaction transaction)
        {
            _transactions.Add(transaction);
        }

        // Update existing transaction fields instead of replacing the object
        public void UpdateTransaction(int index, Transaction updatedTransaction)
        {
            if (index >= 0 && index < _transactions.Count)
            {
                var t = _transactions[index];
                t.Description = updatedTransaction.Description;
                t.Category = updatedTransaction.Category;
                t.Amount = updatedTransaction.Amount;
                t.Date = updatedTransaction.Date;
            }
        }

        public void DeleteTransaction(int index)
        {
            if (index >= 0 && index < _transactions.Count)
            {
                _transactions.RemoveAt(index);
            }
        }

        public void ClearTransactions()
        {
            _transactions.Clear();
        }
    }
}