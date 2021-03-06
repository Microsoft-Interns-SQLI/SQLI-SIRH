using API_MySIRH.Data;
using API_MySIRH.Extentions;
using API_MySIRH.Helpers;
using API_MySIRH.Interfaces;
using API_MySIRH.Repositories;
using API_MySIRH.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var myAllowSpecificOrigins = "_myAllowSpecificOrigins";
var builder = WebApplication.CreateBuilder(args);

// Logging config 
builder.Logging.ClearProviders();
builder.Logging.AddConsole();

// Add services to the container.
builder.Services.AddAutoMapper(typeof(AutoMapperProfiles).Assembly);
builder.Services.AddControllers();
builder.Services.AddControllers().AddNewtonsoftJson(options =>
    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Caching
builder.Services.AddMemoryCache();

//Add IoC Mapping 
builder.Services.AddScoped<IFileRepository, FileRepository>();
builder.Services.AddScoped<IFilesService, FilesService>();
builder.Services.AddScoped<IImageRepository, ImageRepository>();
builder.Services.AddScoped<IImageService, ImageService>();
builder.Services.AddScoped<ITokenService, TokenService>();
builder.Services.AddScoped<IToDoItemsRepository, ToDoItemsRepository>();
builder.Services.AddScoped<IToDoListRepository, ToDoListRepository>();

builder.Services.AddScoped<IToDoListService, ToDoListService>();
builder.Services.AddScoped<IToDoItemService, ToDoItemService>();

builder.Services.AddScoped<IMemoService, MemoService>();
builder.Services.AddScoped<IMemoRepository, MemoRepository>();

builder.Services.AddScoped<ICollaborateurService, CollaborateurService>();
builder.Services.AddScoped<ICollaborateurRepository, CollaborateurRepository>();

builder.Services.AddScoped<IDashboardService, DashboardService>();
builder.Services.AddScoped<IDashboardRepository, DashboardRepository>();

builder.Services.AddScoped<ICertificationService, CertificationService>();
builder.Services.AddScoped<ICertificationRepository, CertificationRepository>();

builder.Services.AddScoped<ICollaborateurCertificationService, CollaborateurCertificationService>();
builder.Services.AddScoped<ICollaborateurCertificationRepository, CollaborateurCertificationRepository>();

builder.Services.AddScoped<IFormationService, FormationService>();
builder.Services.AddScoped<IFormationRepository, FormationRepository>();

builder.Services.AddScoped<ICollaborateurFormationService, CollaborateurFormationService>();
builder.Services.AddScoped<ICollaborateurFormationRepository, CollaborateurFormationRepository>();

builder.Services.AddScoped<ICollaborateurTypeContratService, CollaborateurTypeContratService>();
builder.Services.AddScoped<ICollaborateurTypeContratRepository, CollaborateurTypeContratRepository>();

builder.Services.AddScoped<IDiplomeService, DiplomeService>();
builder.Services.AddScoped<IDiplomeRepository, DiplomeRepository>();

builder.Services.AddScoped<ICarriereRepository, CarriereRepository>();
builder.Services.AddScoped<ICarriereService, CarriereService>();

builder.Services.AddScoped<IDemissionService, DemissionService>();
builder.Services.AddScoped<IDemissionRepository, DemissionRepository>();

builder.Services.AddScoped(typeof(IMdmRepository<>), typeof(MdmRepository<>));
builder.Services.AddScoped(typeof(IMdmService<,>), typeof(MdmService<,>));



//DBContext Config 
builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
    //options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));
});

//Add Identity Extensions Configuration
builder.Services.AddIdentityServices();

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JWT:Secret"])),
            ValidateIssuer = false,
            ValidateAudience = false,
            ValidateLifetime = true,
            RequireExpirationTime = true,
            ClockSkew = TimeSpan.Zero
        };
    });

//enable CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: myAllowSpecificOrigins,
        builder =>
        {
            builder.WithOrigins
            (
                "http://localhost:4200",
                "http://localhost:4201",
                "https://microsoft-interns-sqli.github.io", // temp
                "https://sqli-sirh-bdeb6.web.app"
            )
            .AllowAnyMethod()
            .AllowAnyHeader()
            ;
        });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseAuthentication();

app.UseHttpsRedirection();

app.UseCors(myAllowSpecificOrigins);

app.UseAuthorization();

app.MapControllers();

app.Run();
