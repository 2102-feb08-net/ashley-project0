using System;

namespace SlithyToves.Library.Models
{
    public class CustomerModel : ILog
    {
        public int CustomerId { get; private set; }
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
                if (value.Length == 0) 
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
                    throw new ArgumentOutOfRangeException("Please enter a valid 10 digit number, digits only, or leave empty.");
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
                _email = value;
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
                _zip = value;
            }
        }

        public string Log() => 
            $"ID: {CustomerId}\tName: {FirstName} {LastName}\tPhone: {Phone}\tEmail: {Email}\tZip: {Zip}";

        public CustomerModel() {}

        
        public CustomerModel(string firstName, string lastName, int id = 0)
        {
            FirstName = firstName;
            LastName = lastName;
            CustomerId = id;
        }

        public CustomerModel(string firstName, string lastName, String phone, string email, string zip, int id = 0)
        {
            FirstName = firstName;
            LastName = lastName;
            CustomerId = id;
            Phone = phone;
            Email = email;
            Zip = zip;
        }
    }
}
