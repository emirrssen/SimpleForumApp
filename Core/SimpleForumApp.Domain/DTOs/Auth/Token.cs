﻿namespace SimpleForumApp.Domain.DTOs.Auth
{
    public class Token
    {
        public string AccessToken { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string RefreshToken { get; set; }
    }
}
