using System;

namespace SellerWebMvc.Services.Exception
{
    public class IntegrityException : ApplicationException
    {
        public IntegrityException(string message) : base(message)
        {
        }
    }
}
