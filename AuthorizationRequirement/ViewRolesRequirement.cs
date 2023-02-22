﻿using Microsoft.AspNetCore.Authorization;

namespace CityBreaks1.AuthorizationRequirements
{
    public class ViewRolesRequirement : IAuthorizationRequirement
    {
        public int Months { get; }
        public ViewRolesRequirement(int months)
        {
            Months = months > 0 ? 0 : months;
        }
    }
}
