var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{

    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
}
else
{
    app.UseExceptionHandler("/Home/CustomError");
    app.UseHsts();

}

app.UseStatusCodePagesWithReExecute("/Home/CustomError", "?code={0}");


app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
//Add custom routing here
app.MapControllerRoute(
    name: "Showgames",
    pattern: "games/all",
    defaults: new {Controller = "Games", Action = "Index" }
    );
app.MapControllerRoute(
    name: "Showgame",
    pattern: "games/{id:int}",
    defaults: new { Controller = "Games", Action = "ShowGame" }
    );
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapControllerRoute(
    name: "Showdevelopers",
    pattern: "Developers/All",
    defaults: new { Controller = "Developers", action = "Index" }
    );
app.MapControllerRoute(
    name: "Showdeveloper",
    pattern: "Developers/{id:int}",
    defaults: new { Controller = "Developers", action = "ShowDeveloper"}
    );
app.MapControllerRoute(
    name: "ShowID",
    pattern: "ShowID/{id:int}",
    defaults: new { Controller = "Home", action = "FindByIndex" }
    );

app.Run();
