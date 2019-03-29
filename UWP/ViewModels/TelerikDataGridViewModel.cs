using System;
using System.Collections.ObjectModel;

using GalaSoft.MvvmLight;
using UWP.Core.Models;
using UWP.Core.Services;

namespace UWP.ViewModels
{
    public class TelerikDataGridViewModel : ViewModelBase
    {
        public ObservableCollection<Customer> Source
        {
            get
            {
                using (var db = new RmaBuddyContext())
                {
                    var collection = new ObservableCollection<Customer>();
                    collection.Add(new Customer(){ CustomerId = 1, FirstName = "Jan", LastName = "Nowak", Symbol = (char)57661 });
                        
                    return collection;
                }

                // TODO WTS: Replace this with your actual data
                //return SampleDataService.GetGridSampleData();
            }
        }
    }
}
