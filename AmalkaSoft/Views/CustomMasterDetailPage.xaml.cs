using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinKit.Views
{
    public partial class CustomMasterDetailPage : MasterDetailPage
    {
        TestPage testPage;
        public CustomMasterDetailPage()
        {
            InitializeComponent();
            testPage = new TestPage();

           var detialPage = new NavigationPage(testPage);
                detialPage.BarBackgroundColor = Color.Accent;
            Detail = detialPage;
        }

        public void ItemTapped(object sender, System.EventArgs e)
        {
            var parameter = ((TappedEventArgs)e).Parameter;

            switch (parameter)
            {
                case "Menu1":
                    DisplayAlert("Xamrin menu", "Menu1 No sub items added", "Ok");
                    break;
                case "Menu2":
                    if(menue2Sub.IsVisible)
                    {
                        menue2Sub.IsVisible = false;
                    }
                    else 
                    {
                        menue2Sub.IsVisible = true;
                    }
                    break;
                case "Menu2.1":
                    testPage.AddPageToStack();
                    break;
                case "Menu2.2":
                    testPage.RemovePageToStack();
                    break;
                case "Menu3":
                    if (menue3Sub.IsVisible)
                    {
                        menue3Sub.IsVisible = false;
                    }
                    else
                    {
                        menue3Sub.IsVisible = true;
                    }
                    break;
                case "Menu4":
                    if (menue4Sub.IsVisible)
                    {
                        menue4Sub.IsVisible = false;
                    }
                    else
                    {
                        menue4Sub.IsVisible = true;
                    }
                    break;
                default:
                    DisplayAlert("Xamrin menu","No item selected","Ok");
                    break;
            }
        }
    }
}
