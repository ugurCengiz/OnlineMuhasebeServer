﻿using Microsoft.Extensions.Options;
using OnlineMuhasebeServer.Infrasturcture.Authentication;

namespace OnlineMuhasebeServer.WebApi.OptionsSetup
{
    public sealed class JwtOptionsSetup :IConfigureOptions<JwtOptions>
    {
        private readonly IConfiguration _configuration;
        private const string Jwt = nameof(Jwt);
        public JwtOptionsSetup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void Configure(JwtOptions options)
        {
            _configuration.GetSection(Jwt).Bind(options);

        }
    }
}
