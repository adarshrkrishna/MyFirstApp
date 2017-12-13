using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using Android.Views.InputMethods;
using MyFirstApp.Droid;
using MyFirstApp;

[assembly: ExportRenderer(typeof(MyEntry), typeof(MyEntryRenderer))]
namespace MyFirstApp.Droid
{
    class MyEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            var my_entry = Element as MyEntry;

            if (Control != null && my_entry != null)
            {

                SetReturnType(my_entry);

                // Editor Action is called when the return button is pressed
                Control.EditorAction += (object sender, TextView.EditorActionEventArgs args) =>
                {
                    if (my_entry?.ReturnType != ReturnType.Next)
                        my_entry?.Unfocus();

                    // Call all the methods attached to base_entry event handler Completed
                    my_entry?.InvokeCompleted();
                };
            }
        }

        void SetReturnType(MyEntry entry)
        {
            var type = entry.ReturnType;

            switch (type)
            {
                case ReturnType.Next:
                    Control.ImeOptions = ImeAction.Next;
                    Control.SetImeActionLabel("Next", ImeAction.Next);
                    break;
                default:
                    Control.ImeOptions = ImeAction.Done;
                    Control.SetImeActionLabel("Done", ImeAction.Done);
                    break;
            }
        }
    }
}