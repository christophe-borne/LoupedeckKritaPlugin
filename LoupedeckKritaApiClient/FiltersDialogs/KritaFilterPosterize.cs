﻿using LoupedeckKritaApiClient.ClientBase;

namespace LoupedeckKritaApiClient.FiltersDialogs
{
    public class KritaFilterPosterize(Client client) : FilterDialogBase(client)
    {
        protected override string ActionName => "krita_filter_posterize";

        public Task<int> AdjustSteps(int steps)
        {
            return AdjustIntSpinBoxValue(steps, "steps");
        }
    }
}
