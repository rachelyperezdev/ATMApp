using Application.Interfaces.Services;
using Application.ViewModels;

namespace Application.Service.Dispensation
{
    public class TwoHundredAndOneThousandDispensationService : IDispensationStrategy
    {
        private readonly IWithdrawalService _withdrawalService;
        public TwoHundredAndOneThousandDispensationService(IWithdrawalService withdrawalService)
        {
            _withdrawalService = withdrawalService;
        }
        public WithdrawalViewModel Dispensate(WithdrawalViewModel withdrawal)
        {
            return _withdrawalService.Withdraw(withdrawal, new int[] { 1000, 200 });
        }
    }
}
