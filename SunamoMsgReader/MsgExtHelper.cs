// EN: Variable names have been checked and replaced with self-descriptive names
// CZ: Názvy proměnných byly zkontrolovány a nahrazeny samopopisnými názvy
namespace SunamoMsgReader;

public class MsgExtHelper
{
    public static MsgExtHelper ci;

    private MsgExtHelper()
    {
    }

    public static void CreateInstance()
    {
        ci = new MsgExtHelper();
    }

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