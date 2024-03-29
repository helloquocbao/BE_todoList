﻿using System.Collections.Generic;

namespace Sadec.TodoList.Authentication.External
{
    public interface IExternalAuthConfiguration
    {
        List<ExternalLoginProviderInfo> Providers { get; }
    }
}
