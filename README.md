# AspnetCoreIdentity2.1

Create, edit, list and delete users.

Create, edit, list and delete roles.

Add users to role.

Remove users from role.

Login, register and logout.

Authanticate and authorize 

With Asp.net Core 2.1 Identity Management.
<br/>
<br/>


Firstly you shold set connection string in appsetting.json:
``` 
{
  "ConnectionStrings": {
    "IdentityContext": "Server=(localdb)\\MSSQLLocalDB;Database=CoreIdentityDb;Trusted_Connection=True;MultipleActiveResultSets=true"
  }
}

```

<br/>
<br/>

After run below commands in terminal in your project directory to auto migrate your Identity tables:

 **dotnet ef migrations add InitialCreate**
 
 **dotnet ef database update**



