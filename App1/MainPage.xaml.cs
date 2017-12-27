using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Markup;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }
    }
    
    public class CustomList : ObservableCollection<string>, ICollection
    {
        public CustomList()
        {
        }

        public CustomList(IEnumerable<string> collection) : base(collection)
        {
        }

        public object InitializeWith
        {
            get { return this.ToList(); }
            set
            {
                if (value is IEnumerable<string> v)
                {
                    this.Clear();
                    foreach (var item in v)
                    {
                        Add(item);
                    }
                }
                else if (value is string s)
                {
                    this.Clear();
                    Add(s);
                }

            }
        }
    }
}
