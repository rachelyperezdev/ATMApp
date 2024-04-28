using Application.Interfaces.Services;
using Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ATM.Controllers
{
    public class DispensationController : Controller
    {
        private readonly IDispensationDataService _dispensationDataService;
        private readonly IWithdrawalDataService _withdrawalDataService;
        public DispensationController(IDispensationDataService dispensationDataService, IWithdrawalDataService withdrawalDataService)
        {
            _dispensationDataService = dispensationDataService;
            _withdrawalDataService = withdrawalDataService;
        }
        public IActionResult Index()
        {
            _withdrawalDataService.ResetMessage();
            return View(_withdrawalDataService.GetWithadrawl());
        }

        [HttpPost]
        public IActionResult Index(WithdrawalViewModel withdrawalVm)
        {
            _dispensationDataService.SetDispensationType(withdrawalVm);
            return RedirectToRoute(new { controller="Dispensation", action="Index" });
        }
    }
}
