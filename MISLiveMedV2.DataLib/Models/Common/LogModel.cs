using System;
using MISLiveMed.Models.Models.Users;

namespace MISLiveMed.Models.Models.Common
{
    public class LogObjectModel : EntityObject
    {
        private int _categoryId;
        private int _actionTypeId;
        private UserModel _userId;
        private DateTime _transactionDate = DateTime.Now;

        //public LogObjectModel() { }

        public virtual int CategoryId
        {
            get => _categoryId;
            set => SetField(ref _categoryId, value);
        }

        public virtual int ActionTypeId
        {
            get => _actionTypeId;
            set => SetField(ref _actionTypeId, value);
        }

        public virtual UserModel UserId
        {
            get => _userId;
            set => SetField(ref _userId, value);
        }

        public virtual DateTime TransactionDate
        {
            get => _transactionDate;
            set => SetField(ref _transactionDate, value);
        }
    }
}
