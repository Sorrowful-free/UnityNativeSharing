#if UNITY_EDITOR
using UnityEngine;

namespace Assets.NativeSharing.Adapters
{
    public class NativeSharingEditorAdapter : IShareAdapter
    {
        public void Share(string text)
        {
            Debug.Log("share "+text);
        }

        public void Share(string imageUri, ImageTypeEnum imageType)
        {
            Debug.Log("share " + imageUri);
        }

        public void Share(string text, string imageUri, ImageTypeEnum imageType)
        {
            Debug.Log("share " + text + " " + imageUri);
        }
    }
}
#endif