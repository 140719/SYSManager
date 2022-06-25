using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using SYSManager.Application.Contracts.Users.Request;
using SYSManager.Application.Helpers;
using SYSManager.Application.Services;
using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace SYSManager.API.Admin.controllers
{
    [ApiVersion("1.0")]
    [Microsoft.AspNetCore.Mvc.Route("api/v{version:apiVersion}/[controller]")]


    public class AccountController: ControllerBase
    {
        private readonly UserService _userService;
        public AccountController(UserService service)
        {
            this._userService = service;
        }
        [HttpPost("create-account")]
        public async Task<IActionResult> Post([FromBody] UserPostRequest request)
        {
            Console.WriteLine("Inicio do processo");
            var response = await _userService.PostAsync(request);
            return Utils.Convert(response);
        }

             
        [HttpPostAttribute("login")]
        public async Task<IActionResult> PostLogin([FromBody] UserPostRequest request)
        {
            Console.WriteLine("Início");
            return Utils.Convert(new ResultData(false));
        }
    }
}
