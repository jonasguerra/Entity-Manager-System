using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Manager_API.Models.Voluntary
{
    public class Voluntary : User
    {
        public Guid VoluntaryId { get; set; }
        public Address Address { get; set; }
        
        [Display(Name = "Nome")]
        [Required(ErrorMessage = "O {0} deve ser informado.")]
        [StringLength(60, MinimumLength = 5, ErrorMessage = "Minimo {2} caracteres")]
        public string Name { get; set; }
        
        
        [Display(Name = "Telefone")]
        [Required(ErrorMessage = "{0} deve ser informado")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "Apenas numeros devem ser informados")]
        [StringLength(20, MinimumLength = 8, ErrorMessage = "Minimo {2} caracteres")]
        public string Phone { get; set; }

        [Display(Name = "Afinidade")]
        [Required(ErrorMessage = "{0} deve ser informada")]
        public string Affinity { get; set; }

        [Display(Name = "Redes Sociais")] 
        public string SocialNetwork { get; set; }

        public List<Affinity> Affinities { get; set; }
        
        public Voluntary()
        {
            IsVoluntary = true;
        }
    }
}