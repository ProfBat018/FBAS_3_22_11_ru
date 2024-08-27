using AspRolesRazor.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using AspRolesRazor.Data;
using AspRolesRazor.Services;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("Default") ?? throw new InvalidOperationException("Connection string 'UserContextConnection' not found.");


builder.Services.AddSingleton<IEmailSender, EmailSender>();

builder.Services.AddDbContext<UserContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddIdentity<AppUser, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<UserContext>()
    .AddDefaultTokenProviders()
    .AddDefaultUI();

builder.Services.AddAuthorization(ops =>
{
    ops.AddPolicy("AdminPolicy", pb => pb.RequireRole(AppRoles.AppAdmin));
    ops.AddPolicy("UserPolicy", pb => pb.RequireRole(AppRoles.AppUser));
    ops.AddPolicy("SuperAdminPolicy", pb => pb.RequireRole(AppRoles.AppSuperAdmin));

});

builder.Services.AddRazorPages(ops =>
{
    ops.Conventions.AuthorizeFolder("/Admin", "AdminPolicy");
    ops.Conventions.AuthorizeFolder("/User", "UserPolicy");

});


var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();