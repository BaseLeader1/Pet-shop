using Microsoft.EntityFrameworkCore;
using PetShop.Data;
using PetShop.Repositories;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<IRepositoryAnimal, AnimalRepository>();
builder.Services.AddTransient<IRepositoryCategorie, CategorieRepository>();
builder.Services.AddTransient<IRepositoryComment, CommentRepository>();
string connectionString = builder.Configuration["ConnectionStrings:DefaultConnection"]!;
builder.Services.AddDbContext<PetStoreContext>(options => options.UseSqlite(connectionString));
/*builder.Services.AddIdentity<IdentityUser, IdentityRole>()
        .AddEntityFrameworkStores<AuthenticationContext>();*/
var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var ctx = scope.ServiceProvider.GetRequiredService<PetStoreContext>();
    ctx.Database.EnsureDeleted();
    ctx.Database.EnsureCreated();
}

app.UseStaticFiles();
app.UseRouting();
//מה עדיף לכתוב את השורה 27/28
//app.MapDefaultControllerRoute(); 
app.MapControllerRoute("Default", "{controller=Home}/{action=Index}/{id?}");

app.Run();
