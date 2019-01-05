public partial class PostDetail : ContentPage {
    PostDetailViewModel postDetailViewModel;

    public PostDetail () {
        InitializeComponent ();
    }

    public PostDetail (Post post) {
        InitializeComponent ();
        postDetailViewModel = new PostDetailViewModel (post);
        this.BindingContext = postDetailViewModel;
    }
}