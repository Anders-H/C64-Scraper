namespace C64Scraper;

public class Game
{
    public string Name { get; }
    public List<string> Screenshots { get; }
    public string Copyright { get; }
    public string DownloadUrl { get; }

    public Game() : this("", "", "")
    {
    }

    public Game(string name, string copyright, string downloadUrl)
    {
        Name = name;
        Screenshots = new List<string>();
        Copyright = copyright;
        DownloadUrl = downloadUrl;
    }

    public static Game Parse(string gameNameRaw, string primaryScreenShotRaw, string copyrightRaw, string downloadLinkRaw)
    {
        var game = new Game(
            ParseGameName(gameNameRaw),
            ParseScreenshot(primaryScreenShotRaw),
            ParseCopyright(copyrightRaw),
            ParseDownloadLink(downloadLinkRaw)
        );

        if (game.IsOk())
            return game;

        throw new SystemException("What's this shit?!?");
    }

    private bool IsOk()
    {

    }
}