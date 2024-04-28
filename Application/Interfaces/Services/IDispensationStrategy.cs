using Application.ViewModels;

namespace Application.Interfaces.Services
{
    public interface IDispensationStrategy
    {
        WithdrawalViewModel Dispensate(WithdrawalViewModel withdrawal);
    }
}
