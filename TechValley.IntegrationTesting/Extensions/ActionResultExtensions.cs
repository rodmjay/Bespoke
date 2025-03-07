﻿#region Header Info

// Copyright 2024 TechValleyTalent.  All rights reserved

#endregion

using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TechValley.Core.Settings;
using TechValley.Shared.Common;

namespace TechValley.IntegrationTesting.Extensions;

public static class ActionResultExtensions
{
    public static T GetObject<T>(this ActionResult<object> actionResult)
    {
        var obj = (actionResult.Result as OkObjectResult);
        var str = obj.Value.ToString();
        
        return JsonConvert.DeserializeObject<T>(str, JsonSettings.Settings);
    }
    
    public static bool IsSuccessStatusCode<T>(this ActionResult<T> result)
    {
        return result.Result is OkObjectResult;
    }

    public static T GetObject<T>(this ActionResult<T> response) where T : class
    {
        var myResult = (((OkObjectResult)response.Result!)!.Value as T)!;
        return myResult;
    }

    public static Result GetErrorResult<TOrig>(this ActionResult<TOrig> response)
    {
        var myResult = (((BadRequestObjectResult)response.Result!)!.Value as Result)!;
        return myResult;
    }
}