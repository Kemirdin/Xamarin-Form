namespace mastdetail.Services {
    public class WebService {
        public ObservableCollection<AEDModel> AEDList;
        public string AED_URL = "https://";
        public async Task<ObservableCollection<AEDModel>> GetAEDDataAsync () {
            var handler = new HttpClientHandler () { AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate };
            handler.Proxy = WebRequest.DefaultWebProxy;
            ObservableCollection<AEDModel> responseModels;

            using (var client = new HttpClient (handler)) {
                var url = new Uri (AED_URL);
                var response = await client.GetAsync (url);
                var responseText = await response.Content.ReadAsStringAsync ();
                responseModels = JsonConvert.DeserializeObject<ObservableCollection<AEDModel>> (responseText);
            }

            return responseModels;
        }
    }
}