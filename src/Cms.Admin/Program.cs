using Microsoft.AspNetCore.Mvc.ApplicationParts;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

var asm = typeof(Cms.UI.Areas.Admin.Controllers.HomeController).Assembly;
var part = new AssemblyPart(asm);
builder.Services.AddControllersWithViews()
  .ConfigureApplicationPartManager(apm => apm.ApplicationParts.Add(part));

var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();

app.UseAuthentication();

app.MapAreaControllerRoute(
  name: "default",
  areaName: "admin",
  pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapControllerRoute(name: "admin", pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

await app.RunAsync();
