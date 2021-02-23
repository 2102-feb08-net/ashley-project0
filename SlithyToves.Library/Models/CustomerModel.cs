using System;

namespace SlithyToves.Library.Models
{
    public class CustomerModel
    {
        public int CustomerId { get; set; }
        private string _firstName;
        private string _lastName;
        private string _phone;
        private string _email;
        private string _zip;

        public string FirstName 
        {
            get => _firstName;
            set
            {
                if (value.Length == 0) 
                {
                    throw new ArgumentException("First name must not be empty.", nameof(value));
                }
                _firstName = value;
            }
        }

        public string LastName 
        {
            get => _lastName;
            set 
            {
                if (string.IsNullOrEmpty(LastName)) 
                {
                    throw new ArgumentException("Last name must not be empty.", nameof(value));
                }
                _lastName = value;
            }
        }

        #nullable enable
        public string Phone
        {
            get => _phone;
            set
            {
                if (value.Length > 10) 
                {
                    throw new ArgumentOutOfRangeException("Please enter a valid 10 digit number or leave empty.");
                }
                _phone = value;
            }
        }

        #nullable enable
        public string Email
        {
            get => _email;
            set
            {
                if (!value.Contains("@") || !value.Contains("."))
                {
                    throw new ArgumentNullException("Please enter a vaild email or leave empty.");
                }
                _email = Email;
            }
        }
        
        #nullable enable
        public string Zip
        {
            get => _zip;
            set 
            {
                if (value.Length != 5)
                {
                    throw new ArgumentException("Please enter a valid zip code or leave empty.");
                }
                _zip = Zip;
            }
        }
    }
}
