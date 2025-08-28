using NMF.Models;
using NMF.Models.Meta;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace AvaloniaApplication1.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
        public string Greeting { get; } = "Welcome to Avalonia!";

        public IModelElement Root { get; } = CreateRoot();

        public object SomeObject { get; } = new Test();

        private static IModelElement CreateRoot()
        {
            var root = new Namespace();
            var model = new Model();
            model.RootElements.Add(root);
            return root;
        }
    }

    public class Test
    {
        public string Foo { get; set; }

        public int Bar { get; set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IList<string> Items { get; } = new List<string>();
    }
}
