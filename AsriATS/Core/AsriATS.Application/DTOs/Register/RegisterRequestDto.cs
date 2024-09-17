﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsriATS.Application.DTOs.Register
{
    public class RegisterRequestDto
    {
        public string? Username { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }   
        public string? Address { get; set; }
        public DateOnly Dob {  get; set; }
        public string? Sex { get; set; }
        public string? PhoneNumber { get; set; }
    }
}
