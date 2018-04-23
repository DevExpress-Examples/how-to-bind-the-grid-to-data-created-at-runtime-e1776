using System.Windows.Controls;

namespace AgDataGrid_BindRuntimeData {
    public partial class MainPage : UserControl {
        public MainPage() {
            InitializeComponent();
            grid.DataSource = ProductList.GetData();
        }
    }
}
