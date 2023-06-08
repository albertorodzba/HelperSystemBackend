scaffolding from console project

dotnet ef dbcontext scaffold "server=localhost;Port=3306;database=helperSystem;user=root;password=Nem02183330156" MySql.EntityFrameworkCore --output-dir Models
"-f" to overwrite
--namespace HelperSystem.Domain.Models

dotnet ef dbcontext scaffold "server=localhost;Port=3306;database=helperSystem;user=root;password=Nem02183330156" MySql.EntityFrameworkCore --output-dir D:\Programming\MyProjects\Helper\HelperSystemBackend\HelperSystem.Domain\Models --namespace HelperSystem.Domain.Models