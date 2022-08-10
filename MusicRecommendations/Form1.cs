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
            var item = CreateItem(TitleBox.Text, ArtistBox.Text, (string)ArtistOrTrackBox.SelectedItem, ListTLP);
            ListTLP.RowStyles.Insert(ListTLP.RowCount - 1, new RowStyle(SizeType.AutoSize));
            ListTLP.RowCount++;
            ListTLP.Controls.Add(item, 0, ListTLP.RowCount - 1);
        }

        private static Control CreateItem(string title, string artist, string albumTrack, TableLayoutPanel tlp)
        {
            var panel = new TableLayoutPanel();
            panel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            panel.RowCount = panel.RowStyles.Count;
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60));
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40));
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100));
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60));
            panel.ColumnCount = panel.ColumnStyles.Count;
            panel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            var titleText = new Label
            {
                Text = title,
                Anchor = AnchorStyles.Left | AnchorStyles.Right
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
            var removeButton = new Button
            {
                Text = "X",
                Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom
            };

            panel.Controls.Add(titleText, 0, 0);
            panel.Controls.Add(artistText, 1, 0);
            panel.Controls.Add(albumTrackMarker, 2, 0);
            panel.Controls.Add(removeButton, 3, 0);

            removeButton.Click += (object? _, EventArgs _) =>
            {
                var index = tlp.GetRow(panel);

                tlp.Controls.Remove(panel);
                tlp.RowStyles.RemoveAt(index);
                tlp.RowCount--;

                // try to shift things up one if they are after the removed control
                tlp.Controls.Cast<Control>().ToList().ForEach((ctrl) =>
                {
                    var row = tlp.GetRow(ctrl);
                    if (row > index)
                    {
                        tlp.SetRow(ctrl, row - 1);
                    }
                });
            };


            return panel;
            // TODO: Create a proper row item, using TableLayoutPanel with actual columns etc.
        }

    }
}