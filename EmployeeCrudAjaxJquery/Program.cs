// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

#pragma warning disable SA1200 // Using directives should be placed correctly
using BusinessLayer.Interfaces;
#pragma warning restore SA1200 // Using directives should be placed correctly
#pragma warning disable SA1200 // Using directives should be placed correctly
using BusinessLayer.Services;
#pragma warning restore SA1200 // Using directives should be placed correctly
#pragma warning disable SA1200 // Using directives should be placed correctly
using Microsoft.EntityFrameworkCore;
#pragma warning restore SA1200 // Using directives should be placed correctly
#pragma warning disable SA1200 // Using directives should be placed correctly
using RepositoryLayer;
#pragma warning restore SA1200 // Using directives should be placed correctly
#pragma warning disable SA1200 // Using directives should be placed correctly
using RepositoryLayer.Interfaces;
#pragma warning restore SA1200 // Using directives should be placed correctly
#pragma warning disable SA1200 // Using directives should be placed correctly
using RepositoryLayer.Sevices;
#pragma warning restore SA1200 // Using directives should be placed correctly

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
builder.Services.AddScoped<IEmployeeBusiness, EmployeeBusiness>();

builder.Services.AddDbContext<Context>(option =>
option.UseSqlServer(builder.Configuration.GetConnectionString("SqlServer")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");

    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Ajax}/{action=Index}/{id?}");

app.Run();
