using Blog.Data;
using Blog.Repository;
using Blog.Repository.Implimentation;
using Microsoft.AspNetCore.Connections;
using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);
//Builder For DB Connection
builder.Services.AddDbContext<BlogContext>(options => 
    {
        options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
    },
    ServiceLifetime.Transient);


builder.Services.AddTransient<IUserAccount, UserAccountRepository>(p => new UserAccountRepository(builder.Services.BuildServiceProvider().GetService<BlogContext>()));
// Add services to the container.
builder.Services.AddControllersWithViews();

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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
