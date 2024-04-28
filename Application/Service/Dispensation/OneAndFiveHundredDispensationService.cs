using Application.Interfaces.Services;
using Application.ViewModels;

namespace Application.Service.Dispensation
{
    public class OneAndFiveHundredDispensationService : IDispensationStrategy
    {
        private readonly IWithdrawalService _withdrawalService;
        public OneAndFiveHundredDispensationService(IWithdrawalService withdrawalService)
        {
            _withdrawalService = withdrawalService;
        }
        public WithdrawalViewModel Dispensate(WithdrawalViewModel withdrawal)
        {
            return _withdrawalService.Withdraw(withdrawal, new int[] { 500, 100 });
        }
    }
}
