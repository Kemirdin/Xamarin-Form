namespace DemoApp.MasterDetailPage {

    public class MasterDetailPageTestMenuItem {
        public MasterDetailPageTestMenuItem () {
            TargetType = typeof (MasterDetailPageTestDetail);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}