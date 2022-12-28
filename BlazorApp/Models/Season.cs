namespace BlazorApp.Models
{
    public record Season
    {
        public int SeasonId { get; set; }

        public Movie[] Movies { get; set; } = default!;
    }
}
