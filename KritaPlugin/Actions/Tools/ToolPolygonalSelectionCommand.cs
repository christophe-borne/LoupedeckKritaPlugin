using LoupedeckKritaApiClient.ClientBase;

namespace Loupedeck.KritaPlugin
{
    // This class implements an example adjustment that counts the rotation ticks of a dial.

    public class ToolPolygonalSelectionCommand : PluginDynamicCommand
    {
        private KritaPlugin KritaPlugin => (KritaPlugin)Plugin;

        // Initializes the command class.
        public ToolPolygonalSelectionCommand()
            : base(displayName: "Polygonal selection", description: "Activate Polygonal selection tool", groupName: ActionGroups.Tools)
        {
        }

        protected override BitmapImage GetCommandImage(string actionParameter, PluginImageSize imageSize)
        {
            return EmbeddedResources.ReadImage(EmbeddedResources.FindFile("ToolSelectPolygonal.png"));
        }

        protected override void RunCommand(string actionParameter)
        {
            KritaPlugin.Client.KritaInstance.ExecuteAction(ActionsNames.KisToolSelectPolygonal).Wait();
        }
    }
}
