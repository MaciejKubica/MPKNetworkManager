
namespace MPKNetworkManager.Validators
{
    public interface IValidator
    {
        ValidateResult DoValidationUsingMask(string itemToValidate, string mask);

        ValidateResult DoValidation(string itemToValidate);
    }

    public class ValidateResult
    {
        public bool IsValid { get; set; }

        public string ValidationMessage { get; set; }

        public int ValidateCode { get; set; }
    }
}
