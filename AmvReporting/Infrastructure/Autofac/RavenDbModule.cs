﻿using AmvReporting.Infrastructure.Configuration;
using Autofac;
using Raven.Client;
using Raven.Client.Document;
using Raven.Client.Embedded;
using Raven.Client.Indexes;

namespace AmvReporting.Infrastructure.Autofac
{
    public class RavenDbModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            // Register the document store as single instance,
            // initializing it on first use.
            builder.Register(x =>
            {
                var store = new EmbeddableDocumentStore
                            {
                                DataDirectory = ConfigurationContext.Current.GetRavenDataPath()
                            };
                store.Conventions.DefaultQueryingConsistency = ConsistencyOptions.AlwaysWaitForNonStaleResultsAsOfLastWrite;
                store.Initialize();

                return store;
            }).As<IDocumentStore>()
              .SingleInstance();

            // Register the session, opening a new session per lifetime scope.
            builder.Register(x => x.Resolve<IDocumentStore>().OpenSession())
                 .As<IDocumentSession>()
                 .InstancePerLifetimeScope();


            base.Load(builder);
        }
    }
}