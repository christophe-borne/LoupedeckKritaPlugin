﻿using LoupedeckKritaApiClient.ClientBase;

namespace LoupedeckKritaApiClient.FiltersDialogs
{
    public class KritaFilterGaussianHighPass(Client client) : FilterDialogBase(client)
    {
        protected override string ActionName => "krita_filter_gaussianhighpass";

        public Task<float> AdjustRadius(float value)
        {
            return AdjustFloatSpinBoxValue(value, "doubleblurAmount");
        }
    }
}
