public class SessionViewModel {
    public SessionViewModel () {
        Sessions = new ObservableCollection<Session> ();
    }

    public ObservableCollection<Session> Sessions { get; set; }

    public async Task LoadDataAsync () {
        await Task.Run (() => {
            if (Sessions.Count == 0) {
                var sessions = SessionsDataSource.GetSessions ();
                foreach (var session in sessions) {
                    Sessions.Add (session);
                }
            }
        });
    }
}