using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfMVVM.Core;
using WpfMVVM.MVVM.Model;

namespace WpfMVVM.MVVM.ViewModel
{
    internal class MainViewModel : ObservableObject
    {

        public RelayCommand SzyfrujCommand { get; set; }
        public RelayCommand OdszyfrujCommand { get; set; }
        public MainViewModel()
        {
            

            SzyfrujCommand = new RelayCommand(o =>
            {
                Zawartosc = BSK4.SzyfrStrumieniowy.Encrypt(TextBoxValue, wielomian1, ziarno1);
            });
            OdszyfrujCommand = new RelayCommand(o => 
            {
                Zawartosc2 = BSK4.SzyfrStrumieniowy.Decrypt(TextBoxValue2, wielomian2, ziarno2);
            });

        }

        public string Zawartosc
        {
            get { return _zawartosc; }
            set
            {
                _zawartosc = value;
                OnPropertyChanged();
            }
        }
        private string _zawartosc;

        public string TextBoxValue
        {
            get { return _textBoxValue; }
            set
            {
                _textBoxValue = value;
                OnPropertyChanged();
            }
        }
        private string _textBoxValue;



        public string Zawartosc2
        {
            get { return _zawartosc2; }
            set
            {
                _zawartosc2 = value;
                OnPropertyChanged();
            }
        }
        private string _zawartosc2;

        public string TextBoxValue2
        {
            get { return _textBoxValue2; }
            set
            {
                _textBoxValue2 = value;
                OnPropertyChanged();
            }
        }
        private string _textBoxValue2;

        //tutaj

        public string ziarno1
        {
            get { return _ziarno1; }
            set
            {
                _ziarno1 = value;
                OnPropertyChanged();
            }
        }
        private string _ziarno1;

        public string wielomian1
        {
            get { return _wielomian1; }
            set
            {
                _wielomian1 = value;
                OnPropertyChanged();
            }
        }
        private string _wielomian1;

        //tutaj 2

        public string ziarno2
        {
            get { return _ziarno2; }
            set
            {
                _ziarno2 = value;
                OnPropertyChanged();
            }
        }
        private string _ziarno2;

        public string wielomian2
        {
            get { return _wielomian2; }
            set
            {
                _wielomian2 = value;
                OnPropertyChanged();
            }
        }
        private string _wielomian2;
    }
}
