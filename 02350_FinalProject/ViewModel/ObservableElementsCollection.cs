using _02350_FinalProject.ViewModel.Elements;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02350_FinalProject.ViewModel
{
    public class ObservableElementsCollection : ObservableCollection<ElementViewModel>
    {
        public new void Add(ElementViewModel element)
        {
            base.Add(element);
        }
    }
}
