/* 
*   NatML
*   Copyright (c) 2022 NatML Inc. All rights reserved.
*/

namespace NatML.Internal {

    using System;
    using System.IO;

    /// <summary>
    /// Feature used for making cloud predictions.
    /// </summary>
    public readonly struct MLCloudFeature : IDisposable {

        #region --Client API--
        /// <summary>
        /// Feature data.
        /// </summary>
        public readonly Stream data;

        /// <summary>
        /// Feature type.
        /// Must be one of the `DataType` constants.
        /// </summary>
        public readonly string type;

        /// <summary>
        /// Feature shape.
        /// This MUST be populated for array features.
        /// </summary>
        public readonly int[] shape;

        /// <summary>
        /// Dispose the feature and release resources.
        /// </summary>
        public readonly void Dispose () => data.Dispose();

        /// <summary>
        /// Create a cloud feature.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="type"></param>
        /// <param name="shape"></param>
        public MLCloudFeature (Stream data, string type, int[] shape = null) {
            this.data = data;
            this.type = type;
            this.shape = shape;
        }
        #endregion
    }
}