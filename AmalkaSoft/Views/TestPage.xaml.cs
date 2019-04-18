using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamarinKit.Views.DynamicViews;

namespace XamarinKit.Views
{
    public partial class TestPage : ContentPage
    {
        public TestPage()
        {
            InitializeComponent();

        }



        public void AddPageToStack()
        {
            RemoveChildViews();
       
            view.Children.Add(new DynamicView1());
        }

        public void RemovePageToStack()
        {
            RemoveChildViews();
            view.Children.Add(new DynamicView2());
        }

        public void RemoveChildViews()
        {
            view.Children.Clear();
        }
    }

}
