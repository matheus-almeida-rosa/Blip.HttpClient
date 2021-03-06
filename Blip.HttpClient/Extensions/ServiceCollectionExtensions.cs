﻿using System.Collections.Generic;
using Blip.HttpClient.Factories;
using Lime.Protocol;
using Microsoft.Extensions.DependencyInjection;
using Take.Blip.Client.Extensions.ArtificialIntelligence;
using Take.Blip.Client.Extensions.Broadcast;
using Take.Blip.Client.Extensions.Bucket;
using Take.Blip.Client.Extensions.Contacts;
using Take.Blip.Client.Extensions.Delegation;
using Take.Blip.Client.Extensions.Directory;
using Take.Blip.Client.Extensions.EventTracker;
using Take.Blip.Client.Extensions.HelpDesk;
using Take.Blip.Client.Extensions.Profile;
using Take.Blip.Client.Extensions.Resource;
using Take.Blip.Client.Extensions.Scheduler;
using Take.Blip.Client.Extensions.Threads;
using Take.Blip.Client.Extensions.Tunnel;

namespace Blip.HttpClient.Extensions
{
    /// <summary>
    /// Extensions for the IServiceCollection dependency injection interface
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Registers BLiP's extensions on the services collection
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection RegisterBlipExtensions(this IServiceCollection services)
        {
            services.AddSingleton<IBucketExtension, BucketExtension>();
            services.AddSingleton<IDirectoryExtension, DirectoryExtension>();
            services.AddSingleton<IContactExtension, ContactExtension>();
            services.AddSingleton<IResourceExtension, ResourceExtension>();
            services.AddSingleton<IArtificialIntelligenceExtension, ArtificialIntelligenceExtension>();
            services.AddSingleton<IEventTrackExtension, EventTrackExtension>();
            services.AddSingleton<IBroadcastExtension, BroadcastExtension>();
            services.AddSingleton<IDelegationExtension, DelegationExtension>();
            services.AddSingleton<IDirectoryExtension, DirectoryExtension>();
            services.AddSingleton<IBucketExtension, BucketExtension>();
            services.AddSingleton<ISchedulerExtension, SchedulerExtension>();
            services.AddSingleton<IArtificialIntelligenceExtension, ArtificialIntelligenceExtension>();
            services.AddSingleton<IProfileExtension, ProfileExtension>();
            services.AddSingleton<IEventTrackExtension, EventTrackExtension>();
            services.AddSingleton<IHelpDeskExtension, HelpDeskExtension>();
            services.AddSingleton<IThreadExtension, ThreadExtension>();
            services.AddSingleton<IResourceExtension, ResourceExtension>();
            services.AddSingleton<ITunnelExtension, TunnelExtension>();

            return services;
        }

        /// <summary>
        /// Updates the ServiceCollection with any custom documents and BLiP's extensions
        /// </summary>
        /// <param name="services"></param>
        /// <param name="authKey"></param>
        /// <param name="documentList"></param>
        /// <returns></returns>
        public static IServiceCollection DefaultRegister(this IServiceCollection services, string authKey,
            List<Document> documentList = null)
        {
            var factory = new BlipHttpClientFactory();
            return factory.BuildServiceCollection(authKey, documentList, services);
        }
    }
}
