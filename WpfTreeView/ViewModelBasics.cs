using System.ComponentModel;
using System.Threading.Tasks;

namespace WpfTreeView
{
    public class ViewModelBasics : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = (sender, e) => { };

        public string Test { get; set; } = "My property";
        
        public ViewModelBasics()
        {
            Task.Run(async () =>
            {
                int i = 0;

                while (true)
                {
                    await Task.Delay(1000);
                    Test = i++.ToString();
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(Test)));
                }
            });
        }
        public override string ToString()
        {
            return "Hello";
        }
    }
}