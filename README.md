<!-- PROJECT SHIELDS -->

## About The Project :zap:

This project is a Clean Architecture Solution Template for Blazor Webassembly 5.0 built with MudBlazor Components.

## Complete Overview

### Tech Stack :muscle:

- Blazor WebAssembly 7.0 - ASP.NET Core Hosted Model
- [Entity Framework Core 7.0](https://docs.microsoft.com/en-us/ef/core/)

# Version v2.2

- UI Improvements
- Docker Support
- Better Permissions Management
- Code Cleanups
- RTL Support
- Minor Bug Fixes
- Better Project Structure

# What to Expect in Version 3.0?

- Modular Architecture
- Cleaner Seperation Of Code
- Tutorials to add new entities, controllers
- UI Updates
- Support for PostgreSQL / MySQL - Easy DB Switching
- Theme Manager Integration to change UI Color Palletes / Fonts on the go.
- You can suggest your requirements as well!

# Down the Roadmap

 - Migration to .NET 8
 - Multi Tenancy
 - Better Localization - JSON

# Getting Started 🦸

The easiest way to get started with Inventory project is to install the [NuGet package](https://www.nuget.org/packages/Inventory/) and run `dotnet new Inventory`:

1. Install the latest [.NET 7 SDK](https://dotnet.microsoft.com/download/dotnet/7.0)
2. Install the latest DOTNET & EF CLI Tools by using this command `dotnet tool install --global dotnet-ef` 
3. Install the latest version of Visual Studio IDE 2022 (or above) 🚀
4. Open up Command Prompt and run `dotnet new --install Inventory` to install the project template
5. Create a folder for your solution and cd into it (the template will use it as project name)
6. Run `dotnet new Inventory` to create a new Solution

## Getting Started with Docker in Windows :rocket:

- Install Docker on Windows via `https://docs.docker.com/docker-for-windows/install/`
- Open up Powershell on Windows and run the following
    - `cd c:\`
    - `dotnet dev-certs https -ep $env:USERPROFILE\.aspnet\https\aspnetapp.pfx -p securePassword123`
    - `dotnet dev-certs https --trust`
    - Note - Make sure that you use the same password that has been configured in the `docker-compose.yml` file. By default, `securePassword123` is configured.
- 5005 & 5006 are the ports setup to run this project on Docker, so make sure that these ports are free. You could also change the ports in the `docker-compose.yml` and `Server\Dockerfile` files.
- Now navigate back to the root of this Project on your local machine and run the following via terminal - `docker-compose -f 'docker-compose.yml' up --build`
- This will start pulling MSSQL Server Image from Docker Hub if you don't already have this image. It's around 500+ Mbs of download.
- Once that is done, dotnet SDKs and runtimes are downloaded, if not present already. That's almost 200+ more Mbs of download.
- PS If you find any issues while Docker installs the nuget packages, it is most likelt that your ssl certificates are not intalled properly. Apart from that I also added the `--disable-parallel` in the `Server\Dockerfile`to ensure network issues don't pop-up. You can remove this option to speed up the build process.
- That's almost everything. Once the containers are available, migrations are updated in the MSSQL DB, default data is seeded.
- Browse to https://localhost:5005/

## Getting Started with Postgres:
- `dotnet ef migrations add "InitMigration" --project src\Infrastructure --startup-project src\Server --output-dir Migrations`
- `dotnet ef database update --project src\Infrastructure --startup-project src\Server`
- `dotnet ef migrations remove --project src\Infrastructure --startup-project src\Server`
- `dotnet ef database drop --project src\Infrastructure --startup-project src\Server`

# Complete Documentation :rocket:

Getting started with this Template – A Clean Architecture Template built for Blazor WebAssembly using MudBlazor Components. This project will make your Blazor Learning Process much easier than you anticipate. Blazor Hero is meant to be an Enterprise Level Boilerplate, which comes free of cost, completely open sourced. 

# Features

All the completed and the upcoming features are mentioned in the [Features.MD File](https://github.com/ratanachh/CleanArchitecture/blob/master/Features.md)

## Contributing

Contributions are what make the open-source community such an amazing place to be learn, inspire, and create. Any contributions you make are **greatly appreciated**.

1. Fork the Project
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3. Commit your Changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the Branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

Here are the few contributions that I would highly appreciate ;)

- [ ] Need someone to add in the API Documentation for Swagger.
- [ ] Need someone to implement localization throughout every Razor Component of the solution under the WASM(Client) Project. You can take the Pages/Authentication/Login.razor as the point of reference. It is as simple as adding `@inject Microsoft.Extensions.Localization.IStringLocalizer<Login> localizer` to every page, changing the texts to `@localizer["Text Here"]` and finally adding resx files to the Resources Folder as per the folder structure.
- [ ] Need few contributors to add in various language transalations as per the implemented Location. I got time to only add a few transalations for French as of now.
- [ ] Need a UI contributor to look at the UX/UI of the entire project
- [ ] Need someone to buildup a cool Material Logo for this project :D Do contact me on LinkedIn (https://www.linkedin.com/in/ratana-chhorm-536989117/).
- [ ] And finally, Stars from everyone! :D

## License

Distributed under the MIT License.

## Contact
### Ratana Chhorm