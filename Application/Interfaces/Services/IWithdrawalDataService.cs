using Application.ViewModels;

namespace Application.Interfaces.Services
{
    public interface IWithdrawalDataService
    {
        WithdrawalViewModel GetWithadrawl();
        void ResetMessage();
        void SetWithdrawal(WithdrawalViewModel withdrawal);
    }
}
