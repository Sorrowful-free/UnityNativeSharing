#if UNITY_WP8
using NativeSharing;

namespace Assets.NativeSharing.Adapters
{
    public class NativeSharingWP8Adapter:IShareAdapter
    {
        public void Share(string text)
        {
             WindowsSharing.ShareText(text);
        }

        public void Share(string imageUri, ImageTypeEnum imageType)
        {
            WindowsSharing.ShareImage(imageUri);
        }

        public void Share(string text, string imageUri, ImageTypeEnum imageType)
        {
            WindowsSharing.ShareTextAndImage(text,imageUri);
        }
    }
}
#endif