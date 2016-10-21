#if UNITY_IPHONE
using System.Runtime.InteropServices;


namespace Assets.NativeSharing.Adapters
{
    public class NativeSharingiOSAdapter: IShareAdapter
    {
        [DllImport("__Internal")]
        private static extern void ShareText(string text);

        [DllImport("__Internal")]
        private static extern void ShareImage(string imagePath);

        [DllImport("__Internal")]
        private static extern void ShareTextAndImage(string text, string imagePath);

        public void Share(string text)
        {
            ShareText(text);
        }

        public void Share(string imageUri, ImageTypeEnum imageType)
        {
            ShareImage(imageUri);
        }

        public void Share(string text, string imageUri, ImageTypeEnum imageType)
        {
            ShareTextAndImage(text,imageUri);
        }
    }

}
#endif