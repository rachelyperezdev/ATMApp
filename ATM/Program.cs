using Application.Interfaces.Services;
using Application.Service.Dispensation;
using Application.Service.Withdrawal;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IWithdrawalService, WithdrawalService>();
builder.Services.AddScoped<IWithdrawalDataService, WithdrawalDataService>();
builder.Services.AddScoped<IDispensationContext, DispensationContext>();
builder.Services.AddScoped<IDispensationDataService, DispensationDataService>();
builder.Services.AddScoped<IDispensationStrategy, EfficientDispensationService>();
builder.Services.AddScoped<IDispensationStrategy, OneAndFiveHundredDispensationService>();
builder.Services.AddScoped<IDispensationStrategy, TwoHundredAndOneThousandDispensationService>();


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
