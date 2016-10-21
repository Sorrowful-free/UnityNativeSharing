#if UNITY_ANDROID
using UnityEngine;


namespace Assets.NativeSharing.Adapters
{
    public class NativeSharingAndroidAdapter : IShareAdapter
    {
        private AndroidJavaObject _currentActivity;
        private AndroidJavaObject CurrentActivity
        {
            get
            {
                if (_currentActivity == null)
                {
                    AndroidJavaClass javaClassUnityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
                    _currentActivity = javaClassUnityPlayer.GetStatic<AndroidJavaObject>("currentActivity");    
                }
                return _currentActivity;
            }
            
         }

        private AndroidJavaClass _sharingAndroidJavaClass;

        private AndroidJavaClass SharingAndroidJavaClass
        {
            get
            {
                if (_sharingAndroidJavaClass == null)
                {
                    _sharingAndroidJavaClass = new AndroidJavaClass("com.milkygames.androidsharing.AndroidSharing");
                }
                return _sharingAndroidJavaClass;
            }
        }
        
        public void Share(string text)
        {
            SharingAndroidJavaClass.CallStatic("ShareText",CurrentActivity,text);
        }

        public void Share(string imageUri, ImageTypeEnum imageType)
        {
            switch (imageType)
            {
                default:
                case ImageTypeEnum.Png:
                    SharingAndroidJavaClass.CallStatic("ShareImagePNG", CurrentActivity, imageUri);
                    break;
                case ImageTypeEnum.Jpeg:
                    SharingAndroidJavaClass.CallStatic("ShareImageJPEG", CurrentActivity, imageUri);
                    break;
            }
            
        }

        public void Share(string text, string imageUri, ImageTypeEnum imageType)
        {
            switch (imageType)
            {
                default:
                case ImageTypeEnum.Png:
                    SharingAndroidJavaClass.CallStatic("ShareTextImagePNG", CurrentActivity, text, imageUri);
                    break;
                case ImageTypeEnum.Jpeg:
                    SharingAndroidJavaClass.CallStatic("ShareTextImageJPEG", CurrentActivity, text, imageUri);
                    break;
            }
        }
    }

}
#endif
