namespace SunamoMsgReader;

/// <summary>
/// Helper class for working with MSG files (Outlook message format).
/// Provides utilities to extract content from .msg files.
/// </summary>
public class MsgExtHelper
{
    /// <summary>
    /// Singleton instance of MsgExtHelper.
    /// </summary>
    public static MsgExtHelper Instance = null!;

    private MsgExtHelper()
    {
    }

    /// <summary>
    /// Creates the singleton instance of MsgExtHelper.
    /// </summary>
    public static void CreateInstance()
    {
        Instance = new MsgExtHelper();
    }

    /// <summary>
    /// Writes the HTML body of a MSG file to an HTML file.
    /// </summary>
    /// <param name="path">Path to the input .msg file.</param>
    /// <param name="htmlFile">Path to the output .html file.</param>
    public
#if ASYNC
        async Task
#else
void
#endif
        WriteBodyToHtmlFile(string path, string htmlFile)
    {
        using Storage.Message msg = new(path);
        var htmlBody = msg.BodyHtml;

#if ASYNC
        await
#endif
            File.WriteAllTextAsync(htmlFile, htmlBody);
    }
}