using ArcGIS.Desktop.Framework;
using ArcGIS.Desktop.Framework.Contracts;

namespace UnifiedPipelineTools
{
    internal class UnifiedPipelineToolsModule : Module
    {
        private static UnifiedPipelineToolsModule _this = null;

        /// <summary>
        /// Retrieve the singleton instance to this module here
        /// </summary>
        public static UnifiedPipelineToolsModule Current => _this ??= (UnifiedPipelineToolsModule)FrameworkApplication.FindModule("UnifiedPipelineTools_Module");

        #region Overrides
        /// <summary>
        /// Called by Framework when ArcGIS Pro is closing
        /// </summary>
        /// <returns>False to prevent Pro from closing, otherwise True</returns>
        protected override bool CanUnload()
        {
            //TODO - add your business logic
            //return false to ~cancel~ Application close
            return true;
        }

        #endregion Overrides

    }
}
