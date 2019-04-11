using App.PhoneBook.WebUILayer.IdentityEntities;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.FileProviders;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace App.PhoneBook.WebUILayer.Middlewares
{
    public static class ApplicationBuilderExtension
    {
        public static IApplicationBuilder UseNodeModules(this IApplicationBuilder app, string root)
        {
            var path = Path.Combine(root, "node_modules");

            var provider = new PhysicalFileProvider(path);

            var options = new StaticFileOptions();

            options.RequestPath = "/node_modules";

            options.FileProvider = provider;

            app.UseStaticFiles(options);

            return app;
        }
    }
}
