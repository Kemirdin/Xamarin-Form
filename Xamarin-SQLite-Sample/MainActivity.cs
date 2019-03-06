namespace SignatureDemo.Droid

{

    [Activity (Label = "SignatureDemo", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]

    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity

    {

        protected override void OnCreate (Bundle savedInstanceState)

        {

            TabLayoutResource = Resource.Layout.Tabbar;

            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate (savedInstanceState);

            global::Xamarin.Forms.Forms.Init (this, savedInstanceState);

            LoadApplication (new App (OnSaveSignature));

        }

        private async Task<bool> OnSaveSignature (Stream bitmap, string filename)

        {

            var path = Environment.GetExternalStoragePublicDirectory (Environment.DirectoryPictures).AbsolutePath;

            var file = Path.Combine (path, "signature.png");

            using (var dest = File.OpenWrite (file))

            {

                await bitmap.CopyToAsync (dest);

            }

            return true;

        }

    }

}