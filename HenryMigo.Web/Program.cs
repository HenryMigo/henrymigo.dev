// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace HenryMigo.Web
{
    /// <summary>
    /// Program class.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main entry point for application.
        /// </summary>
        /// <param name="args">Application arguments.</param>
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        /// <summary>
        /// Main method to create host.
        /// </summary>
        /// <param name="args">Application arguments.</param>
        /// <returns>Returns IHostBuilder.</returns>
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
