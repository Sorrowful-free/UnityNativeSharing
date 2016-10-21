namespace Assets.NativeSharing
{
    internal interface IShareAdapter
    {
        void Share(string text);

        void Share(string imageUri, ImageTypeEnum imageType);

        void Share(string text, string imageUri, ImageTypeEnum imageType);
    }
}