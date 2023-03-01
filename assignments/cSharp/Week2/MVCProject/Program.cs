var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews();//Adding the  ability to use the controller file
var app = builder.Build();

app.UseStaticFiles();//Add thr abilities to use css /js/img
app.UseRouting();//enable us to have more than one route/page/view
app.UseAuthorization();//used with db for auth/login


//is for error template
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");//this helps us set up a pattern for our routes and tells the programs to look for the routes in controller file


// app.MapGet("/", () => "Hello World!this was a wonderful day");

app.Run();
