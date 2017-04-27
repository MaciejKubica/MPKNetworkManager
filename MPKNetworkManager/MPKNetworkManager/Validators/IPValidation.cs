using System;
using System.Net;

namespace MPKNetworkManager.Validators
{
    public class IPValidator : IValidator
    {
        public ValidateResult DoValidation(string itemToValidate)
        {
            ValidateResult result = new ValidateResult();
            try
            {
                IPAddress address = IPAddress.Any;
                if (IPAddress.TryParse(itemToValidate, out address))
                {
                    result.IsValid = true;
                    result.ValidationMessage = "IP OK";
                    result.ValidateCode = 0;
                }
                else
                {
                    result.IsValid = false;
                    result.ValidationMessage = "IP Is not correct";
                    result.ValidateCode = 1;
                }
            }
            catch (Exception ex)
            {
                result.IsValid = false;
                result.ValidationMessage = ex.Message;
                result.ValidateCode = ex.HResult;
            }

            return result;
        }

        public ValidateResult DoValidationUsingMask(string itemToValidate, string mask)
        {
            return DoValidation(itemToValidate);
        }
    }
}
