﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using VNH.Application.DTOs.Catalog.Users;
using VNH.Application.Services.Catalog.Users;

namespace VNH.WebAPi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> GetUserDetail()
        {
            var result = await _userService.GetUserDetail(User.Identity.Name);
            return result.IsSuccessed ? Ok(result) : BadRequest(result);
        }

        [HttpPut]
        [Authorize]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> Update([FromForm] UserUpdateDto request)
        {
            var result = await _userService.Update(request);
            return result.IsSuccessed ? Ok(result) : BadRequest(result);
        }
    }
}
