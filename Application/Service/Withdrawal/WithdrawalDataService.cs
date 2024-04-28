using Application.Interfaces.Services;
using Application.Repository;
using Application.ViewModels;

namespace Application.Service.Withdrawal
{
    public class WithdrawalDataService : IWithdrawalDataService
    {
        public WithdrawalViewModel GetWithadrawl()
        {
            return WithdrawalRepository.Instance.Withdrawal;
        }

        public void SetWithdrawal(WithdrawalViewModel withdrawal)
        {
            WithdrawalRepository.Instance.Withdrawal = withdrawal;
        }

        public void ResetMessage()
        {
            WithdrawalRepository.Instance.Withdrawal.Response.Message = string.Empty;
        }
    }
}
