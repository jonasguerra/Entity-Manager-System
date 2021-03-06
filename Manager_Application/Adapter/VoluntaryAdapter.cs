using System;
using Manager_Application.DTO;
using Manager_Domain.Entities;

namespace Manager_Application.Adapter
{
    public static class VoluntaryAdapter
    {
        public static VoluntaryDTO ToDTO(Voluntary voluntary)
        {
            return new VoluntaryDTO()
            {
                VoluntaryId = voluntary.VoluntaryId,
                UserId = voluntary.UserId,
                IsApproved = voluntary.IsApproved,
                Name = voluntary.Name,
                Email = voluntary.Email,
                Password = voluntary.Password,
                Phone = voluntary.Phone,
                SocialNetwork = voluntary.SocialNetwork,
                Affinities = AffinityAdapter.ListToDTO(voluntary.Affinities),
                Address = new AddressDTO()
                {
                    AddressId = voluntary.Address.AddressId,
                    CEP = voluntary.Address.CEP,
                    Avenue = voluntary.Address.Avenue,
                    Number = voluntary.Address.Number,
                    Neighborhood = voluntary.Address.Neighborhood,
                    City = voluntary.Address.City,
                    State = voluntary.Address.State
                }
            };
        }

        public static Voluntary ToDomain(VoluntaryDTO voluntary)
        {
            return new Voluntary()
            {
                VoluntaryId = voluntary.VoluntaryId,
                UserId = voluntary.UserId,
                IsApproved = voluntary.IsApproved,
                Name = voluntary.Name,
                Email = voluntary.Email,
                Phone = voluntary.Phone,
                Password = voluntary.Password,
                SocialNetwork = voluntary.SocialNetwork, 
                Affinities = AffinityAdapter.ListToDomain(voluntary.Affinities),
                Address = new Address()
                {
                    AddressId = voluntary.Address.AddressId,
                    CEP = voluntary.Address.CEP,
                    Avenue = voluntary.Address.Avenue,
                    Number = voluntary.Address.Number,
                    Neighborhood = voluntary.Address.Neighborhood,
                    City = voluntary.Address.City,
                    State = voluntary.Address.State
                }
            };
        }
    }
}