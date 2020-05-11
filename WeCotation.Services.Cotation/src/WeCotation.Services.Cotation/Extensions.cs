using Autofac;
using MicroS_Common.Domain;
using MicroS_Common.Messages;
using MicroS_Common.Mongo;
using MicroS_Common.RabbitMq;
using MicroS_Common.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Reflection;

namespace WeCotation.Services.Cotation
{
    public static class Extensions
    {
       /* public static ContainerBuilder AddRepositories(this ContainerBuilder builder, params Assembly[] assemblies)
        {
            var typesWithMyAttribute =
                from a in assemblies
                from t in a.GetTypes()
                let attributes = t.GetCustomAttributes(typeof(MongoDocumentAttribute), true)
                where attributes != null && attributes.Length > 0
                select new { Type = t, Attributes = attributes.Cast<MongoDocumentAttribute>() };
            foreach (var item in typesWithMyAttribute)
            {

                builder.AddMongoRepositoryByType(item.Type, item.Attributes.First().Name);
            }
            return builder;

            
        }*/
       /* public static IServiceCollection AddRepositories(this IServiceCollection services, params Assembly[] assemblies)
        {
            var typesWithMyAttribute_ =
                from a in assemblies
                from t in a.GetTypes()
                let attributes = t.GetCustomAttributes(typeof(RepositoryAttribute), true)
                where attributes != null && attributes.Length > 0
                select new { Type = t, Attributes = attributes.Cast<RepositoryAttribute>() };
            foreach (var item in typesWithMyAttribute_)
            {
                services.AddScoped(item.Attributes.First().Type, item.Type);
            }
            return services;
        }*/
        /*public static void SubscribeDefaultCommands(this IBusSubscriber bus,params Assembly[] assemblies)
        {
            var typesWithMyAttribute =
                from a in assemblies
                from t in a.GetTypes()
                let attributes = t.GetCustomAttributes(typeof(OnRejectedAttribute), true)
                where attributes != null && attributes.Length > 0
                select new { Type = t, Attributes = attributes.Cast<OnRejectedAttribute>() };
            foreach (var item in typesWithMyAttribute)
            {
                var type = item.Attributes.First().Type;
                bus.SubscribeCommandByType(item.Type, onError: (c, e) => {
                    var o = (BaseRejectedEvent)c;
                    return (IRejectedEvent) Activator.CreateInstance(type, o.Id, o.Reason, o.Code);
                });
                
            }
        }*/
    }
}
