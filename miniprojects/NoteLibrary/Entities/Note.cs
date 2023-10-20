using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteLibrary.Entities
{
    public class Note : ObservableObject
    {
        private string _title;
        private DateTime _updatedAt;
        private bool _isEditMode;

        public int Id { get; set; }

        public int NotebookId { get; set; }

        public DateTime CreatedAt { get; set; }

        public string FileLocation { get; set; }

        public bool IsEditMode
        {
            get => _isEditMode;
            set
            {
                OnPropertyChanged(ref _isEditMode, value);
                OnPropertyChanged(nameof(IsDisplayMode));
            }
        }

        public bool IsDisplayMode { get => !IsEditMode; }
    }
}
