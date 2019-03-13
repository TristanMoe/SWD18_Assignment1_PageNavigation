using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarnGo.ViewModelLocator
{
    public class ViewModelLocator
    {
        #region Constructors
        private ViewModelLocator() { }
        #endregion

        #region Public Properties
        /// <summary>
        /// Singleton instance of ViewModelLocator
        /// </summary>
        public static ViewModelLocator Instance { get; } = new ViewModelLocator();

        /// <summary>
        /// Singleton instance of ViewModelLocator
        /// </summary>
        public static CarnGo.ViewModel.ApplicationViewModel ApplicationViewModel { get; set; } = new CarnGo.ViewModel.ApplicationViewModel(); 
        #endregion




    }
}
