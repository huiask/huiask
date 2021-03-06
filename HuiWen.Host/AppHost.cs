﻿using HuiWen.Service;
using ServiceStack.WebHost.Endpoints;

namespace HuiWen.Host
{
    public class AppHost : AppHostBase
    {
        public AppHost()
            : base("HuiWen Service", typeof(GetNickNameByUserIdService).Assembly)
        {
        }

        public override void Configure(Funq.Container container)
        {
        }
    }
}