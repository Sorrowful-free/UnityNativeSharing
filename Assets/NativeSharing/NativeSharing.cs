using Assets.NativeSharing.Adapters;
using UnityEngine;

namespace Assets.NativeSharing
{
    public static class NativeSharing
    {
        private static IShareAdapter _adapter;

        private static IShareAdapter Adapter
        {
            get
            {
                if (_adapter == null)
                {
#if UNITY_ANDROID
                    _adapter = new NativeSharingAndroidAdapter();
#elif UNITY_IPHONE
                    _adapter = new NativeSharingiOSAdapter();
#elif UNITY_WP8
                    _adapter = new NativeSharingWP8Adapter();
#elif UNITY_WSA
                    _adapter = new NativeSharingWSAAdapter();
#elif UNITY_EDITOR
                    _adapter = new NativeSharingEditorAdapter();
#endif
                }
                return _adapter;
            }
        }
        public static void Share(string text)
        {
            Adapter.Share(text);
        }

        public static void Share(string imageUri,ImageTypeEnum imageType)
        {
            Adapter.Share(imageUri,imageType);
        }

        public static void Share(string text, string imageUri, ImageTypeEnum imageType)
        {
            Adapter.Share(text,imageUri,imageType);
        }
    }
}
