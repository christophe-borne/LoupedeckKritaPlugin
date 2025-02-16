﻿using Loupedeck.KritaPlugin.DynamicFolders.FilterDefinitions;
using LoupedeckKritaApiClient.FiltersDialogs;

namespace Loupedeck.KritaPlugin.DynamicFolders
{
    public class FilterLensBlur : FilterDialogBase
    {
        public FilterLensBlur()
            : base(GetDefinition())
        {
        }

        static internal FilterDialogDefinition GetDefinition()
        {
            return new FilterDialogDefinition("Lens Blur",
                FiltersEnum.LensBlur,
                [
                    new FilterCommandDefinition("Shape triangle", (dialog) => ((KritaFilterLensBlur)dialog.Dialog).SetShape(KritaFilterLensBlur.Shape.Triangle)),
                    new FilterCommandDefinition("Shape quadrilateral", (dialog) => ((KritaFilterLensBlur)dialog.Dialog).SetShape(KritaFilterLensBlur.Shape.Quadrilateral)),
                    new FilterCommandDefinition("Shape pentagon", (dialog) => ((KritaFilterLensBlur)dialog.Dialog).SetShape(KritaFilterLensBlur.Shape.Pentagon)),
                    new FilterCommandDefinition("Shape hexagon", (dialog) => ((KritaFilterLensBlur)dialog.Dialog).SetShape(KritaFilterLensBlur.Shape.Hexagon)),
                    new FilterCommandDefinition("Shape heptagon", (dialog) => ((KritaFilterLensBlur)dialog.Dialog).SetShape(KritaFilterLensBlur.Shape.Heptagon)),
                    new FilterCommandDefinition("Shape octagon", (dialog) => ((KritaFilterLensBlur)dialog.Dialog).SetShape(KritaFilterLensBlur.Shape.Octagon)),
                ],
                [
                    new FilterAdjustmentDefinition("Radius", (dialog, _, delta) => ((KritaFilterLensBlur)dialog.Dialog).AdjustRadius(delta).Result),
                    new FilterAdjustmentDefinition("Iris rotation", (dialog, _, delta) => ((KritaFilterLensBlur)dialog.Dialog).AdjustIrisRotation(delta).Result),
                ]);
        }
    }
}
