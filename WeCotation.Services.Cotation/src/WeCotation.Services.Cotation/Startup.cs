using Autofac;
using AutoMapper;
using Consul;
using MicroS_Common;
using MicroS_Common.Consul;
using MicroS_Common.Dispatchers;
using MicroS_Common.Jeager;
using MicroS_Common.Mongo;
using MicroS_Common.Mvc;
using MicroS_Common.RabbitMq;
using MicroS_Common.Redis;
using MicroS_Common.Repository;
using MicroS_Common.Swagger;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using WeCotation.domain;

namespace WeCotation.Services.Cotation
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCustomMvc();
            services.AddSwaggerDocs();
            services.AddConsul();
            services.AddJaeger();
            //services.AddOpenTracing();
            services.AddRedis();
            services.AddInitializers(typeof(IMongoDbInitializer));
            services.AddAutoMapper(Assembly.GetEntryAssembly(), typeof(DomainProfile).Assembly);
            //Add Local Repository factory that be encapsulate by IMongoRepository
            services.AddRepositories(Assembly.GetEntryAssembly());
        }
        /// <summary>
        /// Need by autofac DI
        /// </summary>
        /// <param name="builder"></param>
        public void ConfigureContainer(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(Assembly.GetEntryAssembly()).AsImplementedInterfaces();
            builder.RegisterAssemblyTypes(typeof(DomainProfile).Assembly).AsImplementedInterfaces();
            builder.AddRabbitMq();
            builder.AddMongo(typeof(DatabaseSeeder)).AddRepositories(Assembly.GetEntryAssembly(), typeof(DomainProfile).Assembly);
            builder.AddDispatchers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(
            IApplicationBuilder app, 
            IWebHostEnvironment env, 
            IHostApplicationLifetime applicationLifetime, 
            IConsulClient client,
            IStartupInitializer startupInitializer)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            
            app.UseAllForwardedHeaders();
            app.UseSwaggerDocs();
            app.UseErrorHandler();
            app.UseServiceId();
#pragma warning disable MVC1005
            app.UseMvc();
#pragma warning restore MVC1005
            app.UseRabbitMq().SubscribeOnRejected(typeof(DomainProfile).Assembly);

                

            var consulServiceId = app.UseConsul();
            applicationLifetime.ApplicationStopped.Register(() =>
            {
                client.Agent.ServiceDeregister(consulServiceId);
            });

            startupInitializer.InitializeAsync();
        }
    }
}
