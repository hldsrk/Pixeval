﻿using Microsoft.ApplicationModel.Resources;

namespace Pixeval.Util
{
    // ReSharper disable once InconsistentNaming
    public static class UIHelper
    {
        public static readonly Microsoft.ApplicationModel.Resources.ResourceLoader ResourceLoader = new(ResourceLoader.GetDefaultResourceFilePath());

        public static string GetLocalizedString(string resourceId)
        {
            return ResourceLoader.GetString(resourceId);
        }
    }
}