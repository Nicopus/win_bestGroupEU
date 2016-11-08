using _02350_FinalProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02350_FinalProject.ViewModel.Elements
{
    public abstract class ElementViewModel : BaseViewModel, IObject
    {
        public abstract List<string> Data { get; set; }
        protected Model.Object element { get; }
        public double CenterX => Width / 2 + X;
        public double CenterY => Height / 2 + Y;

        public int Number => element.Number;
        public EObject Type => element.Type;

        public double Height
        {
            get
            {
                return element.Height;
            }
            set
            {
                element.Height = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(CenterX));
            }
        }

        

        public double Width
        {
            get
            {
                return element.Width;
            }
            set
            {
                element.Width = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(CenterX));
            }
        }

        public double X
        {
            get
            {
                return element.X;
            }
            set
            {
                element.X = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(CenterX));
            }
        }

        public double Y
        {
            get
            {
                return element.Y;
            }
            set
            {
                element.Y = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(CenterY));
            }
        }

        
    }
}
