﻿using System.Collections.Generic;

namespace LibraryProject.API.DTOs.Responses
{
    public class AuthorResponse
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public List<AuthorBookResponse> Books { get; set; } = new();
    }
}
