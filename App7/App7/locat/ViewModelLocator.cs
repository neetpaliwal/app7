using System;
using System.Collections.Generic;
using System.Text;
using App7;
using CommonServiceLocator;
//using Microsoft.Practices.ServiceLocation;


namespace App7.locat
{
    public class ViewModelLocator
    {
        public ProductsViewModel ProductsViewModel
        {
            get { return ServiceLocator.Current.GetInstance<ProductsViewModel>(); }
        }
    }
}
