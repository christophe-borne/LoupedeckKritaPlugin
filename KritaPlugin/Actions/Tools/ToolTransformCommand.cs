using System.Reflection;
using LoupedeckKritaApiClient.ClientBase;

namespace Loupedeck.KritaPlugin
{
    // This class implements an example adjustment that counts the rotation ticks of a dial.

    public class ToolTransformCommand : PluginDynamicCommand
    {
        private Client Client => ((KritaApplication)Plugin.ClientApplication).Client;

        // Initializes the command class.
        public ToolTransformCommand()
            : base(displayName: "Transform", description: "Activate Transform tool", groupName: ActionGroups.Tools)
        {
        }

        protected override BitmapImage GetCommandImage(string actionParameter, PluginImageSize imageSize)
        {
            return BitmapImage.FromResource(Assembly.GetExecutingAssembly(), "Loupedeck.KritaPlugin.images.Tools.Transform.png");
        }

        protected override void RunCommand(string actionParameter)
        {
            if (Client == null) return;

            Client.KritaInstance.ExecuteAction(ActionsNames.KisToolTransform).Wait();
        }
    }
}
