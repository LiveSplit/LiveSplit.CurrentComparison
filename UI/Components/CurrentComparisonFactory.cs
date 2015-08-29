using LiveSplit.Model;
using System;

namespace LiveSplit.UI.Components
{
    public class CurrentComparisonFactory : IComponentFactory
    {
        public string ComponentName
        {
            get { return "Current Comparison"; }
        }

        public string Description
        {
            get { return "Shows which comparison you are currently comparing to."; }
        }

        public ComponentCategory Category
        {
            get { return ComponentCategory.Information; }
        }

        public IComponent Create(LiveSplitState state)
        {
            return new CurrentComparison(state);
        }

        public string UpdateName
        {
            get { return ComponentName; }
        }

        public string XMLURL
        {
#if RELEASE_CANDIDATE
            get { return "http://livesplit.org/update_rc_sdhjdop/Components/update.LiveSplit.CurrentComparison.xml"; }
#else
            get { return "http://livesplit.org/update/Components/update.LiveSplit.CurrentComparison.xml"; }
#endif
        }

        public string UpdateURL
        {
#if RELEASE_CANDIDATE
            get { return "http://livesplit.org/update_rc_sdhjdop/"; }
#else
            get { return "http://livesplit.org/update/"; }
#endif
        }

        public Version Version
        {
            get { return Version.Parse("1.6"); }
        }
    }
}
