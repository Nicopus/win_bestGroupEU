using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02350_FinalProject.Model;

namespace _02350_FinalProject.ViewModel.Objects
{
    public abstract class ObjectViewModel : BaseViewModel, IObject
    {

        #region Object Wrapper
        protected Model.Object Object { get; }
        protected ObjectViewModel(Model.Object obj)
        {
            Object = obj;
        }
        public List<string> Data { get; set; }

        public double Height
        {
            get { return Object.Height; }
            set
            {
                Object.Height = value;
            }
        }

        public int Number => Object.Number;

        public EObject Type => Object.Type;

        public double Width
        {
            get { return Object.Width; }
            set
            {
                Object.Width = value;
            }
        }

        public double X
        {
            get { return Object.X; }
            set
            {
                Object.X = value;
            }
        }

        public double Y
        {
            get { return Object.Y; }
            set
            {
                Object.Y = value;
            }
        }
    }

    #endregion
}
