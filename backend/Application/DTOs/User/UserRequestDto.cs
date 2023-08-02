﻿using Microsoft.AspNetCore.Http;

namespace Application.DTOs.User
{
    public class UserRequestDto
    {
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
        public IFormFile? Image { get; set; }
        public int? State { get; set; }
    }
}