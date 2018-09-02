 private async Task<AnalysisResult> GetImageDescription (Stream imageStream) {
     VisionServiceClient visionClient = new VisionServiceClient ("4d673d0f18bc......add your keys", "https://westcentralus......add your endpoint");
     VisualFeature[] features = { VisualFeature.Tags };
     return await visionClient.AnalyzeImageAsync (imageStream, features.ToList (), null);
 }

 private async Task SelectPicture () {
     if (CrossMedia.Current.IsPickPhotoSupported) {
         var image = await CrossMedia.Current.PickPhotoAsync ();
         MyImage.Source = ImageSource.FromStream (() => {
             return image.GetStream ();
         });
         MyActivityIndicator.IsRunning = true;
         try {
             var result = await GetImageDescription (image.GetStream ());
             foreach (var tag in result.Tags) {
                 MyLabel.Text = MyLabel.Text + tag.Name + "\n";
             }
         } catch (ClientException ex) {
             MyLabel.Text = ex.Message;
         }
         // await CrossTextToSpeech.Current.Speak(MyLabel.Text);
         MyActivityIndicator.IsRunning = false;
     }
 }

 async void Handle_Click (object sender, EventArgs e) {
     await SelectPicture ();
     //	this.AnimationView.IsVisible = false;
 }
 }
 }