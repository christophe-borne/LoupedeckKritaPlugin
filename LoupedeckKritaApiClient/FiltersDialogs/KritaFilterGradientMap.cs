﻿using LoupedeckKritaApiClient.ClientBase;

namespace LoupedeckKritaApiClient.FiltersDialogs
{
    public class KritaFilterGradientMap(Client client, bool isModal) : FilterDialogBase(client, isModal)
    {
        public override string ActionName => "krita_filter_gradientmap";

        // TODO: complete, very complex
    }
}
