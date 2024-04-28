using Application.ViewModels;

namespace Application.Interfaces.Services
{
    public interface IDispensationContext
    {
        void SetStrategy(IDispensationStrategy dispensationStrategy);
        WithdrawalViewModel ExecuteStrategy(WithdrawalViewModel withdrawal);
    }
}
