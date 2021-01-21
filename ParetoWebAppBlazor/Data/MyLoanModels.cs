using System;
using System.ComponentModel.DataAnnotations;

namespace ParetoWebAppBlazor.Data
{

    public class LoanSubmitModel
    {
       // [Required(ErrorMessage = "Last Name is required")]

        public string lastName { get; set; }
        //[Required(ErrorMessage = "Other Name is required")]

        public string otherNames { get; set; }
        //[Required(ErrorMessage = "MDA No is required")]

        public string mdaNo { get; set; }
       // [Required(ErrorMessage = "IPPIS Number is required")]

        public string ippisNo { get; set; }
       // [Required(ErrorMessage = "Date of birth is required")]

        public DateTime dateOfBirthOrig { get; set; }
        public string dateOfBirth { get; set; }
       // [Required(ErrorMessage = "Gross pay is required")]

        public decimal grossPay { get; set; }
        //[Required(ErrorMessage = "Years in service is required")]

        public string yearsInService { get; set; }
        //[Required(ErrorMessage = "Net Pay is required")]

        public decimal netPay { get; set; }

        //[Required(ErrorMessage = "Bank account no is required")]

        public string bankAcctNo { get; set; }
        //[Required(ErrorMessage = "Loan amount is required")]

        public decimal loanAmount { get; set; }
        //[Required(ErrorMessage = "Number of repayment is required")]

        public string noOfRepayment { get; set; }
        //[Required(ErrorMessage = "phone number is required")]

        public string telephoneNo { get; set; }
        //[Required]
        //[EmailAddress]
        public string emailAddress { get; set; }
        //[Required(ErrorMessage = "Title is required")]

        public string title { get; set; }
        public string firstName { get; set; }
        public bool AcceptTerms { get; set; }
    }

    public class LoanSubmitResponse
    {
        public string message { get; set; }
    }
}