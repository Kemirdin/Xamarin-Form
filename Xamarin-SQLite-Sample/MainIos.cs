public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate

{

    //

    // This method is invoked when the application has loaded and is ready to run. In this 

    // method you should instantiate the window, load the UI into it and then make the window

    // visible.

    //

    // You have 17 seconds to return from this method, or iOS will terminate your application.

    //

    public override bool FinishedLaunching (UIApplication app, NSDictionary options)

    {

        global::Xamarin.Forms.Forms.Init ();

        LoadApplication (new App (OnSaveSignature));

        return base.FinishedLaunching (app, options);

    }

    private async Task<bool> OnSaveSignature (Stream bitmap, string filename)

    {

        var tcs = new TaskCompletionSource<bool> ();

        UIImage image;

        using (var data = NSData.FromStream (bitmap))

        {

            image = UIImage.LoadFromData (data);

        }

        var status = await PHPhotoLibrary.RequestAuthorizationAsync ();

        if (status == PHAuthorizationStatus.Authorized)

        {

            image.SaveToPhotosAlbum ((i, error) =>

                {

                    image.Dispose ();

                    tcs.TrySetResult (error == null);

                });

        } else

        {

            tcs.TrySetResult (false);

        }

        return await tcs.Task;

    }

}

}