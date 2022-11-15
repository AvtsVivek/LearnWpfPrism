using ModuleA;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.ObjectModel;

namespace ModuleA.ViewModels
{
    public class PersonListViewModel : BindableBase
    {
        private ObservableCollection<Person> _people = default!;
        private readonly IRegionManager _regionManger;
        public ObservableCollection<Person> People
        {
            get { return _people; }
            set { SetProperty(ref _people, value); }
        }

        public DelegateCommand GoForwardCommand { get; set; } = default!;
        public DelegateCommand<Person> PersonSelectedCommand { get; private set; }

        public PersonListViewModel(IRegionManager regionManger)
        {
            GoForwardCommand = new DelegateCommand(GoForward, CanGoForward);
            PersonSelectedCommand = new DelegateCommand<Person>(PersonSelected);
            CreatePeople();
            _regionManger = regionManger;
        }

        private void PersonSelected(Person person)
        {
            if (person == null)
                return;

            var p = new NavigationParameters();
            p.Add("person", person);

            _regionManger.RequestNavigate("ContentRegion", "PersonDetail", p);
        }

        //demo code only, use a service in production code
        private void CreatePeople()
        {
            var people = new ObservableCollection<Person>();
            for (int i = 0; i < 10; i++)
            {
                people.Add(new Person()
                {
                    FirstName = String.Format("First {0}", i),
                    LastName = String.Format("Last {0}", i),
                    Age = i
                });
            }

            People = people;
        }

        private void GoForward()
        {

        }

        private bool CanGoForward()
        {
            return false;
        }
    }
}
