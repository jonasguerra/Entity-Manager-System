using System;

namespace Manager_Application.DTO
{
    public class AddressDTO
    {
        public Guid AddressId { get; set; }
        
        public string CEP { get; set; }

        public string Avenue { get; set; }

        public string Number { get; set; }

        public string Neighborhood { get; set; }

        public string City { get; set; }

        public string State { get; set; }
    }
}