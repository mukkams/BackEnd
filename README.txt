npm install -g @angular/cli
ng new my-dream-app
cd my-dream-app
ng serve

dotnet tool install --global dotnet-ef
dotnet ef migrations add InitialCreate
dotnet ef database update


dotnet ef migrations add InitialUserStore --context UserStoreDataContext --project="C:\GitHubProjects\BackEnd\Persistence\Persistence.csproj" --startup-project="C:\GitHubProjects\BackEnd\UserStoreAPI.\UserStoreAPI.csproj" 

dotnet ef database update --context UserStoreDataContext --project="C:\GitHubProjects\BackEnd\Persistence\Persistence.csproj" --startup-project="C:\GitHubProjects\BackEnd\UserStoreAPI.\UserStoreAPI.csproj"

dotnet ef migrations remove --context UserStoreDataContext --project="C:\GitHubProjects\BackEnd\Persistence\Persistence.csproj" --startup-project="C:\GitHubProjects\BackEnd\UserStoreAPI.\UserStoreAPI.csproj" --force


dotnet ef migrations add InitialProcessFlow --context ProcessFlowDataContext --project="C:\GitHubProjects\BackEnd\Persistence\Persistence.csproj" --startup-project="C:\GitHubProjects\BackEnd\ProcessFlowAPI\ProcessFlowAPI.csproj" 

dotnet watch run

dotnet ef database update --context ProcessFlowDataContext --project="C:\GitHubProjects\BackEnd\Persistence\Persistence.csproj" --startup-project="C:\GitHubProjects\BackEnd\ProcessFlowAPI\ProcessFlowAPI.csproj"


dotnet ef migrations add InitialWorkflow --context WorkflowDataContext --project="C:\GitHubProjects\BackEnd\Persistence\Persistence.csproj" --startup-project="C:\GitHubProjects\BackEnd\WorkflowAPI\WorkflowAPI.csproj" 

dotnet ef database update --context WorkflowDataContext --project="C:\GitHubProjects\BackEnd\Persistence\Persistence.csproj" --startup-project="C:\GitHubProjects\BackEnd\WorkflowAPI\WorkflowAPI.csproj"

dotnet ef migrations remove --context WorkflowDataContext --project="C:\GitHubProjects\BackEnd\Persistence\Persistence.csproj" --startup-project="C:\GitHubProjects\BackEnd\WorkflowAPI\WorkflowAPI.csproj" --force


dotnet ef dbcontext scaffold "Server=MSLONDON-ITPC;Database=EFDemo;Trusted_Connection=True;MultipleActiveResultSets=true;" Microsoft.EntityFrameworkCore.SqlServer -o Models --project="C:\GitHubProjects\BackEnd\Persistence\Persistence.csproj" --startup-project="C:\GitHubProjects\BackEnd\WorkflowAPI\WorkflowAPI.csproj" 

npm install @auth0/angular-jwt

npm run start:electron

ng lint
ng lint WebAPP --fix

https://cloudinary.com/
sunil.mukkamala@gmail.com
Welcome#1

Key: o1rFroiMo3Foa7GeW7RG3BS8qQM

mpn install -g ionic
Ionic start
ionic serve

