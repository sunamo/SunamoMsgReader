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
    public static MsgExtHelper Instance { get; set; } = null!;

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
    /// <param name="msgFilePath">Path to the input .msg file.</param>
    /// <param name="htmlFilePath">Path to the output .html file.</param>
    public
        async Task
        WriteBodyToHtmlFile(string msgFilePath, string htmlFilePath)
    {
        using Storage.Message message = new(msgFilePath);
        var htmlBody = message.BodyHtml;

        await
            FileAsync.WriteAllTextAsync(htmlFilePath, htmlBody);
    }
}