﻿using LoupedeckKritaApiClient.ClientBase;

namespace LoupedeckKritaApiClient.FiltersDialogs
{
    public class KritaFilterGaussianNoiseReducer(Client client) : FilterDialogBase(client)
    {
        protected override string ActionName => "krita_filter_gaussiannoisereducer";

        public Task<int> AdjustThreshold(int value)
        {
            return AdjustIntSpinBoxValue(value, "threshold");
        }

        public Task<int> AdjustWindowSize(int value)
        {
            return AdjustIntSpinBoxValue(value, "windowsize");
        }
    }
}
