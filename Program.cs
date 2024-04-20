using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using WeBoozin.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseMySql(builder.Configuration.GetConnectionString("DefaultConnection"),
    ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("DefaultConnection"))));

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.LoginPath = "/UserLogic/Login";
        options.LogoutPath = "/UserLogic/Logout";
    });

var app = builder.Build();

app.MapGet("/", page =>
{
    // Redirect to the categories page if the user is not admin otherwise to AdminPanel
    if (page.User.Identity.IsAuthenticated && page.User.IsInRole("Admin"))
        page.Response.Redirect("/UserLogic/Admin/AdminPanel");
    else
        page.Response.Redirect("/Categories");
    return Task.CompletedTask;
} );

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
