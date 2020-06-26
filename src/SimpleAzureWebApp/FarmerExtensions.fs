module SimpleAzureWebApp.SkuExtension
open System
open Farmer
open Farmer.WebApp

type Sku with
  static member FromString(s:string) =
    match s.ToUpper() with
    | "D1" -> Sku.D1
    | "F1" -> Sku.F1
    | "B1" -> Sku.B1
    | "B2" -> Sku.B2
    | "B3" -> Sku.B3
    | "S1" -> Sku.S1
    | "S2" -> Sku.S2
    | "S3" -> Sku.S3
    | "P1" -> Sku.P1
    | "P2" -> Sku.P2
    | "P3" -> Sku.P3
    | "P1V2" -> Sku.P1V2
    | "P2V2" -> Sku.P2V2
    | "P3V2" -> Sku.P3V2
    | "I1" -> Sku.I1
    | "I2" -> Sku.I2
    | "I3" -> Sku.I3
    | "Y1" -> Sku.Y1
    | _ -> raise(Exception(sprintf "Unknown SKU %s" s))

type Location with
  static member FromString(s:string) =
    match s with
    | "EastAsia" -> Location.EastAsia
    | "SoutheastAsia" -> Location.SoutheastAsia
    | "CentralUS" -> Location.CentralUS
    | "EastUS" -> Location.EastUS
    | "EastUS2" -> Location.EastUS2
    | "WestUS" -> Location.WestUS
    | "WestUS2" -> Location.WestUS2
    | "NorthCentralUS" -> Location.NorthCentralUS
    | "SouthCentralUS" -> Location.SouthCentralUS
    | "NorthEurope" -> Location.NorthEurope
    | "WestEurope" -> Location.WestEurope
    | "JapanWest" -> Location.JapanWest
    | "JapanEast" -> Location.JapanEast
    | "BrazilSouth" -> Location.BrazilSouth
    | "AustraliaEast" -> Location.AustraliaEast
    | "AustraliaSoutheast" -> Location.AustraliaSoutheast
    | "SouthIndia" -> Location.SouthIndia
    | "CentralIndia" -> Location.CentralIndia
    | "WestIndia" -> Location.WestIndia
    | "CanadaCentral" -> Location.CanadaCentral
    | "CanadaEast" -> Location.CanadaEast
    | "UKSouth" -> Location.UKSouth
    | "UKWest" -> Location.UKWest
    | "WestCentralUS" -> Location.WestCentralUS
    | "KoreaCentral" -> Location.KoreaCentral
    | "KoreaSouth" -> Location.KoreaSouth
    | "FranceCentral" -> Location.FranceCentral
    | "AustraliaCentral" -> Location.AustraliaCentral
    | "UAECentral" -> Location.UAECentral
    | "UAENorth" -> Location.UAENorth
    | "SouthAfricaNorth" -> Location.SouthAfricaNorth
    | "SouthAfricaWest" -> Location.SouthAfricaWest
    | "SwitzerlandNorth" -> Location.SwitzerlandNorth
    | "SwitzerlandWest" -> Location.SwitzerlandWest
    | "GermanyNorth" -> Location.GermanyNorth
    | "NorwayWest" -> Location.NorwayWest
    | "NorwayEast" -> Location.NorwayEast
    | _ -> raise(Exception(sprintf "Unknown Location %s" s))
