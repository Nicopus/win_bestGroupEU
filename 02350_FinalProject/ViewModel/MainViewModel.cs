using _02350_FinalProject.ViewModel.Elements;
using GalaSoft.MvvmLight.CommandWpf;
using System.Collections.Generic;
using System.Windows.Input;

namespace _02350_FinalProject.ViewModel
{
    public class MainViewModel : BaseViewModel
    {

        #region BindableProperties
        public ObservableElementsCollection Elements { get; }
        #endregion

        private bool _isAddingClassPressed;
        private bool _isAddingUsagePressed;
        private bool _isAddingUnidirPressed;
        private bool _isAddingBidirPressed;
        private bool _isAddingCompPressed;
        private bool _isAddingCommentPressed;

        public MainViewModel() : base()
        {
            Elements = new ObservableElementsCollection()
            {
                new ClassElementViewModel() {  X = 300, Y = 400, Width = 800, Height = 800 }
            };
        } 

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


        public RelayCommand ClassPressedCommand => new RelayCommand(ClassPressed);
        public RelayCommand UsagePressedCommand => new RelayCommand(UsagePressed);
        public RelayCommand UnidirPressedCommand => new RelayCommand(UnidirPressed);
        public RelayCommand BidirPressedCommand => new RelayCommand(BidirPressed);
        public RelayCommand CompPressedCommand => new RelayCommand(CompPressed);
        public RelayCommand CommentPressedCommand => new RelayCommand(CommentPressed);

        public RelayCommand<MouseButtonEventArgs> CreateObjectInCanvasCommand
            => new RelayCommand<MouseButtonEventArgs>(OnClickCreateObject, CanCreateObject);
        //public RelayCommand<> AddConnectionBetweenObjectsCommand = new RelayCommand<>;

        private void ClassPressed()
        {

        }

        private void UsagePressed()
        {

        }

        private void UnidirPressed()
        {

        }

        private void BidirPressed()
        {

        }

        private void CompPressed()
        {

        }

        private void CommentPressed()
        {

        } 

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