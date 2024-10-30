# .NET Core Web API

This API provides secure endpoints that are verified against Entra ID in Azure. The endpoints are protected or require a specific scope. This code works perfectly with the free tier of Entra ID. 

## Setup

### Step 1: Register Your Application in Entra ID
1. Go to the Microsoft Entra admin center.
1. Under App registrations, create a new registration for your API.
   * Set the Supported account types to "Accounts in this organizational directory only."
   * Add a unique Application ID URI (e.g., api://your-client-id).
1. Under API permissions, add necessary permissions. For this example, include openid, profile, and a custom scope if needed (e.g., api://your_client-id/access_as_user).
1. Grant admin consent for these permissions to ensure authorized access for all users in the organization.

### Step 2: Configure appsettings.json
1. Open authConfig.js
1. Replace <PRIMARY_DOMAIN> with the Primary Domain from Entra ID tenant.
1. Replace <TENANT_ID> with the Tenant ID from Entra ID tenant.
1. Replace <APPLICATION_CLIENT_ID> with the Client ID from the app in Step 1.
1. Replace <APPLICATION_ID_URI> with the Client URI from the app in Step 1.

## Tutorials
*  https://www.c-sharpcorner.com/article/microsoft-entra-id-integration-with-net-8-asp-net-core-application/ 
* https://learn.microsoft.com/en-us/aspnet/core/security/authentication/azure-active-directory/?view=aspnetcore-8.0 
* https://learn.microsoft.com/en-us/entra/external-id/customers/tutorial-protect-web-api-dotnet-core-build-app 
* https://learn.microsoft.com/en-us/entra/identity-platform/scenario-protected-web-api-app-configuration?tabs=aspnetcore 

## Versions
* .NET: 8.0.10