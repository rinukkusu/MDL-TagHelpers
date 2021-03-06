﻿using System;
using System.Linq;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace MaterialDesignLite.TagHelpers
{
    public static class MdlTagHelperExtension
    {
        public const string TagPrefix = "mdl-";
        
        public static void CleanAttributes(this TagHelperOutput output, params string[] attributeNames)
        {
            foreach (var attribute in attributeNames)
            {
                output.Attributes.RemoveAll(attribute);
            }
        }

        public static void AppendCssClass(this TagHelperOutput output, params string[] cssClass)
        {
            var currentValue = output.Attributes.ContainsName("class") 
                ? output.Attributes["class"].Value.ToString() 
                : string.Empty;

            var finalCssClass = cssClass.Where(s => !string.IsNullOrWhiteSpace(s)).ToList();
            finalCssClass.Insert(0, currentValue);

            output.Attributes.SetAttribute("class",string.Join(" ", finalCssClass).Trim(' '));
        }

        public static string GetOrCreateId(this TagHelperOutput output)
        {
            if (output.Attributes.ContainsName("id"))
            {
                return output.Attributes["id"].Value.ToString();
            }

            var id = CreateId();
            output.Attributes.SetAttribute("id",id);
            return id;
        }

        public static string GetAndDeleteId(this TagHelperOutput output)
        {
            var id = string.Empty;

            if (output.Attributes.ContainsName("id"))
            {
                id = output.Attributes["id"].Value.ToString();
                output.CleanAttributes("id");
            }
            else
            {
                id = CreateId();
            }
            return id;

        }

        public static string CreateId()
        {
            return "gid_" + Guid.NewGuid();
        } 

        public static string GetChildContent(this TagHelperOutput output)
        {
           return output.Content.IsModified
                ? output.Content.GetContent() :
                output.GetChildContentAsync().Result.GetContent();
        } 
    }
}
