// Copyright (c) 2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccelByte.Sdk.Api.Basic.Model;

namespace AccelByte.Sdk.Core
{
    public enum NamespaceType
    {
        Unknown,
        Publisher,
        Studio,
        Game
    }

    public class LocalNamespaceContext
    {
        public static LocalNamespaceContext CreateGameNS(string gameNamespace, string studioNamespace)
        {
            return new LocalNamespaceContext()
            {
                Namespace = gameNamespace,
                StudioNamespace = studioNamespace,
                Type = NamespaceType.Game
            };
        }   

        public string Namespace { get; set; } = "";

        public NamespaceType Type { get; set; } = NamespaceType.Unknown;

        public string PublisherNamespace { get; set; } = "";

        public string StudioNamespace { get; set; } = "";

        public LocalNamespaceContext() { }

        public LocalNamespaceContext(NamespaceContext source)
        {
            if (source.Namespace != null)
                Namespace = source.Namespace;

            string sourceType = source.Type!.Value;
            if (sourceType == NamespaceContextType.Publisher.Value)
                Type = NamespaceType.Publisher;
            else if (sourceType == NamespaceContextType.Studio.Value)
                Type = NamespaceType.Studio;
            else if (sourceType == NamespaceContextType.Game.Value)
                Type = NamespaceType.Game;

            if (source.PublisherNamespace != null)
                PublisherNamespace = source.PublisherNamespace;

            if (source.StudioNamespace != null)
                StudioNamespace = source.StudioNamespace;
        }
    }
}
