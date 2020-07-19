namespace InfoTrackSEOResultsCount.Models
{
    public interface ISearchEngine
    {
        SearchOutput GetSearchResults(SearchInput searchInput);

    }
}
