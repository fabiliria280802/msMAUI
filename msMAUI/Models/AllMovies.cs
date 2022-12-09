using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Android.Provider.ContactsContract.CommonDataKinds;

namespace msMAUI.Models
{
    internal class AllMovies
    {
        public ObservableCollection<Movie> Movies { get; set; } = new ObservableCollection<Movie>();
    }
}
