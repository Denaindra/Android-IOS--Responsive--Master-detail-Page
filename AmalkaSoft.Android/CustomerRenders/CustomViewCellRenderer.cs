﻿using System;
using System.ComponentModel;
using Android.Content;
using Android.Graphics.Drawables;
using Android.Views;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XamarinKit;
using XamarinKit.Droid.CustomerRenders;

[assembly: ExportRenderer(typeof(CustomViewCell), typeof(CustomViewCellRenderer))]
namespace XamarinKit.Droid.CustomerRenders
{
    public class CustomViewCellRenderer: ViewCellRenderer
    {

            private Android.Views.View _cellCore;
            private Drawable _unselectedBackground;
            private bool _selected;


        protected override Android.Views.View GetCellCore(Cell item, Android.Views.View convertView, ViewGroup parent, Context context)
        {
            _cellCore = base.GetCellCore(item, convertView, parent, context);
            _selected = false;
            _unselectedBackground = _cellCore.Background;
            
            return _cellCore;
        }

        protected override void OnCellPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnCellPropertyChanged(sender, e);
            if (e.PropertyName == "IsSelected")
            {
                _selected = !_selected;
                if (_selected)
                {
                    var extendedViewCell = sender as CustomViewCell;
                    _cellCore.SetBackgroundColor(Android.Graphics.Color.Brown);
                }
                else
                {
                    _cellCore.SetBackgroundColor(Android.Graphics.Color.Brown);
                }
            }
        }

       
    }
}
