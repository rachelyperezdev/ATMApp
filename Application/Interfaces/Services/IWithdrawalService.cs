using Application.ViewModels;

namespace Application.Interfaces.Services
{
    public interface IWithdrawalService
    {
        WithdrawalViewModel Withdraw(WithdrawalViewModel withdrawal, int[] denominations);
    }
}
