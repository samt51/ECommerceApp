namespace ECommerce.Shared.AOP.Middleware.Exceptions
{
    public class ClientSideException : Exception
    {
        public ClientSideException(string message) : base(message)
        {

        }
    }
}
