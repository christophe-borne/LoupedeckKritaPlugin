﻿using LoupedeckKritaApiClient.ClientBase;

namespace LoupedeckKritaApiClient.FiltersDialogs
{
    public class KritaFilterUnsharp(Client client) : FilterDialog(client)
    {
        protected override string ActionName => "krita_filter_unsharp";

        public Task<float> AdjustRadius(float radius)
        {
            return AdjustFloatSpinBoxValue(radius, "doubleHalfSize");
        }

        public Task<float> AdjustAmount(float amount)
        {
            return AdjustFloatSpinBoxValue(amount, "doubleAmount");
        }

        public Task<int> AdjustThreshold(int value)
        {
            return AdjustIntSpinBoxValue(value, "intThreshold");
        }
    }
}
