namespace Loupedeck.KritaPlugin
{
    // This class implements an example adjustment that counts the rotation ticks of a dial.

    public class ViewBrushOpacityAdjustment : PluginDynamicAdjustment
    {
        private KritaPlugin KritaPlugin => (KritaPlugin)Plugin;

        // Initializes the adjustment class.
        // When `hasReset` is set to true, a reset command is automatically created for this adjustment.
        public ViewBrushOpacityAdjustment()
            : base(displayName: "Brush opacity", description: "Adjust brush opacity", groupName: ActionGroups.ViewAdjustements, hasReset: true)
        {
        }

        protected override BitmapImage GetAdjustmentImage(string actionParameter, PluginImageSize imageSize)
        {
            return EmbeddedResources.ReadImage(EmbeddedResources.FindFile("BrushOpacity.png"));
        }


        // This method is called when the adjustment is executed.
        protected override void ApplyAdjustment(String actionParameter, Int32 diff)
        {
            var opacity = KritaPlugin.Client.CurrentView.PaintingOpacity().Result;
            opacity = (float)Math.Min(Math.Max(opacity + (float)diff / 100, 0), 1);
            KritaPlugin.Client.CurrentView.SetPaintingOpacity(opacity).Wait();
            this.AdjustmentValueChanged(); // Notify the plugin service that the adjustment value has changed.
        }

        // This method is called when the reset command related to the adjustment is executed.
        protected override void RunCommand(String actionParameter)
        {
            KritaPlugin.Client.CurrentView.SetPaintingOpacity(1).Wait();
            this.AdjustmentValueChanged(); // Notify the plugin service that the adjustment value has changed.
        }

        // Returns the adjustment value that is shown next to the dial.
        protected override String GetAdjustmentValue(String actionParameter)
        {
            return Math.Round(KritaPlugin.Client.CurrentView.PaintingOpacity().Result * 100).ToString() + " %";
        }
    }
}
