using System.Windows;
using System.Windows.Controls;

namespace _02350_FinalProject.View.ExtendedComponent
{
    /// <summary>
    /// Description for ElementListBox.
    /// </summary>
    public partial class ElementListBox : ListBox
    {
        /// <summary>
        /// Initializes a new instance of the ElementListBox class.
        /// </summary>
        public ElementListBox()
        {
            InitializeComponent();
        }

        #region override default Container 

        protected override DependencyObject GetContainerForItemOverride()
        {
            return new ElementListBox();
        }
        protected override bool IsItemItsOwnContainerOverride(object item)
        {
            return (item is ElementListBox);
        }
        #endregion
    }
}