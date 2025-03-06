﻿using LoupedeckKritaApiClient.FiltersDialogs;

namespace Loupedeck.KritaPlugin.DynamicFolders
{
    public static class FilterDialogDefinitionsList
    {
        internal static readonly Dictionary<string, FilterDialogDefinition> FilterDialogDefintionList = new() 
        {
            { FilterNames.AscCdl, FilterAscCdl.GetDefinition() },
            { FilterNames.AutoConstrast, FilterAutoContrast.GetDefinition() },
            { FilterNames.Burn, FilterBurn.GetDefinition() },
            { FilterNames.ColorBalance, FilterColorsBalance.GetDefinition() },
            { FilterNames.CrossChannel, FilterCrossChannelColorAdjustment.GetDefinition() },
            { FilterNames.Desaturate, FilterDesaturate.GetDefinition() },
            { FilterNames.Dodge, FilterDodge.GetDefinition() },
            { FilterNames.HsvAdjustment, FilterHsvHsl.GetDefinition() },
            { FilterNames.Invert, FilterInvert.GetDefinition() },
            { FilterNames.Levels, FilterLevels.GetDefinition() },
            { FilterNames.PerChannelColorAdjustment, FilterPerChannelColorAdjustment.GetDefinition() },
            { FilterNames.Threshold, FilterThreshold.GetDefinition() },
            { FilterNames.Halftone, FilterHalftone.GetDefinition() },
            { FilterNames.IndexColors, FilterIndexColors.GetDefinition() },
            { FilterNames.OilPaint, FilterOilPaint.GetDefinition() },
            { FilterNames.Pixelize, FilterPixelize.GetDefinition() },
            { FilterNames.Posterize, FilterPosterize.GetDefinition() },
            { FilterNames.RainDrops, FilterRainDrops.GetDefinition() },
            { FilterNames.Blur, FilterBlur.GetDefinition() },
            { FilterNames.GaussianBlur, FilterGaussianBlur.GetDefinition() },
            { FilterNames.LensBlur, FilterLensBlur.GetDefinition() },
            { FilterNames.MotionBlur, FilterMotionBlur.GetDefinition() },
            { FilterNames.Maximize, FilterColorMaximize.GetDefinition() },
            { FilterNames.Minimize, FilterColorMinimize.GetDefinition() },
            { FilterNames.ColorToAlpha, FilterColorToAlpha.GetDefinition() },
            { FilterNames.ColorTransfer, FilterColorTransfer.GetDefinition() },
            { FilterNames.EdgeDetection, FilterEdgeDetection.GetDefinition() },
            { FilterNames.GaussianHighPass, FilterGaussianHighPass.GetDefinition() },
            { FilterNames.HeightToNormal, FilterHeightToNormal.GetDefinition() },
            { FilterNames.Emboss, FilterEmboss.GetDefinition() },
            { FilterNames.EmbossAllDirections, FilterEmbossAllDirections.GetDefinition() },
            { FilterNames.EmbossHorizontalOnly, FilterEmbossHorizontalOnly.GetDefinition() },
            { FilterNames.EmbossLaplascian, FilterEmbossLaplacian.GetDefinition() },
            { FilterNames.EmbossHorizontalAndVertical, FilterEmbossVerticalAndHorizontal.GetDefinition() },
            { FilterNames.EmbossVerticalOnly, FilterEmbossVerticalOnly.GetDefinition() },
            { FilterNames.GaussianNoiseReducer, FilterGaussianNoiseReducer.GetDefinition() },
            { FilterNames.MeanRemoval, FilterMeanRemoval.GetDefinition() },
            { FilterNames.Sharpen, FilterSharpen.GetDefinition() },
            { FilterNames.Unsharp, FilterUnsharpMask.GetDefinition() },
            { FilterNames.WaveletNoiseReducer, FilterWaveletNoiseReducer.GetDefinition() },
            { FilterNames.GradientMap, FilterGradientMap.GetDefinition() },
            { FilterNames.Normalize, FilterNormalize.GetDefinition() },
            { FilterNames.Palettize, FilterPalettize.GetDefinition() },
            { FilterNames.PhongBumpMap, FilterPhongBumpmap.GetDefinition() },
            { FilterNames.RoundCorners, FilterRoundCorners.GetDefinition() },
            { FilterNames.SmallTiles, FilterSmallTiles.GetDefinition() },
            { FilterNames.Noise, FilterRandomNoise.GetDefinition() },
            { FilterNames.RandomPick, FilterRandomPick.GetDefinition() },
            { FilterNames.ResetTransparent, FilterResetTransparent.GetDefinition() },
            { FilterNames.Wave, FilterWave.GetDefinition() },
        };
    }
}
