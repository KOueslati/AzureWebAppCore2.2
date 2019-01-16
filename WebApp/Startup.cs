using System;
using System.IdentityModel.Tokens.Jwt;
using System.Net.Http;
using System.Threading.Tasks;
using WebApp.BL;
using IdentityModel.Client;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Rest;
using UWProgramApi.v1_0;
using log4net;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace WebApp
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration;
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            var authenticationSection = Configuration.GetSection("Authentication");
            JwtSecurityTokenHandler.DefaultInboundClaimTypeMap.Clear();
            //var accessToken = "";

            services.AddAuthentication(options =>
                {
                    options.DefaultScheme = authenticationSection.GetValue<string>("CookieName"); ;
                    options.DefaultChallengeScheme = "oidc";
                })
                .AddCookie(options =>
                {
                    options.Cookie.Name = authenticationSection.GetValue<string>("CookieName");
                    options.Cookie.HttpOnly = true;
                    options.SlidingExpiration = true;
                    options.ExpireTimeSpan = TimeSpan.FromMinutes(30);
                })
                .AddOpenIdConnect("oidc", options =>
                {
                    options.SignInScheme = authenticationSection.GetValue<string>("CookieName"); ;
                    options.ClientId = authenticationSection.GetValue<string>("ClientId");
                    options.ClientSecret = authenticationSection.GetValue<string>("ClientSecret");
                    options.Authority = authenticationSection.GetValue<string>("AuthorityUrl");
                    options.GetClaimsFromUserInfoEndpoint = true;
                    options.ResponseType = "code id_token";
                    options.Scope.Clear();
                    options.Scope.Add("openid");
                    //options.Scope.Add("profile");
                    options.RequireHttpsMetadata = false;
                    options.SaveTokens = true;
                    
                    //options.Events = new Microsoft.AspNetCore.Authentication.OpenIdConnect.OpenIdConnectEvents()
                    //{
                    //    OnAuthorizationCodeReceived = async context =>
                    //    {
                    //        //if (context.Principal.Identity.IsAuthenticated)
                    //        //{
                    //        //    accessToken = await context.HttpContext.GetTokenAsync("Cookies", "access_token");

                    //        //}

                    //        // var client = new HttpClient();
                    //        //var result = client.RequestTokenAsync(new TokenRequest()
                    //        //{
                    //        //    GrantType = "client_credentials",
                    //        //    Address = "https://connect-dev.axa-cs.intraxa/connect/token",
                    //        //    ClientId = "UWEcosystem_Core",
                                
                    //        //    ClientSecret = "secret"}).Result;

                    //        //var res = client.RequestAuthorizationCodeTokenAsync(new AuthorizationCodeTokenRequest()
                    //        //{
                    //        //    Code = context.ProtocolMessage.Code,
                    //        //    RedirectUri = "http://localhost:50000/signin-oidc",
                    //        //    Address = "https://connect-dev.axa-cs.intraxa/connect/token"
                    //        //}).Result;

                    //        var tokenClient = new TokenClient("https://connect-dev.axa-cs.intraxa/connect/token", "UWEcosystem_Core", "secret");
                    //        var tokken = await tokenClient.RequestAuthorizationCodeAsync(context.ProtocolMessage.Code,
                    //            "http://localhost:50000/");
                    //        accessToken = tokken.AccessToken;
                    //        Debug.WriteLine($"Access_Token : {accessToken}");

                    //        await Task.FromResult(0);
                    //    }
                    //};

                });
            
            //services.AddTransient<IUWProgramApiClient>(s =>
            //    new UWProgramApiClient(new Uri(Configuration.GetValue<string>("app:UWProgramApi_baseUri")),
            //        new TokenCredentials(accessToken)));
            //services.AddTransient<IUWProgramService, UWProgramService>();

            services.AddLogging(builder => builder.AddLog4Net());

            services.AddMvc().AddRazorPagesOptions(options =>
            {
                options.Conventions.AddPageRoute("/Home", "");
                options.Conventions.AuthorizeFolder("/");
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            //loggerFactory.AddLog4Net();
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseAuthentication();
            app.UseStaticFiles();
            app.UseMvc();
        }
    }
}