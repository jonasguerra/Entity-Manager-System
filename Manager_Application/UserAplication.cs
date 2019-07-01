using System;
using Manager_Application.Adapter;
using Manager_Application.DTO;
using Manager_Domain.Interfaces;

namespace Manager_Application
{
    public class UserAplication
    {
        IUserRepository userRepository;

        public UserAplication(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
        public UserDTO Autenticar(string email, string password)
        {
            var user = this.userRepository.Find(email.ToLower());
            if (user == null)
            {
                throw new ApplicationException("Usuario não encontrado");
            }

            if (!user.PassswordIsValid(password))
            {
                return null;
            }
            else
            {
                return UserAdapter.ToDTO(user);
            }
        }

        public void TrocarSenha(string email, string newPassword)
        {
            if (string.IsNullOrEmpty(email))
            {
                throw new ApplicationException("E-mail deve ser informado");
            }

            if (string.IsNullOrEmpty(newPassword))
            {
                throw new ApplicationException("Nova senha deve ser informada");
            }

            var user = this.userRepository.Find(email);
            user.Password = newPassword;

            this.userRepository.Update(user);
        }
        
        public UserDTO GetByEmail(string email)
        {
            var user = userRepository.Find(email);
            return UserAdapter.ToDTO(user);
        }
    }
}