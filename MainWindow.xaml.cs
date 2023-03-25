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
using System.Windows.Shapes;

namespace EditableFlowDocument
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public FlowDocument Flow { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            Flow = new FlowDocument();
            fdViewer.Document = Flow;
        }

        private void Btn_CheckBox_Click(object sender, RoutedEventArgs e)
        {
            BlockUIContainer blockUI = new BlockUIContainer();
            TextBox textBox = new TextBox();
            //textBox.Text = "Item 1";
            CheckBox checkBox = new CheckBox();
            checkBox.Content = textBox;
            blockUI.Child = checkBox;
            Flow.Blocks.Add(blockUI);

            fdViewer.Document = Flow;
        }

        private void Btn_Text_Click(object sender, RoutedEventArgs e)
        {
            BlockUIContainer blockUI = new BlockUIContainer();
            RichTextBox textBox = new RichTextBox();
            blockUI.Child = textBox;
            Flow.Blocks.Add(blockUI);
        }

        private void Btn_CheckBox_Click_old(object sender, RoutedEventArgs e)
        {

            Paragraph p = new Paragraph(new Run(""));
           //p.FontSize = 36;
            Flow.Blocks.Add(p);

            //p = new Paragraph(new Run("The ultimate programming greeting!"));
            //p = new Paragraph(new Run(""));
            //p.FontSize = 14;
            //p.FontStyle = FontStyles.Italic;
            //p.TextAlignment = TextAlignment.Left;
            //p.Foreground = Brushes.Gray;
            //Flow.Blocks.Add(p);
            BlockUIContainer blockUI = new BlockUIContainer();
            TextBox textBox = new TextBox();
            //textBox.Text = "Item 1";
            CheckBox checkBox = new CheckBox();
            checkBox.Content = textBox;
            blockUI.Child = checkBox;
            Flow.Blocks.Add(blockUI);

            fdViewer.Document = Flow;
        }
    }
}
