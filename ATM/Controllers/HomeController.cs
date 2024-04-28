using Application.Interfaces.Services;
using Application.Service.Dispensation;
using Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ATM.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWithdrawalService _withdrawalService;
        private readonly IWithdrawalDataService _withdrawalDataService;
        private readonly IDispensationContext _dispensationContext;

        public HomeController(IWithdrawalService withdrawalService,
                              IWithdrawalDataService withdrawalDataService,
                              IDispensationContext dispensationContext)
        {
            _withdrawalService = withdrawalService;
            _withdrawalDataService = withdrawalDataService;
            _dispensationContext = dispensationContext;
        }

        public IActionResult Index()
        {
            var withdrawal = _withdrawalDataService.GetWithadrawl();
            return View(withdrawal);
        }

        [HttpPost]
        public IActionResult Index(WithdrawalViewModel withdrawalVm)
        {
            switch (withdrawalVm.DispensationType)
            {
                case "Efficient":
                    _dispensationContext.SetStrategy(new EfficientDispensationService(_withdrawalService));
                    break;
                case "OneHundred_FiveHundred":
                    _dispensationContext.SetStrategy(new OneAndFiveHundredDispensationService(_withdrawalService));
                    break;
                case "TwoHundred_OneThousand":
                    _dispensationContext.SetStrategy(new TwoHundredAndOneThousandDispensationService(_withdrawalService));
                    break;
                default:
                    _dispensationContext.SetStrategy(new EfficientDispensationService(_withdrawalService));
                    break;
            }
            
            _dispensationContext.ExecuteStrategy(withdrawalVm);

            return RedirectToAction("Index");
        }
    }
}
