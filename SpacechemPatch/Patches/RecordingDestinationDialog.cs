using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpacechemPatch.Patches
{
    [Decoy("#=qiB5cTsnhpRsLq9JzqNEKOfdr81cQLdqW6YCoxkk5Uj$GVwe7AaiSBmofb3gjMxt1")]
    internal sealed class RecordingDestinationDialog
    {
        [Decoy(".ctor")]
        public RecordingDestinationDialog(CapturedVideo capturedVideo, Score score)
        {

        }

        [Injected]
        public void OnSaveToDesktopClickBackdoor()
        {
            // We want to call OnSaveToDesktopClick() from another class despite it being private.
            // To make this possible, we inject this public method, which forwards the call
            // to the private method.
            OnSaveToDesktopClick();
        }

        [Decoy("#=qjk7eMQsbamCDH02RVR84w6JnpBFpJZQFE2SsI$0ZVEasPzHDvWrLOcLwQFlu2PIQ")]
        private void OnSaveToDesktopClick()
        {

        }
    }
}
