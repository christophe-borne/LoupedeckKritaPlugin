﻿using LoupedeckKritaApiClient.FiltersDialogs;

namespace Loupedeck.KritaPlugin.DynamicFolders
{
    public class FilterColorTransfer : FilterDialogBase
    {
        public FilterColorTransfer()
            : base(FilterNames.ColorTransfer)
        {
        }

        static internal FilterDialogDefinition GetDefinition()
        {
            return new FilterDialogDefinition("Color transfer",
                FilterNames.ColorTransfer,
                false,
                "Loupedeck.KritaPlugin.images.Filters.filters-ColorTransfer.png",
                [
                    new CommandDefinition("Select file...", (dialog) => (dialog.Dialog as KritaFilterColorTranfer).OpenFileSelecionDialog()),
                ],
                []);
        }
    }
}
