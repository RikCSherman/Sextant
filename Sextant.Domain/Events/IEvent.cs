﻿// Copyright (c) Stickymaddness All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;

namespace Sextant.Domain.Events
{
    public interface IEvent
    {
        string Event { get; }
        Dictionary<string, object> Payload { get; }
    }
}