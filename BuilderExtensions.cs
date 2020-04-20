﻿using Microsoft.AspNetCore.Builder;
using SiteMaps.NET.Models;

namespace SiteMaps.NET
{
    public static class BuilderExtensions
    {
        public static IApplicationBuilder UseSitemap(this IApplicationBuilder app,
            bool parseControllers, bool isSSL)
        {
            return app.UseMiddleware<SiteMapsMiddleware>(parseControllers, isSSL);
        }

        public static IApplicationBuilder UseRobots(this IApplicationBuilder app)
        {
            return app.UseMiddleware<RobotsMiddleware>();
        }

        public static IApplicationBuilder UseRobots(this IApplicationBuilder app, RobotRule[] robotRules)
        {
            return app.UseMiddleware<RobotsMiddleware>(robotRules);
        }
    }
}
