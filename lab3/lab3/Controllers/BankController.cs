using lab3.Models;
using Lab3;
using Microsoft.AspNetCore.Mvc;

namespace lab3.Controllers
{
    public class BankController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Predict(BankInputModel inputModel)
        {
            var result = BankMarketing.Predict(new BankMarketing.ModelInput
            {
                Age = inputModel.Age,
                Job = inputModel.Job,
                Marital = inputModel.Marital,
                Education = inputModel.Education,
                Default = inputModel.Default,
                Balance = inputModel.Balance,
                Housing = inputModel.Housing,
                Loan = inputModel.Loan,
                Contact = inputModel.Contact,
                Day = inputModel.Day,
                Month = inputModel.Month,
                Duration = inputModel.Duration,
                Campaign = inputModel.Campaign,
                Pdays = inputModel.Pdays,
                Previous = inputModel.Previous,
                Poutcome = inputModel.Poutcome,
            });
            System.Diagnostics.Debug.WriteLine(inputModel.Age);
            var viewModel = new BankPredictionViewModel
            {
                InputModel = inputModel,
                PredictionResult = result
            };
            
            return View("~/Views/Home/Result.cshtml", viewModel);
        }
    }
}
