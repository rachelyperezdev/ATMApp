using Application.ViewModels;

namespace Application.Interfaces.Services
{
    public interface IDispensationDataService
    {
        string GetDispensationType();
        void SetDispensationType(WithdrawalViewModel withdrawal);
    }
}
