using System.ComponentModel;
using System.Threading.Tasks;

namespace WpfTreeView
{
    public class ViewModelBasics : INotifyPropertyChanged
    {
        private string mTest;

        public event PropertyChangedEventHandler PropertyChanged = (sender, e) => { };

        public string Test
        {
            get
            {
                return mTest;
            }

            set
            {
                if (mTest == value)
                    return;

                mTest = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(Test)));
            }
        }

        public ViewModelBasics()
        {
            Task.Run(async () =>
            {
                int i = 0;

                while (true)
                {
                    await Task.Delay(200);
                    Test = i++.ToString();
                }
            });
        }
        public override string ToString()
        {
            return "Hello";
        }
    }
}