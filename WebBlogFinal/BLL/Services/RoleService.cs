﻿using Microsoft.AspNetCore.Identity;
using System.Data;
using WebBlogFinal.BLL.Services.IServices;
using WebBlogFinal.BLL.ViewModels.Roles;
using WebBlogFinal.DAL.Models;

namespace WebBlogFinal.BLL.Services
{
    public class RoleService : IRoleService
    {
        private readonly RoleManager<Role> _roleManager;

        public RoleService(RoleManager<Role> roleManager)
        {
            _roleManager = roleManager;
        }

        public async Task<Guid> CreateRole(RoleCreateViewModel model)
        {
            var role = new Role() { Name = model.Name, Description = model.Description };

            await _roleManager.CreateAsync(role);

            return Guid.Parse(role.Id);
        }

        public async Task EditRole(RoleEditViewModel model)
        {
            if (string.IsNullOrEmpty(model.Name) && model.Description == null)

                return;

            var role = await _roleManager.FindByIdAsync(model.Id.ToString());

            if (!string.IsNullOrEmpty(model.Name))

                role.Name = model.Name;

            if (model.Description != null)

                role.Description = model.Description;

            await _roleManager.UpdateAsync(role);
        }

        public async Task RemoveRole(Guid id)
        {
            var role = await _roleManager.FindByIdAsync(id.ToString());

            await _roleManager.DeleteAsync(role);
        }

        public async Task<List<Role>> GetRoles()
        {
            return _roleManager.Roles.ToList();
        }

        public async Task<Role?> GetRole(Guid id)
        {
            return await _roleManager.FindByIdAsync(id.ToString());
        }
    }
}