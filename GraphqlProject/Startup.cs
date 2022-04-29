using GraphiQl;
using GraphQL.Server;
using GraphQL.Types;
using GraphqlProject.Data;
using GraphqlProject.Interfaces;
using GraphqlProject.Mutation;
using GraphqlProject.Query;
using GraphqlProject.Schema;
using GraphqlProject.Services;
using GraphqlProject.Type;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace GraphqlProject
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        [System.Obsolete]
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddTransient<IMenu, MenuService>();
            services.AddTransient<ISubMenu, SubMenuService>();
            services.AddTransient<IReservation, ReservationService>();
            services.AddTransient<MenuType>();
            services.AddTransient<SubMenuType>();
            services.AddTransient<ReservationType>();
            services.AddTransient<MenuQuery>();
            services.AddTransient<SubMenuQuery>();
            services.AddTransient<ReservationQuery>();
            services.AddTransient<RootQuery>();
            services.AddTransient<MenuMutation>();
            services.AddTransient<SubMenuMutation>();
            services.AddTransient<ReservationMutation>();
            services.AddTransient<RootMutation>();
            services.AddTransient<MenuInputType>();
            services.AddTransient<SubMenuInputType>();
            services.AddTransient<ReservationInputType>();
            services.AddTransient<ISchema, RootSchema>();

            services.AddGraphQL(options =>
            {
                options.EnableMetrics = false;
            }).AddSystemTextJson();

            services.AddDbContext<GraphQLDbContext>(option => option.UseSqlServer(@"Data Source= (localdb)\MSSQLLocalDB;Initial Catalog=CoffeeShopDb;Integrated Security = True"));
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, GraphQLDbContext dbContext)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            dbContext.Database.EnsureCreated();
            app.UseGraphiQl("/graphql");
            app.UseGraphQL<ISchema>();
        }
    }
}
