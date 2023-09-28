using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;


namespace WpfApp_XamDataCards_AutoFitCards
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<TestData> testData = null;
        public MainWindow()
        {
            InitializeComponent();

            testData = new ObservableCollection<TestData>();

            testData.Add(new TestData { Id = 1, Test1 = 1, Test2 = "Line1" + Environment.NewLine + "Line2" });
            testData.Add(new TestData { Id = 2, Test1 = 34.555, Test2 = "あいうえお　かきくけこ　さしすせそ" });
            testData.Add(new TestData { Id = 3, Test1 = 56, Test2 = "Doe" });
            testData.Add(new TestData { Id = 4, Test1 = 23, Test2 = "uaweb aweufbh awefh" + Environment.NewLine + "bwuaefbuwa waefbwuaef" });

            this.DataContext = testData;
        }
    }

    public class TestData : INotifyPropertyChanged
    {
        private int m_id;
        public int Id
        {
            get { return m_id; }
            set
            {
                m_id = value;
                NotifyPropertyChanged("Id");
            }
        }

        private double m_test1;
        public double Test1
        {
            get { return m_test1; }
            set
            {
                m_test1 = value;
                NotifyPropertyChanged("Test1");
            }
        }

        private String m_test2;
        public String Test2
        {
            get { return m_test2; }
            set
            {
                m_test2 = value;
                NotifyPropertyChanged("Test2");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
    }
}
