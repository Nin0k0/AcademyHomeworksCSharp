using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loan_API.Domain
{



        public class Loan
        {
            public int Id { get; set; }
            public string Amount { get; set; }
            public DateTime DisburseDate { get; set; }

            public int TermMonths { get; set; }
            public LoanType Type { get; set; }
            public Currency Currency { get; set; }
            public LoanStatus Status { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        }


        public enum Currency
        {
            USD,
            GEL,
            EUR,
            GBP
        }

        public enum LoanStatus
        {
            Rejected,
            Accepted,
            Issued,
            Withdrawn,
            Disbursed,
            Paid
        }

        public enum LoanType
        {
            Micro,
            Agro,
            Bussiness,
            Retail,
            Mortgage,
            Leasing
        }
    }

