using System;

namespace Loan_API.Models
{
    public class Loan
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public Currency Currency { get; set; }

        public LoanType Type { get; set; }
        public DateTime DueDate { get; set; }
        public LoanStatus Status { get; set; }
    }
    public enum LoanType
    {
        Businness,
        Agro,
        Agro_Disc,
        Micro,
        Retail,
        Mini
    }
    public enum LoanStatus
    {
        Expired,
        Paid,
        InProgress,
        Accepted,
        Rejected
    }

    public enum Currency
    {
        
        USD,
        EUR,
        GEL,
        GBP,
        BTC,
    }
}
