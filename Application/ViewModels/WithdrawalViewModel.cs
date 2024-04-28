using System.ComponentModel.DataAnnotations;

namespace Application.ViewModels
{
    public class WithdrawalViewModel
    {
        [Required(ErrorMessage = "Must enter an amount to withdraw")]
        [DataType(DataType.Currency)]
        public decimal Amount { get; set; }

        public string DispensationType { get; set; }
        public ResponseViewModel? Response { get; set; }

    }
}
