using System;
using Windows.ApplicationModel.DataTransfer;
using Windows.Foundation;
using Windows.Storage.Streams;

namespace NativeSharing
{
    public static class WindowsSharing
    {
        private static DataTransferManager _manager;

        private static DataTransferManager Manager
        {
            get
            {
                if (_manager == null)
                {
                    _manager = DataTransferManager.GetForCurrentView();
                }
                return _manager;
            }
        }

        public static void ShareText(string text)
        {
           var  handler = default (TypedEventHandler<DataTransferManager, DataRequestedEventArgs>);
            handler = new TypedEventHandler<DataTransferManager, DataRequestedEventArgs>((manager, args) =>
            {
                args.Request.Data.SetText(text);
                Manager.DataRequested -= handler;
            });
            Manager.DataRequested += handler;
            DataTransferManager.ShowShareUI();
        }

        public static void ShareImage(string imagePath)
        {
            var handler = default(TypedEventHandler<DataTransferManager, DataRequestedEventArgs>);
            handler = new TypedEventHandler<DataTransferManager, DataRequestedEventArgs>((manager, args) =>
            {
                var reference = RandomAccessStreamReference.CreateFromUri(new Uri(imagePath));
                args.Request.Data.SetBitmap(reference);
                Manager.DataRequested -= handler;
            });
            Manager.DataRequested += handler;
            DataTransferManager.ShowShareUI();
        }

        public static void ShareTextAndImage(string text, string imagePath)
        {
            var handler = default(TypedEventHandler<DataTransferManager, DataRequestedEventArgs>);
            handler = new TypedEventHandler<DataTransferManager, DataRequestedEventArgs>((manager, args) =>
            {
                var reference = RandomAccessStreamReference.CreateFromUri(new Uri(imagePath));
                args.Request.Data.SetText(text);
                args.Request.Data.SetBitmap(reference);
                Manager.DataRequested -= handler;
            });
            Manager.DataRequested += handler;
            DataTransferManager.ShowShareUI();
        }
    }
}
