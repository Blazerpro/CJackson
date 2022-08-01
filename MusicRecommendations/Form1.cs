namespace MusicRecommendations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AristOrTrackBox.SelectedIndex = 0;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var item = CreateItem();
            ListTLP.RowStyles.Insert(ListTLP.RowCount-1, new RowStyle(SizeType.AutoSize));
            ListTLP.RowCount++;
            ListTLP.Controls.Add(item,0,ListTLP.RowCount-1);
        }

        private Control CreateItem()
        {
            var item = new Label();
            item.Text = TitleBox.Text;
            return item;
            // TODO: Create a proper row item, using TableLayoutPanel with actual columns etc.
        }

    }
}