using System;

using System.Web;

namespace MyGovCMS.Core.Helpers
{
    public static class QueryStringHelper
    {
        public static int GetIntFromQueryString(HttpRequestBase request,string key,int fallbackvalue=0)
        {
            var StringValue = request.QueryString[key];

            if(StringValue!=null && !string.IsNullOrWhiteSpace(StringValue)&&int.TryParse(StringValue,out var numericValue))
            {
                return numericValue;
            }
            return fallbackvalue;

        }
    }
}
