﻿using LoupedeckKritaApiClient.ClientBase;

namespace LoupedeckKritaApiClient.FiltersDialogs
{
    public class KritaFilterNormalize(Client client, bool isModal) : FilterDialogBase(client, isModal)
    {
        public override string ActionName => "krita_filter_normalize";

        // No parameters
    }
}
