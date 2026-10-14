namespace _4._8
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            statusStrip = new StatusStrip();
            progressStatusLabel = new ToolStripStatusLabel();
            statusStrip.SuspendLayout();
            statusStrip.Items.AddRange(new ToolStripItem[] { progressStatusLabel });
            statusStrip.Dock = DockStyle.Bottom;
            progressStatusLabel.Text = "Sẵn sàng";
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 650);
            Controls.Add(statusStrip);
            IsMdiContainer = true;
            MainMenuStrip = null;
            Text = "Bài 4.8 - Async/Await và ProgressBar";
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
        }

        private StatusStrip statusStrip;
        private ToolStripStatusLabel progressStatusLabel;

        #endregion
    }
}
