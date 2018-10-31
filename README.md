# CounterApi
Implement an API that can count using .Net Core 2.1 and support microservices


First step is creating the api with .core CLI in VS Code

--dotnet new webapi -o CounterApi
--code CounterApi

the second part is adding sln file

-- dotnet new sln

Add the current api to sln
-- dotnet sln add .\CounterApi\CounterApi.csproj


Next step is Creating the test project with .core CLI
create the CounterApi.Tests directory
-- dotnet new xunit. 

adding the reference of api project
--dotnet add reference ../CounterApi/CounterApi.csproj

adding the test project to sln
--dotnet sln add .\CounterApi.Tests\CounterApi.Tests.csproj

create first test project and implement the basic code which return error in test project

complete the counter service to return a defualt value 

complete the test 

Add support for Entity Framework Core
Add DbContext and an Entity

config Startup file  


dotnet ef migrations add InitialCreate
dotnet ef database update


