using BlocAppCore.IServices;
using BlocDomain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlocAppCore.Services
{
    public abstract class BaseServices<T> : IServices<T>
    {
        private IModel<T> Model;

        protected BaseServices(IModel<T> model)
        {
            this.Model = model;
        }

        public void Create(T t)
        {
            Model.Create(t);
        }

        public  void Delete (T t)
        {
            Model.Delete(t);
        }
    }
}
