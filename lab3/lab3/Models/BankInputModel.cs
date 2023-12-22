using Lab3;
using System.ComponentModel;

namespace lab3.Models
{

    public class BankInputModel
    {
        [Description("Age")]
        [DisplayName("Age")]
        public int Age { get; set; }
        [Description("Job")]
        [DisplayName("Job")]
        public string Job { get; set; }
        [Description("Marital status")]
        [DisplayName("Marital")]
        public string Marital { get; set; }
        [Description("Education")]
        [DisplayName("Education")]
        public string Education { get; set; }
        [Description("Has credit in default?")]
        [DisplayName("Default")]
        public bool Default { get; set; }
        [Description("Average yearly balance(euro)")]
        [DisplayName("Balance")]
        public int Balance { get; set; }
        [Description("Has housing loan?")]
        [DisplayName("Housing")]
        public bool Housing { get; set; }
        [Description("Has personal loan?")]
        [DisplayName("Loan")]
        public bool Loan { get; set; }
        [Description("Contact communication type (cellular, telephone)")]
        [DisplayName("Contact")]
        public string Contact { get; set; }
        [Description("Last contact day of the week")]
        [DisplayName("Day")]
        public int Day { get; set; }
        [Description("Last contact month of year")]
        [DisplayName("Month")]
        public string Month { get; set; }
        [Description("last contact duration, in seconds")]
        [DisplayName("Duration")]
        public int Duration { get; set; }
        [Description("Number of contacts performed during this campaign and for this client")]
        [DisplayName("Campaign")]
        public int Campaign { get; set; }
        [Description("Number of days that passed by after the client was last contacted from a previous campaign")]
        [DisplayName("Pdays")]
        public int Pdays { get; set; }
        [Description("Number of contacts performed before this campaign and for this client")]
        [DisplayName("Previous")]
        public int Previous { get; set; }
        [Description("Outcome of the previous marketing campaign")]
        [DisplayName("Poutcome")]
        public string Poutcome { get; set; }
    }

    public class BankPredictionViewModel
    {
        public BankInputModel InputModel { get; set; }
        public BankMarketing.ModelOutput PredictionResult { get; set; }
    }
}
