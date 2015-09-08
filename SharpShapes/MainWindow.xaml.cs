using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
//using System.Windows.Shapes;
using Shapes;
using System.Reflection;

namespace SharpShapes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SetComboBoxItems();
        }

        private void SetComboBoxItems()
        {
            List<string> stuff = new List<string>();
            var quadType = typeof(AQuadrilateral);
            // looks at the current assembly, get all the types that inherit from Quadrilateral, populates dropdown
            combo1.ItemsSource = Assembly.GetAssembly(typeof(Shapes.AShape)).GetTypes().Where(shapeType => shapeType.IsSubclassOf(typeof(AQuadrilateral)));
        }

        public int NumberOfArguments(string className)
        {
            // determines the number of arguments in the first constructor of Rectangle and Square
            var theClass = Assembly.GetAssembly(typeof(Shapes.AShape)).GetTypes().Where(shapeType => shapeType.Name == className).First(); // This is a Collection. Get the First
            var theClassConstructor = theClass.GetConstructors().First();
            return theClassConstructor.GetParameters().Length;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // placeholder code to demonstrate when a button is clicked
            MessageBox.Show("Button Clicked!");
        }

        private void combo1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // enables or disables a text input box based on number of arguments in the shape constructor
            var classType = combo1.SelectedValue as Type;
            shapeWidth.IsEnabled = true;
            int argCount = NumberOfArguments(classType.Name);
            shapeHeight.IsEnabled = (argCount > 1);
        }
        
    }
}
