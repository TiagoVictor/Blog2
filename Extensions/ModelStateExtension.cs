﻿using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Blog2.Extensions
{
    static public class ModelStateExtension
    {
        public static List<string> GetErrors(this ModelStateDictionary modelState)
        {
            var result = new List<string>();
            foreach (var item in modelState.Values)
                result.AddRange(item.Errors.Select(error => error.ErrorMessage));

            return result;
        }
    }
}
