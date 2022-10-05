/* 
*   NatML
*   Copyright (c) 2022 NatML Inc. All rights reserved.
*/

namespace NatML {

    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Internal;

    /// <summary>
    /// </summary>
    internal sealed class MLCloudModel : MLModel { // INCOMPLETE

        #region --Client API--
        /// <summary>
        /// Create a cloud ML model.
        /// </summary>
        /// <param name="tag">Cloud predictor tag.</param>
        public MLCloudModel (string tag) {
            this.tag = tag;
            this.inputs = new MLFeatureType[0];
            this.outputs = new MLFeatureType[0];
            this.metadata = new Dictionary<string, string>();
        }

        /// <summary>
        /// Make a prediction on one or more cloud ML features.
        /// Input and output features MUST be disposed when no longer needed.
        /// </summary>
        /// <param name="inputs">Input cloud ML features.</param>
        /// <returns>Output cloud ML features.</returns>
        public Task<MLFeatureCollection<MLCloudFeature>> Predict (params MLCloudFeature[] inputs) {
            return default;
        }
        #endregion


        #region --Operations--
        private readonly string tag;
        #endregion
    }
}