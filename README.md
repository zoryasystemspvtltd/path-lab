# path-lab
Pathology Laboratory Management

##### Authentication

Add-Migration -Project ilab-authentication -Startup pathlab-host -Context IlabAuthentication.Data.AuthenticationDbContext
Update-Database -Project ilab-authentication -StartupProject pathlab-host -Context IlabAuthentication.Data.AuthenticationDbContext

##### API

Add-Migration -Project pathlab-api -Startup pathlab-host -Context PathlabApi.Data.ApplicationDbContext
Update-Database -Project pathlab-api -StartupProject pathlab-host -Context PathlabApi.Data.ApplicationDbContext

