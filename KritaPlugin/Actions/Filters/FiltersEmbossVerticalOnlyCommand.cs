using System.Reflection;
using LoupedeckKritaApiClient.ClientBase;

namespace Loupedeck.KritaPlugin
{
    // This class implements an example adjustment that counts the rotation ticks of a dial.

    public class FiltersEmbossVerticalOnlyCommand : PluginDynamicCommand
    {
        private Client Client => ((KritaApplication)Plugin.ClientApplication).Client;

        // Initializes the command class.
        public FiltersEmbossVerticalOnlyCommand()
            : base(displayName: "Emboss Vertical Only", description: "Apply Emboss Vertical Only filter (Emboss)", groupName: ActionGroups.Filters)
        {
        }

        protected override BitmapImage GetCommandImage(string actionParameter, PluginImageSize imageSize)
        {
            return BitmapImage.FromResource(Assembly.GetExecutingAssembly(), "Loupedeck.KritaPlugin.images.Filters.filters-EmbossVertical.png");
        }

        protected override void RunCommand(string actionParameter)
        {
            if (Client == null) return;

            Client.KritaInstance.ExecuteAction(ActionsNames.Krita_filter_emboss_vertical_only).Wait();
        }
    }
}
