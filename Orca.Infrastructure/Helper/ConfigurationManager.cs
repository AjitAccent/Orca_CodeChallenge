﻿using Microsoft.Extensions.Configuration;

namespace Orca.Infrastructure.Helper
{
    static class ConfigurationManager
    {
        public static IConfiguration AppSetting
        {
            get;
        }

        static ConfigurationManager()
        {
            AppSetting = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
        }
    }
}
