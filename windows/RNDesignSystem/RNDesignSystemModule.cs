using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Design.System.RNDesignSystem
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNDesignSystemModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNDesignSystemModule"/>.
        /// </summary>
        internal RNDesignSystemModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNDesignSystem";
            }
        }
    }
}
