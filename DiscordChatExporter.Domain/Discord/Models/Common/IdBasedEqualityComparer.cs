﻿using System;
using System.Collections.Generic;

namespace DiscordChatExporter.Domain.Discord.Models.Common
{
    public partial class IdBasedEqualityComparer : IEqualityComparer<IHasId>
    {
        public bool Equals(IHasId? x, IHasId? y) => x?.Id == y?.Id;

        public int GetHashCode(IHasId obj) => obj.Id.GetHashCode();
    }

    public partial class IdBasedEqualityComparer
    {
        public static IdBasedEqualityComparer Instance { get; } = new();
    }
}