using Sitecore.ExperienceAnalytics.Api.Response.DimensionKeyTransformers;
using Sitecore.Globalization;

namespace Sitecore.Support.ExperienceAnalytics.Api.Response.DimensionKeyTransformers
{
    public class CountryDimensionKeyTransformer : IDimensionKeyTransformer
    {
        // Methods
        public string Transform(string key, Language language)
        {
            return new CountryDimensionKeyTransformer().Transform(key.ToUpper(), language);
        }

        // Properties
        public string UnknownLabel
        {
            get
            {
                return "[unknown country]";
            }
        }
    }


}