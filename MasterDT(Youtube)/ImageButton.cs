namespace .Controls {
    public class ImageButton : Button {
        public ImageButton () : base () {
            const int _animationTime = 100;
            Pressed += async (sender, e) => {
                var btn = sender as ImageButton;

                if (btn != null) {
                    await btn.ScaleTo (0.5, _animationTime);
                    await btn.ScaleTo (1, _animationTime);
                }
            };
        }
    }
}