﻿using System;
using System.IO;
using Telerik.Sitefinity.Frontend.Resources;

namespace Telerik.Sitefinity.Frontend.TestUtilities.DummyClasses.ResourceResolvers
{
    /// <summary>
    /// This class mocks the functionality of <see cref="Telerik.Sitefinity.Frontend.Resources.ResourceHttpHandler" /> for
    /// test purposes.
    /// </summary>
    public class DummyResourceHttpHandler : ResourceHttpHandler
    {
        #region Fields

        /// <summary>
        /// A function that will be called through <see cref="FileExists" /> method.
        /// </summary>
        public Func<string, bool> FileExistsMock { get; set; }

        /// <summary>
        /// A function that will be called through <see cref="OpenFile" /> method.
        /// </summary>
        public Func<string, Stream> OpenFileMock { get; set; }

        /// <summary>
        /// A function that will be called through <see cref="WriteToOutput" /> method.
        /// </summary>
        public Action<System.Web.HttpContext, byte[]> WriteToOutputMock { get; set; }

        #endregion

        #region Methods

        /// <inheritdoc />
        protected override bool FileExists(string path)
        {
            if (this.FileExistsMock != null)
            {
                return this.FileExistsMock(path);
            }

            return base.FileExists(path);
        }

        /// <inheritdoc />
        protected override Stream OpenFile(string path)
        {
            if (this.OpenFileMock != null)
            {
                return this.OpenFileMock(path);
            }

            return base.OpenFile(path);
        }

        /// <inheritdoc />
        protected override void WriteToOutput(System.Web.HttpContext context, byte[] buffer)
        {
            if (this.WriteToOutputMock != null)
            {
                this.WriteToOutputMock(context, buffer);
            }
            else
            {
                base.WriteToOutput(context, buffer);
            }
        }

        #endregion
    }
}