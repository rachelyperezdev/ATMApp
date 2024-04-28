using Application.Interfaces.Services;
using Application.ViewModels;

namespace Application.Service.Dispensation
{
    public class DispensationContext : IDispensationContext
    {
        private IDispensationStrategy _dispensationStrategy;

        public DispensationContext(IDispensationStrategy dispensationStrategy)
        {
            _dispensationStrategy = dispensationStrategy;
        }

        public WithdrawalViewModel ExecuteStrategy(WithdrawalViewModel withdrawal)
        {
            return _dispensationStrategy.Dispensate(withdrawal);
        }

        public void SetStrategy(IDispensationStrategy dispensationStrategy)
        
        {
            _dispensationStrategy = dispensationStrategy;
        }
    }
}
