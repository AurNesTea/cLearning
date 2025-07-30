using System;
using System.Windows.Forms;

namespace reader.Forms
{
    public partial class MainForm : Form
    {
        private Button openFileButton;
        private RichTextBox contentBox;

        public MainForm()
        {
            this.Text = "Novel Reader";
            this.Width = 800;
            this.Height = 600;

            openFileButton = new Button
            {
                Text = "開啟小說",
                Top = 10,
                Left = 10,
                Width = 100
            };

            // ⛳ 修正 1：事件名稱要大寫 Click（非 click）
            openFileButton.Click += OpenFileButton_Click;

            contentBox = new RichTextBox
            {
                Top = 50,
                Left = 10,
                Width = 760,
                Height = 500,
                Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right
            };

            this.Controls.Add(openFileButton);
            this.Controls.Add(contentBox);
        }

        // ⛳ 修正 2：OpenFileDialog 的屬性是 FileName，不是 Filename
        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                contentBox.Text = System.IO.File.ReadAllText(dialog.FileName);
            }
        }
    }
}
