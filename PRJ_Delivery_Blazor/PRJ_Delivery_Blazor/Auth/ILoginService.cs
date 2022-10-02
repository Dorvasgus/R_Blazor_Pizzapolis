﻿using PRJ_Delivery_Blazor.DTOs;

namespace PRJ_Delivery_Blazor.Auth
{
    public interface ILoginService
    {
        Task Login(UserToken userToken);
        Task Logout();
        Task<bool> VerificarLogin();
    }
}
