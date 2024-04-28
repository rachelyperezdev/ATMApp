using Application.Interfaces.Services;
using Application.Repository;
using Application.ViewModels;

namespace Application.Service.Withdrawal
{
    public class WithdrawalService : IWithdrawalService
    {
        public WithdrawalViewModel Withdraw(WithdrawalViewModel withdrawal, int[] denominations)
        {
            int[] bills = new int[denominations.Length];
            var amount = withdrawal.Amount;
            withdrawal.Response = new ResponseViewModel()
            {
                Error = false,
                Message = $"Withdrawal of ${withdrawal.Amount}"
            };

            foreach (int denomination in denominations)
            {
                if (withdrawal.Amount >= denomination)
                {
                    bills[Array.IndexOf(denominations, denomination)] = (int)(withdrawal.Amount / denomination);
                    withdrawal.Amount %= denomination;

                    withdrawal.Response.Message += $"\n\n{bills[Array.IndexOf(denominations, denomination)]} bills of {denomination}";
                }
            }

            if (withdrawal.Amount > 0)
            {
                withdrawal.Response.Error = true;
                withdrawal.Response.Message = $"Withdrawal of ${amount} is not valid according to the selected dispensation mode. Enter a valid amount or change dispensation mode.";
            }

            WithdrawalRepository.Instance.Withdrawal.Response.Error = withdrawal.Response.Error;
            WithdrawalRepository.Instance.Withdrawal.Response.Message = withdrawal.Response.Message;

            return WithdrawalRepository.Instance.Withdrawal;
        }
    }
}
