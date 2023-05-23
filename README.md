## Scaffolding and update overwritting scaffold
dotnet ef dbcontext scaffold "server=localhost;Port=3306;database=helperSystem;user=root;password=Nem02183330156" MySql.EntityFrameworkCore --output-dir Models
"-f" to overwrite


dotnet tool install --global dotnet-aspnet-codegenerator
dotnet tool install --global dotnet-ef
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore.SQLite
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
dotnet add package Microsoft.EntityFrameworkCore.SqlServe

"dotnet-aspnet-codegenerator". 
    Es para hacer scaffolding y junto con "Microsoft.VisualStudio.Web.CodeGeneration.Design" Es necesario instalar ambas

"dotnet-ef  y... Microsoft.EntityFrameworkCore.Design"
    Estas estan incluidas en "Microsoft.EntityFrameworkCore.Tools", por lo que se puede instalar solamente esta y 
    no instalar Microsoft.EntityFrameworkCore.Design
    
"dotnet add package Microsoft.EntityFrameworkCore.SQLite //// dotnet add package Microsoft.EntityFrameworkCore.SqlServe"
    Instalará la que vayas de acuerdo a la base de datos

"dotnet-ef y dotnet-aspnet-codegenerator"
    Se instalaron de manera local, es necesario crear un manifiesto con el comando
    < dotnet new tool-manifest > sin los "<>"

Ejemplo StringConnection
    server=localhost;Port=0000;database=TodoApp;user=root;password=3330156