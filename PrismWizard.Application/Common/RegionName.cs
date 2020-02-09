using System;
using System.Collections.Generic;
using System.Text;

namespace PrismWizard.Application
{
    public static class RegionName
    {
        public const string ContentRegion = "ContentRegion";
    }

    public static class ViewHelper
    {
        public static string GetViewName(Type type)
        {
            string a = type.Name;
            a = a.Replace("Model", String.Empty);
            return a;
        }
    }
}
