﻿using CompanyManagementSystem.API.Models;

namespace CompanyManagementSystem.API.DTO;

public class LoginResponseDto
{
    public string Token { get; set; }
    public string Username { get; set; }
    public string Role { get; set; }
}