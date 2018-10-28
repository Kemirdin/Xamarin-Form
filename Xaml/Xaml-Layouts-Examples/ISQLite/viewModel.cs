  public ICommand AddTeamCommand { get; private set; }
  public int TogglePlayerWithParameterResult { get; private set; }
  public ICommand TogglePlayerCommandWithParameterCommand { get; private set; }

  public ViewModelTeamAdd (INavigation navigation) {
      ...items removed
      PlayerList = dbHelper.GetAllPlayerData ();

      AddTeamCommand = new Command (async () => await AddTeam ());
      TogglePlayerCommandWithParameterCommand = new Command<int> (SetToggleSwitch);
  }