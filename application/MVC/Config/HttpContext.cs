﻿namespace System.Web
{
    public static class HttpContext2
    {
        private static Microsoft.AspNetCore.Http.IHttpContextAccessor m_httpContextAccessor;

        public static void Configure(Microsoft.AspNetCore.Http.IHttpContextAccessor httpContextAccessor)
        {
            m_httpContextAccessor = httpContextAccessor;
        }

        public static Microsoft.AspNetCore.Http.HttpContext Current => m_httpContextAccessor.HttpContext;
    }
}