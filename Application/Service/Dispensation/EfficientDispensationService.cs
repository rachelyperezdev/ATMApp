using Application.Interfaces.Services;
using Application.ViewModels;

namespace Application.Service.Dispensation
{
    public class EfficientDispensationService : IDispensationStrategy
    {
        private readonly IWithdrawalService _withdrawalService;
        public EfficientDispensationService(IWithdrawalService withdrawalService)
        {
            _withdrawalService = withdrawalService;
        }
        public WithdrawalViewModel Dispensate(WithdrawalViewModel withdrawal)
        {
            return _withdrawalService.Withdraw(withdrawal, new int[] { 1000, 500, 200, 100 });
        }
    }
}
