﻿using Telerik.Sitefinity.Localization;

namespace Telerik.Sitefinity.Frontend.Mvc.StringResources
{
    /// <summary>
    /// Localizable strings for the Widget designer.
    /// </summary>
    [ObjectInfo(typeof(DesignerResources), Title = "DesignerResourcesTitle", Description = "DesignerResourcesDescription")]
    public class DesignerResources : Resource
    {
        /// <summary>
        /// Title for the widget resources resources class.
        /// </summary>
        [ResourceEntry("DesignerResourcesTitle",
            Value = "Widget designer resources",
            Description = "Title for the widget resources resources class.",
            LastModified = "2014/05/20")]
        public string DesignerResourcesTitle
        {
            get
            {
                return this["DesignerResourcesTitle", System.Globalization.CultureInfo.InvariantCulture];
            }
        }

        /// <summary>
        /// Description for the widget designer resources class.
        /// </summary>
        [ResourceEntry("DesignerResourcesDescription",
            Value = "Localizable strings for the Widget designer.",
            Description = "Description for the widget designer resources class.",
            LastModified = "2014/05/20")]
        public string DesignerResourcesDescription
        {
            get
            {
                return this["DesignerResourcesDescription", System.Globalization.CultureInfo.InvariantCulture];
            }
        }

        /// <summary>
        /// Error!
        /// </summary>
        [ResourceEntry("Error",
            Value = "Error!",
            Description = "Error!",
            LastModified = "2014/05/20")]
        public string Error
        {
            get
            {
                return this["Error", System.Globalization.CultureInfo.InvariantCulture];
            }
        }

        /// <summary>
        /// Cancel
        /// </summary>
        [ResourceEntry("Cancel",
            Value = "Cancel",
            Description = "Cancel",
            LastModified = "2014/05/20")]
        public string Cancel
        {
            get
            {
                return this["Cancel", System.Globalization.CultureInfo.InvariantCulture];
            }
        }

        /// <summary>
        /// Save All Translations
        /// </summary>
        [ResourceEntry("SaveAllTranslations",
            Value = "Save All Translations",
            Description = "SaveAllTranslations",
            LastModified = "2014/05/20")]
        public string SaveAllTranslations
        {
            get
            {
                return this["SaveAllTranslations", System.Globalization.CultureInfo.InvariantCulture];
            }
        }

        /// <summary>
        /// Save
        /// </summary>
        [ResourceEntry("Save",
            Value = "Save",
            Description = "Save",
            LastModified = "2014/05/20")]
        public string Save
        {
            get
            {
                return this["Save", System.Globalization.CultureInfo.InvariantCulture];
            }
        }

        /// <summary>
        /// Advanced
        /// </summary>
        [ResourceEntry("PropertyGrid",
            Value = "Advanced",
            Description = "Advanced",
            LastModified = "2014/05/26")]
        public string PropertyGrid
        {
            get
            {
                return this["PropertyGrid", System.Globalization.CultureInfo.InvariantCulture];
            }
        }
    }
}
