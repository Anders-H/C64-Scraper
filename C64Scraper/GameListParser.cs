namespace C64Scraper;

public class GameListParser
{
    private readonly string _source;

    public GameListParser(string source)
    {
        _source = source;
    }

    public List<Game> Parse()
    {
        var result = new List<Game>();
        var raw = _source.Split(new[] { '\n', '\r' }, StringSplitOptions.None);
        var contentRows = new List<string>();
        var foundStartTable = false;
        
        foreach (var s in raw)
        {
            var x = s.Trim();

            if (string.IsNullOrEmpty(x))
                continue;

            if (x == @"<td colspan=""3"" valign=""middle""> <img src=""images/streck_games.gif"" width=""241"" height=""11""></td>")
                continue;

            if (!foundStartTable && x.StartsWith(@"<td width=""80"" valign=""middle""><a onFocus=""this.blur()"" href=""no-frame.php?showid="))
            {
                contentRows.Add(x);
                foundStartTable = true;
                continue;
            }

            if (foundStartTable && x == "</table>")
                break;

            if (foundStartTable)
                contentRows.Add(x);
        }

        var counter = 0;

        foreach (var r in contentRows)
        {
            var primaryThumbRaw = "";
            var gameNameRaw = "";
            var copyrightRaw = "";
            var downloadLinkRaw = "";

            if (counter == 0)
            {
                primaryThumbRaw = "";
                gameNameRaw = "";
                copyrightRaw = "";
                downloadLinkRaw = "";
            }

            if (r.StartsWith("<tr") || r.StartsWith("</tr") || r.StartsWith(@"<td colspan=""3"" valign=""middle"">"))
            {
                counter = 0;
                continue;
            }

            if (counter == 0 && r.StartsWith("<td"))
            {
                primaryThumbRaw = r;
                counter = 1;
                continue;
            }

            if (counter == 1 && r.StartsWith("<td"))
            {
                counter = 2;
                continue;
            }

            if (counter == 2 && r.StartsWith("<td"))
            {
                gameNameRaw = r;
                counter = 3;
                continue;
            }

            if (counter == 3 && r.StartsWith("<br"))
            {
                copyrightRaw = r;
                counter = 4;
                continue;
            }

            if (counter == 4 && r.StartsWith("<br"))
            {
                downloadLinkRaw = r;
                counter = 5;
            }

            if (counter == 5)
            {
                var game = Game.Parse(gameNameRaw, primaryThumbRaw, copyrightRaw, downloadLinkRaw);

                if (game == null)
                    throw new SystemException();
            }
        }

        return result;
    }
}