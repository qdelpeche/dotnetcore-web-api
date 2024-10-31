# .NET Core Web API

This API provides secure endpoints that are verified against Entra ID in Azure. The endpoints are protected or require a specific client scope. This code works perfectly with the free tier of Entra ID. 

## Setup

### Step 1: Register Your Application in Entra ID
1. Go to the Azure Portal.
1. Make sure you have a Microsoft Entra ID tenant or create one.
   * Take note of the **Tenant ID**.
   * Take note of the **Primary domain**.
1. Under App registrations, create a new registration for this project.
   * Set the Supported account types to "Accounts in this organizational directory only."
   * Add a unique **Application ID URI** (e.g., api://dotnetcore-web-api) and take note of it.
1. Under API permissions, add necessary permissions. For this example, include openid, profile, and a custom scope if needed (e.g., api://dotnetcore-web-api/crud).
1. Grant admin consent for these permissions to ensure authorized access for all users in the organization.

### Step 2: Configure appsettings.json
1. Open appsettings.json
1. Replace ``<PRIMARY_DOMAIN>`` with the **Primary domain** from the Microsoft Entra ID tenant.
1. Replace ``<TENANT_ID>`` with the **Tenant ID** from the Microsoft Entra ID tenant.
1. Replace ``<CLIENT_ID>`` with the **Client ID** from the app in Step 1.
1. Replace ``<APPLICATION_ID_URI>`` with the **Application ID URI** from the app in Step 1.

## Tutorials
* [Microsoft Entra ID Integration with .NET 8 ASP.NET Core Application](https://www.c-sharpcorner.com/article/microsoft-entra-id-integration-with-net-8-asp-net-core-application/) 
* [Microsoft Entra ID with ASP.NET Core](https://learn.microsoft.com/en-us/aspnet/core/security/authentication/azure-active-directory/?view=aspnetcore-8.0) 
* [Tutorial: Secure an ASP.NET Core web API registered in an external tenant](https://learn.microsoft.com/en-us/entra/external-id/customers/tutorial-protect-web-api-dotnet-core-build-app) 
* [Protected web API: Code configuration](https://learn.microsoft.com/en-us/entra/identity-platform/scenario-protected-web-api-app-configuration?tabs=aspnetcore) 

## Versions
* .NET: 8.0.10