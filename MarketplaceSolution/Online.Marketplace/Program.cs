
using Online.Marketplace.Repository.CategoryCRUD;
using Online.Marketplace.Repository.CustomerCRUD;
using Online.Marketplace.Repository.ProductCRUd;
using Online.Marketplace.Repository.ShopCRUD;

namespace Online.Marketplace
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddScoped<IProductCRUD, ProductCRUD>();
            builder.Services.AddScoped<IShopCRUD, ShopCRUD>();
            builder.Services.AddScoped<ICategoryCRUD, CategoryCRUD>();
            builder.Services.AddScoped<ICustomerCRUD, CustomerCRUD>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
