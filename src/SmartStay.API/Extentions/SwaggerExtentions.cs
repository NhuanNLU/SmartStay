using Microsoft.OpenApi;
using Swashbuckle.AspNetCore.SwaggerUI;

namespace SmartStay.API.Extentions;

public static class SwaggerExtentions
{
    private const string BearerScheme = "Bearer";

    public static IServiceCollection AddSwaggerServices(this IServiceCollection services)
    {
        services.AddEndpointsApiExplorer();

        services.AddSwaggerGen(options =>
        {
            // Tạo phiên bản API
            options.SwaggerDoc("v1", new OpenApiInfo
            {
                Title = "SmartStay API",
                Version = "v1"
            });

            // Tránh lỗi trùng schema ID khi có 2 class cùng tên khác namespace
            options.CustomSchemaIds(type => type.FullName);

            // Cấu hình JWT Bearer
            options.AddSecurityDefinition(BearerScheme, new OpenApiSecurityScheme
            {
                Name = "Authorization",
                Type = SecuritySchemeType.Http,
                Scheme = "bearer",
                BearerFormat = "JWT",
                In = ParameterLocation.Header,
                Description = "Chỉ cần nhập JWT token (Swagger tự thêm tiền tố 'Bearer ').\nVí dụ: eyJhbGciOiJIUzI1NiIsInR..."
            });

            // Yêu cầu Bearer cho các endpoint (kiểu mới của Microsoft.OpenApi 2.x)
            options.AddSecurityRequirement(document => new OpenApiSecurityRequirement
            {
                [new OpenApiSecuritySchemeReference(BearerScheme, document)] = []
            });
        });

        return services;
    }

    public static WebApplication UseSwaggerAPI(this WebApplication app)
    {
        app.UseSwagger();

        app.UseSwaggerUI(options =>
        {
            options.SwaggerEndpoint("/swagger/v1/swagger.json", "SmartStay API v1");

            options.DisplayRequestDuration();   // Hiển thị thời gian thực hiện request
            options.EnableTryItOutByDefault();
            options.DocExpansion(DocExpansion.List);
        });

        // Redirect trang chủ sang Swagger, ẩn khỏi tài liệu Swagger
        app.MapGet("/", () => Results.Redirect("/swagger/index.html"))
            .ExcludeFromDescription();

        return app;
    }
}