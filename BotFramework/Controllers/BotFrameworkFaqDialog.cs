using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Connector;
using QnAMakerDialog;
using System;
using System.Threading.Tasks;

namespace BotFramework
{
    [Serializable]
    [QnAMakerService("810fbe2afab14f299a0b6874ff217cea", "d1cf5bc3-f072-496e-bac3-da49afd29ef5")]
    public class BotFrameworkFaqDialog : QnAMakerDialog<object>
    {
    }
}