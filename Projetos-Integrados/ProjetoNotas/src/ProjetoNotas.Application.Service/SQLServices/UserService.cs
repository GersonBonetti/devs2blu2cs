﻿using ProjetoNotas.Domain.DTO;
using ProjetoNotas.Domain.Interfaces.IRepositories;
using ProjetoNotas.Domain.Interfaces.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoNotas.Application.Service.SQLServices
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public Task<int> Delete(UserDTO entity)
        {
            throw new NotImplementedException();
        }

        public List<UserDTO> FindAll()
        {
            return _userRepository.FindAll()
                                   .Select(u => new UserDTO
                                   {
                                       Id = u.Id,
                                       Name = u.Name,
                                       Login = u.Login,
                                       Password= u.Password
                                   }).ToList();
        }

        public Task<UserDTO> FindById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> Save(UserDTO entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> Update(UserDTO entity)
        {
            throw new NotImplementedException();
        }
    }
}