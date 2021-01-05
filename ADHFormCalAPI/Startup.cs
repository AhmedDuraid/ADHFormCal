using ADHFormCalAPI.Calculator.Converters;
using ADHFormCalAPI.Calculator.MathcClculation;
using ADHFormCalAPI.Calculator.Pharmaceutical;
using ADHFormCalAPI.ErrorHandling;
using ADHFormCalAPI.Helpers;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace ADHFormCalAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddTransient<ICalculationValidation, CalculationValidation>();
            services.AddTransient<IResultCreation, ResultCreation>();
            services.AddTransient<ILengthConvertingOperations, LengthConvertingOperations>();
            services.AddTransient<IPressureConvertingOperations, PressureConvertingOperations>();
            services.AddTransient<ISpeedConvertingOperations, SpeedConvertingOperations>();
            services.AddTransient<ITemperatureConvertingOperations, TemperatureConvertingOperations>();
            services.AddTransient<ITimeConvertingOperations, TimeConvertingOperations>();
            services.AddTransient<IVolumeConvertingOperations, VolumeConvertingOperations>();
            services.AddTransient<IWeightConvertingOperations, WeightConvertingOperations>();
            services.AddTransient<IMathCalculator, MathCalculator>();
            services.AddTransient<IPharmaceuticalCalculations, PharmaceuticalCalculations>();

            services.AddSwaggerGen(setup =>
            {
                setup.SwaggerDoc("v1",
                    new OpenApiInfo
                    {
                        Title = "ADHFormCal API",
                        Version = "v1"
                    });

                // in case you need Auth in swagger

                //setup.AddSecurityDefinition("Bearer",
                //    new OpenApiSecurityScheme
                //    {
                //        Description = @"JWT Authorization header using the Bearer scheme. \r\n\r\n 
                //      Enter 'Bearer' [space] and then your token in the text input below.
                //      \r\n\r\nExample: 'Bearer 12345abcdef'",
                //        Name = "Authorization",
                //        In = ParameterLocation.Header,
                //        Type = SecuritySchemeType.ApiKey,
                //        Scheme = "Bearer"
                //    });

                //setup.AddSecurityRequirement(new OpenApiSecurityRequirement()
                //{
                //    {
                //        new OpenApiSecurityScheme
                //        {
                //            Reference = new OpenApiReference
                //                {
                //                Type = ReferenceType.SecurityScheme,
                //                Id = "Bearer"
                //                },
                //                Scheme = "oauth2",
                //                Name = "Bearer",
                //                In = ParameterLocation.Header,

                //        },
                //        new List<string>()
                //     }
                //});

            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseSwagger();
            app.UseSwaggerUI(x =>
            {
                x.SwaggerEndpoint("/swagger/v1/swagger.json", "ADHFormCalApi v1");
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
