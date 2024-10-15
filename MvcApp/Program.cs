using MvcApp.Infrastructure.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

builder.Services.ConfigureDbContext(builder.Configuration);
builder.Services.ConfigureIdentity();

builder.Services.ConfigureRepositoryRegistration();


builder.Services.ConfigureServiceRegistration();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseStaticFiles();

app.UseHttpsRedirection();
app.UseRouting();


app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints(endpoints => 
{
    
    // endpoints.MapAreaControllerRoute(
    //     name:"Admin",
    //     areaName:"Admin",
    //     pattern:"Admin/{controller=Dashboard}/{action=Index}/{id?}"
    // );
    endpoints.MapControllerRoute(
        name:"default",
        pattern:"{controller=Account}/{action=Login}/{id?}"
    );
    endpoints.MapRazorPages();
    endpoints.MapControllers();
});

app.ConfigureDefaultAdminUserAsync();

app.Run();
