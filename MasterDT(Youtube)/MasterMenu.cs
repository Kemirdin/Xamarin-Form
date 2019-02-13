namespace mastdetail.Constants {
    public static class MasterMenu {
        static MasterMenu () {
            MasterMenuList = new ObservableCollection<MasterItem> () {
                new MasterItem () { Title = "Home", IconSource = "icon.png", IsLineVisible = false, TargetType = typeof (TopView) },
                new MasterItem () { Title = "View1", IconSource = "icon.png", IsLineVisible = false, TargetType = typeof (View1) },
                new MasterItem () { Title = "View2", IconSource = "icon.png", IsLineVisible = false, TargetType = typeof (View2) },
                new MasterItem () { Title = "View3", IconSource = "icon.png", IsLineVisible = true, TargetType = typeof (View3) },
                new MasterItem () { Title = "View4", IconSource = "icon.png", IsLineVisible = false, TargetType = typeof (View4) }
            };
        }

        public static readonly ObservableCollection<MasterItem> MasterMenuList;
    }
}