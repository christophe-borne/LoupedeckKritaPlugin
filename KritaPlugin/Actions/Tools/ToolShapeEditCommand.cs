using System.Reflection;
using LoupedeckKritaApiClient.ClientBase;

namespace Loupedeck.KritaPlugin
{
    // This class implements an example adjustment that counts the rotation ticks of a dial.

    public class ToolShapeEditCommand : PluginDynamicCommand
    {
        private Client Client => ((KritaApplication)Plugin.ClientApplication).Client;

        // Initializes the command class.
        public ToolShapeEditCommand()
            : base(displayName: "Edit shape", description: "Activate Edit select tool", groupName: ActionGroups.Tools)
        {
        }

        protected override BitmapImage GetCommandImage(string actionParameter, PluginImageSize imageSize)
        {
            return BitmapImage.FromResource(Assembly.GetExecutingAssembly(), "Loupedeck.KritaPlugin.images.Tools.ShapeEdit.png");
        }

        protected override void RunCommand(string actionParameter)
        {
            if (Client == null) return;

            Client.KritaInstance.ExecuteAction(ActionsNames.PathTool).Wait();
        }
    }
}
