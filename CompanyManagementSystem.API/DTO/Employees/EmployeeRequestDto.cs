﻿namespace CompanyManagementSystem.API.DTO;

public class EmployeeRequestDto
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Position { get; set; }
    public string Email { get; set; }
    public decimal Salary { get; set; }
}