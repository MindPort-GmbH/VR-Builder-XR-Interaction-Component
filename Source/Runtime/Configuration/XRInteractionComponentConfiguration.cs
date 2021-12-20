using VRBuilder.Core.Configuration;

namespace VRBuilder.XRInteraction.Configuration
{
    public class XRInteractionComponentConfiguration : IInteractionComponentConfiguration
    {
        public string DisplayName => "XR Interaction Component";

        public bool IsXRInteractionComponent => true;
    }
}