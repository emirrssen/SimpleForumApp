﻿using SimpleForumApp.Application.UnitOfWork.Core;
using SimpleForumApp.Domain.DTOs.Auth;
using SimpleForumApp.Domain.Results;

namespace SimpleForumApp.Application.Services.Auth
{
    public interface IAuthService : IService
    {
        Task<ResultWithData<Token>> LoginAsync(string email, string password);
        Task<ResultWithData<Token>> LoginWithRefreshTokenAsync(string refreshToken);
        Task<Result> SendResetPasswordMailAsync(string email);
        Task<Result> ValidatePasswordTokenAsync(string token, string email);
        Task<Result> ResetPasswordAsync(long id, string token, string password);
        Task<Result> ChangePasswordAsync(string email, string currentPassword, string newPassword);
    }
}
