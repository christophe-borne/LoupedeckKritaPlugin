﻿using LoupedeckKritaApiClient.ClientBase;

namespace LoupedeckKritaApiClient.FiltersDialogs
{
    public class KritaFilterAscCdl(Client client) : FilterDialog(client)
    {
        public override string ActionName => "krita_filter_asc-cdl";
    }
}
