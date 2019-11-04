
using USC.GISResearchLab.Geocoding.Core.Algorithms.FeatureMatchingMethods;
using USC.GISResearchLab.Geocoding.Core.Metadata.FeatureMatchingResults;
using USC.GISResearchLab.Geocoding.Core.Queries.Parameters;
using USC.GISResearchLab.Geocoding.Core.ReferenceDatasets.ReferenceSourceQueries;

namespace USC.GISResearchLab.Geocoding.Core.Algorithms.TieHandlingMethods.Interfaces
{
    public interface ITieHandlingStrategy
    {
        FeatureMatchingResult HandleTie(ParameterSet parameterSet, FeatureMatchingGeographyType featureMatchingGeographyType, ReferenceSourceQueryResultSet candidates);
    }
}
