using System;
using System.Collections.Generic;
using System.Text;

namespace ETrade.Bussiness.Abstract
{
    public interface IValidator<T>
    {
        public string ErrorMessage { get; set; }
        bool Validate(T entity);
    }
}
