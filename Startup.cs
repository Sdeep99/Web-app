public void ConfigureServices(IServiceCollection services)
{
    services.AddDbContext<ApplicationDbContext>(options =>
        options.UseNpgsql(Server=cbbirn8v9855bl.cluster-czrs8kj4isg7.us-east-1.rds.amazonaws.com;Database=your-ddeaj46pf22m8c;Port=5432;User Id=u3f5nr1tuhblgk;Password=p7b4c650708296cc4a8fe490c304bb1d00a8e41e4dd886b7d58f4481f620d62cb;SSL Mode=Require;Trust Server Certificate=True)));

    services.AddIdentity<ApplicationUser, IdentityRole>()
        .AddEntityFrameworkStores<ApplicationDbContext>()
        .AddDefaultTokenProviders();

    // Configure Identity options as needed
    services.Configure<IdentityOptions>(options =>
    {
        // Password settings, lockout settings, etc.
    });

    // JWT Authentication
    services.AddAuthentication(options =>
    {
        options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
        options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    })
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = Configuration["Jwt:Issuer"],
            ValidAudience = Configuration["Jwt:Audience"],
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["Jwt:Key"]))
        };
    });
}

public void ConfigureServices(IServiceCollection services)
{
    services.AddSingleton<IEmailService, EmailService>();
    // Other service configurations...
}
