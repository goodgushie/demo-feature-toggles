using System.Collections.Generic;
using System.Linq;
using Calculator.Models;

namespace Calculator.Helpers
{
    public static class FeaturesHelper
    {
        private static List<FeatureDto> _features;

        public static List<FeatureDto> Features
        {
            get
            {
                if (_features == null)
                    _features = new List<FeatureDto>
                    {
                        new FeatureDto {Id = 1, Name = "Modulo Enabled", IsEnabled = false},
                        new FeatureDto {Id = 2, Name = "Random Number Fix", IsEnabled = false}
                    };
                return _features;
            }
        }

        public static bool IsEnabled(int id)
        {
            var feature = Features.FirstOrDefault(x => x.Id == id);
            return (feature != null) && feature.IsEnabled;
        }

        public static void ToggleFeature(int id)
        {
            var feature = Features.FirstOrDefault(x => x.Id == id);
            if (feature != null) feature.IsEnabled = !feature.IsEnabled;
        }
    }
}