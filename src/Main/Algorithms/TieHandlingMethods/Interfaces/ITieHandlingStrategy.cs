using USC.GISResearchLab.Common.Core.Geocoders.ReferenceDatasets.Sources.Interfaces;
using USC.GISResearchLab.Geocoding.Core.Algorithms.FeatureMatchingMethods;
using USC.GISResearchLab.Geocoding.Core.Queries.Parameters;
using USC.GISResearchLab.Geocoding.Core.ReferenceDatasets.ReferenceSourceQueries;

namespace USC.GISResearchLab.Geocoding.Core.Algorithms.TieHandlingMethods.Interfaces
{
    public interface ITieHandlingStrategy
    {
        FeatureMatchingResult HandleTie(ParameterSet parameterSet, IFeatureSource source, ReferenceSourceQueryResultSet candidates);
    }
}
