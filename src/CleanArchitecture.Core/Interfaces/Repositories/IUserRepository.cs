﻿using System;
using System.Collections.Generic;
using CleanArchitecture.Core.Entities;

namespace CleanArchitecture.Core.Interfaces.Repositories
{
    public interface IUserRepository
    {
        Usuario Add(DateTime dataNascimento, string email, string nome, string senha, char sexo);
        IEnumerable<Usuario> GetAllUsers();
        Usuario GetById(long id);
        Usuario Update(long id, string email, string nome, string senha);
        void DeleteById(long id);
    }
}
