﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArtOfTest.WebAii.Core;
using Telerik.Sitefinity.Frontend.TestUI.Framework.ElementMap.Widgets;

namespace Telerik.Sitefinity.Frontend.TestUI.Framework.ElementMap
{
    /// <summary>
    /// Feather map, used for EM facade.
    /// </summary>
    public class FeatherElementMap
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FeatherElementMap" /> class.
        /// </summary>
        public FeatherElementMap()
        {
        }

        /// <summary>
        /// Gets the widgets element map.
        /// It contains the finding expressions for all back-end events screens.
        /// </summary>
        /// <value>An initialized instance of widgets element map.</value>
        public WidgetsMap Widgets
        {
            get
            {
                if (this.widgetsMap == null)
                {
                    this.EnsureFindIsInitialized();
                    this.widgetsMap = new WidgetsMap(this.find);
                }

                return this.widgetsMap;
            }

            private set
            {
                this.widgetsMap = value;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeatherElementMap" /> class.
        /// </summary>
        /// <param name="find">The find object used to get the elements/controls.</param>
        public FeatherElementMap(Find find)
        {
            this.find = find;
        }

        private void EnsureFindIsInitialized()
        {
            if (this.find == null)
            {
                throw new NotSupportedException("The element map can't be used without specifying its Find object.");
            }
        }

        private Find find;
        private WidgetsMap widgetsMap;
    }
}