using Application.Interfaces.Services;
using Application.Repository;
using Application.ViewModels;

namespace Application.Service.Dispensation
{
    public class DispensationDataService : IDispensationDataService
    {
        public string GetDispensationType()
        {
            return WithdrawalRepository.Instance.Withdrawal.DispensationType;
        }

        public void SetDispensationType(WithdrawalViewModel withdrawal)
        {
            WithdrawalRepository.Instance.Withdrawal.DispensationType = withdrawal.DispensationType;
        }
    }
}
