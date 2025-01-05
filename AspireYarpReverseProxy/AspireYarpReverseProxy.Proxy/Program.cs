namespace AspireYarpReverseProxy.Proxy;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.AddServiceDefaults();

        // TODO: servis adreslerini environment variables'dan alýp buraya vermeye çalýþ
        builder.Services.AddReverseProxy()
            .LoadFromConfig(builder.Configuration.GetSection("ReverseProxy")); ;

        var app = builder.Build();

        app.MapDefaultEndpoints();

        app.MapReverseProxy();

        // Configure the HTTP request pipeline.

        app.UseHttpsRedirection();


        app.Run();
    }
}
