﻿using LoupedeckKritaApiClient.ClientBase;

namespace LoupedeckKritaApiClient.FiltersDialogs
{
    public class KritaFilterColorTranfer(Client client, bool isModal) : FilterDialogBase(client, isModal)
    {
        public override string ActionName => "krita_filter_colortransfer";

        public Task OpenFileSelecionDialog()
        {
            return ClickPushButton("fileNameURLRequester", "btnSelectFile");
        }
    }
}
