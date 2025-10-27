using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MISLiveMed.Models.Models
{
    public class EntityObject : INotifyPropertyChanging, INotifyPropertyChanged
    {
        private static PropertyChangingEventArgs _emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

        public int Id { get; set; }
        public string Notes { get; set; }
        public int CompanyId { get; set; }
        public int BranchId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public int WorkingYear { get; set; }
        public bool IsProtected { get; set; }
        public bool IsDefault { get; set; }
        public bool Active { get; set; }
        public bool Locked { get; set; }
        public bool Deleted { get; set; }


		#region Implementation of INotifyProperty EventHandler

		//

		public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }

        //

        public event PropertyChangingEventHandler PropertyChanging;
        protected virtual void SendPropertyChanging()
        {
            if (PropertyChanging == null)
                return;
            PropertyChanging(this, _emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(string propertyName)
        {
            if (PropertyChanged == null)
                return;
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }


        #endregion

    }
}
