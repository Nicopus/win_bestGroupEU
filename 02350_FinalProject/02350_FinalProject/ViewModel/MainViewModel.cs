﻿using GalaSoft.MvvmLight.CommandWpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace _02350_FinalProject.ViewModel
{
    class MainViewModel : BaseViewModel
    {
        private bool _isAddingClassPressed;
        private bool _isAddingUsagePressed;
        private bool _isAddingUnidirPressed;
        private bool _isAddingBidirPressed;
        private bool _isAddingCompPressed;
        private bool _isAddingCommentPressed;

        public bool IsAddingClassPressed
        {
            get { return _isAddingClassPressed; }
            set
            {
                _isAddingClassPressed = value;
                if (value)
                {
                    //IsAddingClassPressed = false;
                    IsAddingUsagePressed = false;
                    IsAddingUnidirPressed = false;
                    IsAddingBidirPressed = false;
                    IsAddingCompPressed = false;
                    IsAddingCommentPressed = false;
                }
                OnPropertyChanged();
                System.Diagnostics.Debug.WriteLine(_isAddingClassPressed);
            }
        }

        public bool IsAddingUsagePressed
        {
            get { return _isAddingUsagePressed; }
            set
            {
                _isAddingUsagePressed = value;
                if (value)
                {
                    IsAddingClassPressed = false;
                    //IsAddingUsagePressed = false;
                    IsAddingUnidirPressed = false;
                    IsAddingBidirPressed = false;
                    IsAddingCompPressed = false;
                    IsAddingCommentPressed = false;
                }
                OnPropertyChanged();
                System.Diagnostics.Debug.WriteLine(_isAddingUsagePressed);
            }
        }

        public bool IsAddingUnidirPressed
        {
            get { return _isAddingUnidirPressed; }
            set
            {
                _isAddingUnidirPressed = value;
                if (value)
                {
                    IsAddingClassPressed = false;
                    IsAddingUsagePressed = false;
                    //IsAddingUnidirPressed = false;
                    IsAddingBidirPressed = false;
                    IsAddingCompPressed = false;
                    IsAddingCommentPressed = false;
                }
                OnPropertyChanged();
                System.Diagnostics.Debug.WriteLine(_isAddingUnidirPressed);
            }
        }

        public bool IsAddingBidirPressed
        {
            get { return _isAddingBidirPressed; }
            set
            {
                _isAddingBidirPressed = value;
                if (value)
                {
                    IsAddingClassPressed = false;
                    IsAddingUsagePressed = false;
                    IsAddingUnidirPressed = false;
                    //IsAddingBidirPressed = false;
                    IsAddingCompPressed = false;
                    IsAddingCommentPressed = false;
                }
                OnPropertyChanged();
                System.Diagnostics.Debug.WriteLine(_isAddingBidirPressed);
            }
        }

        public bool IsAddingCompPressed
        {
            get { return _isAddingCompPressed; }
            set
            {
                _isAddingCompPressed = value;
                if (value)
                {
                    IsAddingClassPressed = false;
                    IsAddingUsagePressed = false;
                    IsAddingUnidirPressed = false;
                    IsAddingBidirPressed = false;
                    //IsAddingCompPressed = false;
                    IsAddingCommentPressed = false;
                }
                OnPropertyChanged();
                System.Diagnostics.Debug.WriteLine(_isAddingCompPressed);
            }
        }

        public bool IsAddingCommentPressed
        {
            get { return _isAddingCommentPressed; }
            set
            {
                _isAddingCommentPressed = value;
                if (value)
                {
                    IsAddingClassPressed = false;
                    IsAddingUsagePressed = false;
                    IsAddingUnidirPressed = false;
                    IsAddingBidirPressed = false;
                    IsAddingCompPressed = false;
                    //IsAddingCommentPressed = false;
                }
                OnPropertyChanged();
                System.Diagnostics.Debug.WriteLine(_isAddingCommentPressed);
            }
        }

        public RelayCommand<MouseButtonEventArgs> CreateShapeInCanvasCommand
            => new RelayCommand<MouseButtonEventArgs>(OnClickCreateObject, CanCreateObject);

        private bool CanCreateObject(MouseButtonEventArgs e)
        {
            return IsAddingClassPressed;
        }

        private void OnClickCreateObject(MouseButtonEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Det virker");
        }

    }
}
