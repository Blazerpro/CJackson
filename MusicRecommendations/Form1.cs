namespace MusicRecommendations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ArtistOrTrackBox.SelectedIndex = 0;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var item = CreateItem(TitleBox.Text, ArtistBox.Text, (string)ArtistOrTrackBox.SelectedItem);
            ListTLP.RowStyles.Insert(ListTLP.RowCount-1, new RowStyle(SizeType.AutoSize));
            ListTLP.RowCount++;
            ListTLP.Controls.Add(item,0,ListTLP.RowCount-1);
        }

        private Control CreateItem(string title, string artist, string albumTrack)
        {
            var panel = new TableLayoutPanel();
            panel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            panel.RowCount++;
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            panel.ColumnCount=4;
            panel.Dock = DockStyle.Fill;
            var titleText = new Label
            {
                Text = title,
                Anchor = AnchorStyles.Left|AnchorStyles.Right
            };
            var artistText = new Label 
            { 
                Text = artist,
                Anchor = AnchorStyles.Left | AnchorStyles.Right
            };
            var albumTrackMarker = new Label
            {
                Text = albumTrack,
                Anchor = AnchorStyles.Left | AnchorStyles.Right
            };
            panel.Controls.Add(titleText, 0, 0);
            panel.Controls.Add(artistText, 1, 0);
            panel.Controls.Add(albumTrackMarker, 2, 0);
            return panel;
            // TODO: Create a proper row item, using TableLayoutPanel with actual columns etc.
        }

    }
}