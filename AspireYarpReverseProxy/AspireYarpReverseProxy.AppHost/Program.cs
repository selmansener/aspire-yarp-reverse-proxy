var builder = DistributedApplication.CreateBuilder(args);

var api = builder.AddProject<Projects.AspireYarpReverseProxy_API>("aspireyarpreverseproxy-api");

var dashboard = builder.AddNpmApp("dashboard", "../../FrontendApplications/Dashboard")
    .WithReference(api)
    .WaitFor(api)
    .WithEnvironment("BROWSER", "none")
    .WithHttpEndpoint(port: 54001, env: "PORT")
    .PublishAsDockerFile();

var marketplace = builder.AddNpmApp("marketplace", "../../FrontendApplications/Marketplace")
    .WithReference(api)
    .WaitFor(api)
    .WithEnvironment("BROWSER", "none")
    .WithHttpEndpoint(port: 54002, env: "PORT")
    .PublishAsDockerFile();

builder.AddProject<Projects.AspireYarpReverseProxy_Proxy>("aspireyarpreverseproxy-proxy")
    .WithReference(dashboard)
    .WithReference(marketplace);

builder.Build().Run();
