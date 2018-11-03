Values = new ObservableCollection<Values> ();

ListViewConvertResult2.ItemsSource = Values;

Values.Clear ();

var units = (from i in database.GetAllUnits<Values> () where i.unit_source == unit_id orderby i.unit_value ascending select i);

foreach (var unit in units)
    Values.Add (unit);