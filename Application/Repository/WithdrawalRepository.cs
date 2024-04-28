using Application.Enums;
using Application.ViewModels;

namespace Application.Repository
{
    public sealed class WithdrawalRepository
    {
        private static WithdrawalRepository _instance;
        public WithdrawalViewModel Withdrawal;

        private WithdrawalRepository(WithdrawalViewModel withdrawal)
        {
            Withdrawal = withdrawal; 
        }

        public static WithdrawalRepository Instance
        {
            get
            {
                if(_instance == null)
                    _instance = new WithdrawalRepository(new WithdrawalViewModel { DispensationType = Dispensation.Efficient.ToString(), Response = new ResponseViewModel() });

                return _instance;
            }
        }
    }
}
