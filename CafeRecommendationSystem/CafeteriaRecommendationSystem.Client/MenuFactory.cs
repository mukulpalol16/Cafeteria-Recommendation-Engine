﻿using CafeteriaRecommendationSystem.Client.UserMenu;
using CafeteriaRecommendationSystem.Common;
using System.Net.Sockets;

namespace CafeteriaRecommendationSystem.Client
{
    public static class MenuFactory
    {
        public static IMenu CreateMenu(RoleEnum role, int userId, NetworkStream stream)
        {
            return role switch
            {
                RoleEnum.Admin => new AdminMenu(userId, stream),
                RoleEnum.Chef => new ChefMenu(userId, stream),
                RoleEnum.Employee => new EmployeeMenu(userId, stream),
                _ => throw new ArgumentException("Invalid role")
            };
        }
    }
}
