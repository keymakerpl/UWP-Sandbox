using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UWP.Core.Models
{
    public abstract class ViewModel : ObservableObject, IDataErrorInfo
    {
        public string this[string propertyName] => OnValidate(propertyName);

        protected virtual string OnValidate(string propertyName)
        {
            var context = new ValidationContext(this)
            {
                MemberName = propertyName
            };

            var results = new Collection<ValidationResult>();
            var isValid = Validator.TryValidateObject(this, context, results, true);

            return !isValid ? results[0].ErrorMessage : null;
        }

        public string Error => throw new NotSupportedException();
    }
}
