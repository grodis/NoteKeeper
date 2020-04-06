using System;
using System.Collections.Generic;
using NoteKeeper.Models;

namespace NoteKeeper.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Note Note{ get; set; }
        public IList<string> CourseList { get; set; }

        public string NoteHeading
        {
            get { return Note.Heading;  }
            set
            {
                Note.Heading = value;
                OnPropertyChanged();
            }
        }

        public ItemDetailViewModel(Item item = null)
        {
            Title = item?.Text;
            InitializeCourseList();
            Note = new Note
            {
                Heading = "Test note",
                Text = "Text for note in ViewModel",
                Course = CourseList[0]
            };
        }

        async void InitializeCourseList()
        {
            CourseList = await NoteKeeperDataStore.GetCoursesAsync();
        }
    }
}
