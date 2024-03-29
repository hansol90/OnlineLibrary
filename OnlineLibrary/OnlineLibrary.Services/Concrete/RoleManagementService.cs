﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using OnlineLibrary.DataAccess;
using OnlineLibrary.DataAccess.Entities;

namespace OnlineLibrary.Services.Concrete
{
    public class RoleManagementService : RoleManager<Role>, IDisposable
    {
        public RoleManagementService(RoleStore<Role> store) : base(store) { }
        public static RoleManagementService Create(IdentityFactoryOptions<RoleManagementService> options, IOwinContext context)
        {
            return new RoleManagementService(new RoleStore<Role>(context.Get<ApplicationDbContext>()));
        }
    }
}
