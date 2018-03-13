using System.Collections.Generic;
using System.Linq;
using Calculator.Models;

namespace Calculator.Helpers
{
    /// <summary>
    /// A basic, in memory feature toggle manager
    /// </summary>
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
                        new FeatureDto {Id = 2, Name = "Random Number Fix", IsEnabled = false},
                        new FeatureDto {Id = 3, Name = "Time Zone Calculator", IsEnabled = false}
                    };
                return _features;
            }
        }

        /// <summary>
        /// Gives state of requested feature toggle
        /// </summary>
        /// <param name="id">id of requested feature toggle</param>
        /// <returns>current state of requested feature toggle</returns>
        public static bool IsEnabled(int id)
        {
            var feature = Features.FirstOrDefault(x => x.Id == id);
            return (feature != null) && feature.IsEnabled;
        }

        /// <summary>
        /// Toggles feature state
        /// </summary>
        /// <param name="id">id of feature toggle</param>
        public static void ToggleFeature(int id)
        {
            var feature = Features.FirstOrDefault(x => x.Id == id);
            if (feature != null) feature.IsEnabled = !feature.IsEnabled;
        }
    }
}