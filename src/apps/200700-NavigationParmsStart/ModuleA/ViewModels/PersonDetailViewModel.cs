using ModuleA;
using Prism.Mvvm;

namespace ModuleA.ViewModels
{
    public class PersonDetailViewModel : BindableBase
    {
        private Person _selectedPerson = default!;
        public Person SelectedPerson
        {
            get { return _selectedPerson; }
            set { SetProperty(ref _selectedPerson, value); }
        }

        public PersonDetailViewModel()
        {

        }
    }
}
