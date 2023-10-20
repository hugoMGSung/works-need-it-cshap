using System.Collections.ObjectModel;

namespace NoteLibrary.Entities
{
    public class Notebook : ObservableObject
    {
        private string _name;
        private bool _isEditMode;

        public int Id { get; set; }
        
        public string Name { 
            get => _name; 
            set => OnPropertyChanged(ref _name, value);
        }

        public bool IsEditMode { 
            get => _isEditMode;
            set
            {
                OnPropertyChanged(ref _isEditMode, value);
                OnPropertyChanged(nameof(IsDisplayMode));
            }
        }

        public bool IsDisplayMode { get => !IsEditMode; }

        public ObservableCollection<Note> Notes { get; set; } = new();
    }
}
