namespace SunamoMsgReader;

public class MsgExtHelper
{
    public static MsgExtHelper Instance { get; set; } = null!;

    private MsgExtHelper()
    {
    }

    public static void CreateInstance()
    {
        Instance = new MsgExtHelper();
    }

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
