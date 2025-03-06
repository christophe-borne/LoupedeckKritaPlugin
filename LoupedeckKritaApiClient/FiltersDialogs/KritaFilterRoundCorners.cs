﻿using LoupedeckKritaApiClient.ClientBase;

namespace LoupedeckKritaApiClient.FiltersDialogs
{
    public class KritaFilterRoundCorners(Client client) : FilterDialogBase(client)
    {
        protected override string ActionName => "krita_filter_roundcorners";

        public Task<int> AdjustRadius(int radius)
        {
            return AdjustIntSpinBoxValue(radius, "radius");
        }
    }
}
