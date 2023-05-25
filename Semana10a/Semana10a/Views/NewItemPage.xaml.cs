using System;
using System.Collections.Generic;
using System.ComponentModel;
using Semana10a.Models;
using Semana10a.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Semana10a.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}