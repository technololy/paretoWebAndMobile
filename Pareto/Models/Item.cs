using System;

namespace Pareto.Models
{
    public class Item
    {
        public string Id { get; set; }
        public string Text { get; set; }
        public string Description { get; set; }
    }


    public class LoanSubmitModel
    {
        public string lastName { get; set; }
        public string otherNames { get; set; }
        public string mdaNo { get; set; }
        public string ippisNo { get; set; }
        public DateTime dateOfBirthOrig { get; set; }
        public string dateOfBirth { get; set; }
        public decimal grossPay { get; set; }
        public string yearsInService { get; set; }
        public decimal netPay { get; set; }
        public string bankAcctNo { get; set; }
        public decimal loanAmount { get; set; }
        public string noOfRepayment { get; set; }
        public string telephoneNo { get; set; }
        public string emailAddress { get; set; }
    }

    public class LoanSubmitResponse
    {
        public string message { get; set; }
    }

}