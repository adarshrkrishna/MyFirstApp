using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MyFirstApp
{
    public class MyEntry : Entry
    {
        public new event EventHandler<EventArgs> Completed;

        public static readonly BindableProperty ReturnTypeProperty =
        BindableProperty.Create<MyEntry, ReturnType>(s => s.ReturnType, ReturnType.Done);

        public ReturnType ReturnType
        {
            get { return (ReturnType)GetValue(ReturnTypeProperty); }
            set { SetValue(ReturnTypeProperty, value); }
        }
        public void InvokeCompleted()
        {
            if (this.Completed != null)
                this.Completed.Invoke(this, null);
        }
    }

    public enum ReturnType
    {
        Next,
        Done
    }
}
