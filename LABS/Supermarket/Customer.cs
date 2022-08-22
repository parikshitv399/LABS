using System;

namespace Supermarket
{
    [Serializable]
    public class Customer
    {
        public Customer()
        {
        }

        public string Email { get; set; }
        public string Password { get; set; }
    }
}