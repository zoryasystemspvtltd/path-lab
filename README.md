# path-lab
Pathology Laboratory Management

#### Database Migration

##### Authentication

Add-Migration -Project ilab-authentication -Startup pathlab-host -Context IlabAuthentication.Data.AuthenticationDbContext
Update-Database -Project ilab-authentication -StartupProject pathlab-host -Context IlabAuthentication.Data.AuthenticationDbContext
Update-Database -Project ilab-authentication -StartupProject pathlab-authentication

##### API

Add-Migration -Project pathlab-api -Startup pathlab-host -Context PathlabApi.Data.ApplicationDbContext
Update-Database -Project pathlab-api -StartupProject pathlab-host -Context PathlabApi.Data.ApplicationDbContext
Update-Database -Project pathlab-api -StartupProject pathlab-api

Add-Migration -Project inventory-api -Startup pathlab-host -Context PathlabApi.Data.ApplicationDbContext
Update-Database -Project inventory-api -StartupProject pathlab-host -Context PathlabApi.Data.ApplicationDbContext

#### Database Migration using CLI

##### Authentication

dotnet ef migrations add --project ./src/ilab-authentication/ilab-authentication.csproj --startup-project ./src/pathlab-host/pathlab-host.csproj --context IlabAuthentication.Data.AuthenticationDbContext
dotnet ef database update --project ./src/ilab-authentication/ilab-authentication.csproj --startup-project ./src/pathlab-host/pathlab-host.csproj --context IlabAuthentication.Data.AuthenticationDbContext

##### API

dotnet ef migrations add --project ./src/pathlab-api/pathlab-api.csproj --startup-project ./src/pathlab-host/pathlab-host.csproj -Context PathlabApi.Data.ApplicationDbContext
dotnet ef database update --project ./src/pathlab-api/pathlab-api.csproj --startup-project ./src/pathlab-host/pathlab-host.csproj --context PathlabApi.Data.ApplicationDbContext
