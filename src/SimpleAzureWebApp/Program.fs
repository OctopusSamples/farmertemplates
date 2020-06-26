open Farmer
open Farmer.Builders
open SimpleAzureWebApp.SkuExtension

[<EntryPoint>]
let main argv =
    
    let azAppId = argv.[0]
    let azSecret = argv.[1]
    let azTenantId = argv.[2]
    let azResourceGroupName = argv.[3]
    let azWebAppName = argv.[4]
    let azWebAppSku = argv.[5]
    let azWebAppLocation = argv.[6]

    let webAppSku =  WebApp.Sku.FromString(azWebAppSku)
    let webApp = webApp {
        name azWebAppName
        sku webAppSku
    }

    let deployLocation = Location.FromString(azWebAppLocation)
    let deployment = arm {
        location deployLocation
        add_resource webApp
    }

    printf "Authenticating with Azure"
    Deploy.authenticate azAppId azSecret azTenantId
    |> ignore

    printf "Deploying Azure WebApp %s (%s) into %s using Farmer" azWebAppName azResourceGroupName azWebAppLocation
    deployment
    |> Deploy.execute azResourceGroupName Deploy.NoParameters
    |> ignore

    printf "Deployment of Azure WebApp %s (%s) complete!" azWebAppName azResourceGroupName

    0 // return an integer exit code

