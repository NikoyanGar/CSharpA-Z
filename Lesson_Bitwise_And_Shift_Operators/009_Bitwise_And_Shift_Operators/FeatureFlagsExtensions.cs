using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_Bitwise_And_Shift_Operators
{
    internal static class FeatureFlagsExtensions
    {
        public static FeatureFlags SetFlag(this FeatureFlags flags, FeatureFlags flagToSet)
        {
            return flags | flagToSet;
        }

        public static FeatureFlags ClearFlag(this FeatureFlags flags, FeatureFlags flagToClear)
        {
            return flags & ~flagToClear;
        }

        public static FeatureFlags ToggleFlag(this FeatureFlags flags, FeatureFlags flagToToggle)
        {
            return flags ^ flagToToggle;
        }
    }
}
