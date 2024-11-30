using System;

namespace SellerWebMvc.Services.Exception
{
    public class NotFoundException : ApplicationException
    {
        public NotFoundException(string message) : base(message)
        {
        }
    }
}
