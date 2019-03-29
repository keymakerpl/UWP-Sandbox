using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWP.ViewModels;

namespace UWP.ViewModels
{
    public class CustomerViewModel : ViewModel
    {
        private string _customerName;

        [Required]
        public string CustomerName
        {
            get { return _customerName; }
            set
            {
                _customerName = value;
                NotifyPropertyChanged();
            }
        }

        protected override string OnValidate(string propertyName)
        {
            if (CustomerName != null && CustomerName.Length < 4)
            {
                return "Name must have min 4 characters";
            }

            return base.OnValidate(propertyName);
        }

    }
}
