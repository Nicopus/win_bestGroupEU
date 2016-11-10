using _02350_FinalProject.Model;
using GalaSoft.MvvmLight;

namespace _02350_FinalProject.ViewModel.Elements
{
    /// <summary>
    /// This class contains properties that a View can data bind to.
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class ClassElementViewModel : ElementViewModel
    {
        public ClassElementViewModel(Object element) : base(element)
        {
            Height = 300;
            Width = 200;
        }
        public ClassElementViewModel():this(new Object()){ }
    }
}