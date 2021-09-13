using DomStroyB2C_MVVM.API.Minimal;
using DomStroyB2C_MVVM.API.Minimal.MinimalService;
using DomStroyB2C_MVVM.Commands;
using DomStroyB2C_MVVM.Views.ModalViews;
using System.Collections.Generic;
using System.Windows;

namespace DomStroyB2C_MVVM.ViewModels.ModalViewModels
{
    class ResidueSettingViewModel : BaseViewModel
    {
        #region Constructor

        public ResidueSettingViewModel(string product_id, string productName, ResidueSettingView view)
        {
            _view = view;
            this.product_id = product_id;
            this.ProductName = productName;
            LoadingVisibility = Visibility.Collapsed;
            _minimalService = new MinimalService();
            GetProductMinimal();
            SubmitMinimalCommand = new RelayCommand(SubmitMinimal);
        }

        #endregion

        #region Private Fields

        private string product_id { get; set; }

        private string productName;

        public string ProductName
        {
            get { return productName; }
            set { productName = value; OnPropertyChanged("ProductName"); }
        }


        private ResidueSettingView _view { get; set; }

        private MinimalService _minimalService { get; set; }

        private Visibility loadingVisibility;

        public Visibility LoadingVisibility
        {
            get { return loadingVisibility; }
            set { loadingVisibility = value; OnPropertyChanged("LoadingVisibility"); }
        }

        private ProductMinimal minimal;

        public ProductMinimal Minimal
        {
            get { return minimal; }
            set { minimal = value; OnPropertyChanged("Minimal"); }
        }


        private string january;

        public string January
        {
            get { return january; }
            set { january = value; OnPropertyChanged("January"); }
        }
        private string february;

        public string February
        {
            get { return february; }
            set { february = value; OnPropertyChanged("February"); }
        }

        private string march;

        public string March
        {
            get { return march; }
            set { march = value; OnPropertyChanged("March"); }
        }

        private string april;

        public string April
        {
            get { return april; }
            set { april = value; OnPropertyChanged("April"); }
        }

        private string may;

        public string May
        {
            get { return may; }
            set { may = value; OnPropertyChanged("May"); }
        }

        private string june;

        public string June
        {
            get { return june; }
            set { june = value; OnPropertyChanged("June"); }
        }

        private string july;

        public string July
        {
            get { return july; }
            set { july = value; OnPropertyChanged("July"); }
        }

        private string august;

        public string August
        {
            get { return august; }
            set { august = value; OnPropertyChanged("August"); }
        }

        private string september;

        public string September
        {
            get { return september; }
            set { september = value; OnPropertyChanged("September"); }
        }

        private string october;

        public string October
        {
            get { return october; }
            set { october = value; OnPropertyChanged("October"); }
        }

        private string november;

        public string November
        {
            get { return november; }
            set { november = value; OnPropertyChanged("November"); }
        }
        private string december;

        public string December
        {
            get { return december; }
            set { december = value; OnPropertyChanged("December"); }
        }

        #endregion

        #region Commands

        public RelayCommand SubmitMinimalCommand { get; set; }

        #endregion

        #region Helper Methods

        /// <summary>
        /// The function to get the product minimal amount month by month
        /// </summary>
        public async void GetProductMinimal()
        {
            LoadingVisibility = Visibility.Visible;
            Minimal = await _minimalService.Get(product_id);
            if (Minimal.minimals.Count > 0)
            {
                foreach (var item in Minimal.minimals)
                {
                    switch (item.month)
                    {
                        case "january":
                            January = item.amount.ToString();
                            break;
                        case "february":
                            February = item.amount.ToString();
                            break;
                        case "march":
                            March = item.amount.ToString();
                            break;
                        case "april":
                            April = item.amount.ToString();
                            break;
                        case "may":
                            May = item.amount.ToString();
                            break;
                        case "june":
                            June = item.amount.ToString();
                            break;
                        case "july":
                            July = item.amount.ToString();
                            break;
                        case "august":
                            August = item.amount.ToString();
                            break;
                        case "september":
                            September = item.amount.ToString();
                            break;
                        case "october":
                            October = item.amount.ToString();
                            break;
                        case "november":
                            November = item.amount.ToString();
                            break;
                        case "december":
                            December = item.amount.ToString();
                            break;
                    }
                }
            }
            LoadingVisibility = Visibility.Collapsed;

        }

        /// <summary>
        /// The function to post product minmal amount month by month
        /// </summary>
        public async void SubmitMinimal()
        {
            LoadingVisibility = Visibility.Visible;

            MinimalPost model = new MinimalPost();
            model.product = product_id;

            List<Minimal1> minimals = new List<Minimal1>();

            #region Checking each month if it is not null

            if (!string.IsNullOrEmpty(January))
            {
                minimals.Add(new Minimal1() { amount = double.Parse(January), month = "january" });
            }

            if (!string.IsNullOrEmpty(February))
            {
                minimals.Add(new Minimal1() { amount = double.Parse(February), month = "february" });
            }

            if (!string.IsNullOrEmpty(March))
            {
                minimals.Add(new Minimal1() { amount = double.Parse(March), month = "march" });
            }

            if (!string.IsNullOrEmpty(April))
            {
                minimals.Add(new Minimal1() { amount = double.Parse(April), month = "april" });
            }

            if (!string.IsNullOrEmpty(May))
            {
                minimals.Add(new Minimal1() { amount = double.Parse(May), month = "may" });
            }

            if (!string.IsNullOrEmpty(June))
            {
                minimals.Add(new Minimal1() { amount = double.Parse(June), month = "june" });
            }

            if (!string.IsNullOrEmpty(July))
            {
                minimals.Add(new Minimal1() { amount = double.Parse(July), month = "july" });
            }

            if (!string.IsNullOrEmpty(August))
            {
                minimals.Add(new Minimal1() { amount = double.Parse(August), month = "august" });
            }

            if (!string.IsNullOrEmpty(September))
            {
                minimals.Add(new Minimal1() { amount = double.Parse(September), month = "september" });
            }

            if (!string.IsNullOrEmpty(October))
            {
                minimals.Add(new Minimal1() { amount = double.Parse(October), month = "october" });
            }

            if (!string.IsNullOrEmpty(November))
            {
                minimals.Add(new Minimal1() { amount = double.Parse(November), month = "november" });
            }

            if (!string.IsNullOrEmpty(December))
            {
                minimals.Add(new Minimal1() { amount = double.Parse(December), month = "december" });
            }

            #endregion

            model.minimals = minimals;

            bool result = await _minimalService.Post(model);

            LoadingVisibility = Visibility.Collapsed;

            if(result)
            {
                MessageView message = new MessageView()
                {
                    DataContext = new MessageViewModel("../../Images/message.Success.png", "Maxsulotning minimal miqdori muvaffaqiyatli yangilandi!")
                };
                message.ShowDialog();
                _view.Close();
            }
            else
            {
                MessageView message = new MessageView()
                {
                    DataContext = new MessageViewModel("../../Images/message.Error.png", "Maxsulotning minimal miqdori yangilashda xatolik")
                };
                message.ShowDialog();
            }
        }

        #endregion
    }
}
