namespace BlazorApp.Models;

public record MovieViewModel
{
    public int Number { get; set; }
    public int SeasonNumber { get; set; }
    public int WeekNumber { get; set; }
    public string Link => $"https://www.imdb.com/title/{TitleId}/";

    public string TitleId { get; set; } = default!;
    public string OriginalTitle { get; set; } = default!;
    public string TitleIT { get; set; } = default!;
    public int Year { get; set; }
    public string Directors { get; set; } = default!;
    public string Countries { get; set; } = default!;
}