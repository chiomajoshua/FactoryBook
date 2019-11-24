using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FactoryBook.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        #region Protected Members

        /// <summary>
        /// A global lock for property checks so prevent locking on different instances of expressions.
        /// Considering how fast this check will always be it isn't an issue to globally lock all callers.
        /// </summary>
        protected object mPropertyValueCheckLock = new object();

        #endregion

        public BaseViewModel()
        {

        }




        public event PropertyChangedEventHandler PropertyChanged = (sender, e) => { };

        protected void OnPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #region Fields
        /// <summary>
        /// A dictionary of property names, property values. The property name is the
        /// key to find the property value.
        /// </summary>
        private readonly Dictionary<string, object> _values = new Dictionary<string, object>();



        #endregion

        protected void SetValue<T>(T value, [CallerMemberName] string propertyName = null)
        {
            if (string.IsNullOrEmpty(propertyName))
            {

                throw new ArgumentException("Invalid property name", propertyName);
            }
            _values[propertyName] = value;
            NotifyPropertyChanged(propertyName);
        }

        protected void SetValue<T>(Expression<Func<T>> propertyselector, T value)
        {
            string propertyName = GetPropertyName(propertyselector);
            SetValue<T>(value, propertyName);
        }


        protected T GetValue<T>(Expression<Func<T>> propertySelector)
        {
            string propertyName = GetPropertyName(propertySelector);
            return GetValue<T>(propertyName);
        }


        /// <summary>
        /// When overriden in a derived view model class, can be used to sort gather search item for the value wild card
        /// </summary>
        /// <param name="value">the data to search your collection ofr</param>
        /// <returns></returns>


        protected T GetValue<T>([CallerMemberName]string propertyName = null)
        {
            if (string.IsNullOrEmpty(propertyName))
            {
                throw new ArgumentException("Invalid property name", propertyName);
            }
            object value;
            if (!_values.TryGetValue(propertyName, out value))
            {
                value = default(T);
                _values.Add(propertyName, value);
            }
            return (T)value;
        }

        protected void NotifyPropertyChanged(string propertyName)
        {

            PropertyChangedEventHandler handler = this.PropertyChanged;
            if (handler != null)
            {
                var e = new PropertyChangedEventArgs(propertyName);
                handler(this, e);
            }
        }


        protected void NotifyPropertyChanged<T>(Expression<Func<T>> propertySelector)
        {
            var propertyChanged = PropertyChanged;
            if (propertyChanged != null)
            {
                string propertyName = GetPropertyName(propertySelector);
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }



        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }



        private string GetPropertyName(LambdaExpression expression)
        {
            var memberExpression = expression.Body as MemberExpression;
            if (memberExpression == null)
            {
                throw new InvalidOperationException();
            }
            return memberExpression.Member.Name;
        }

        private object GetValue(string propertyName)
        {
            object value;
            if (!_values.TryGetValue(propertyName, out value))
            {
                var propertyDescriptor =
                TypeDescriptor.GetProperties(GetType()).Find(propertyName, false);
                if (propertyDescriptor == null)
                {
                    throw new ArgumentException("Invalid property name", propertyName);
                }
                value = propertyDescriptor.GetValue(this);
                _values.Add(propertyName, value);
            }
            return value;
        }

        public App AppInstance => (App)Application.Current;
    }
}