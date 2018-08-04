using System;
using System.Collections.ObjectModel;
using MyListView.Models;
using MyListView.MyDataSource;

namespace MyListView.ViewModels {
    public class HumanViewModels {
        private ObservableCollection<Human> humans;
        public ObservableCollection<Human> Humans {
            get { return humans; }
            set {
                humans = value;
            }
        }

        public HumanViewModels () {

            Humans = new ObservableCollection<Human> ();

            MyData1 _context = new MyData1 ();

            foreach (var human in _context.Humans) {
                Humans.Add (human);
            }
        }

    }
}