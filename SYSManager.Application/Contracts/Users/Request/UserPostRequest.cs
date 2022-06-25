using System;
using System.Collections.Generic;
using System.Text;

namespace SYSManager.Application.Contracts.Users.Request
{
    /// <summary>
    /// Classe responsável pela requisição para cadastrar um novo usuário
    /// </summary>
    public class UserPostRequest
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

    }
}
