#if UNITY_WSA
using NativeSharing;

namespace Assets.NativeSharing.Adapters
{
    public class NativeSharingWSAAdapter:IShareAdapter
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