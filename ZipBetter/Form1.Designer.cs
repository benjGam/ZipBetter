namespace ZipBetter
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
            SelectFolderButton = new Button();
            SuspendLayout();
            // 
            // SelectFolderButton
            // 
            SelectFolderButton.Location = new Point(145, 349);
            SelectFolderButton.Margin = new Padding(4, 4, 4, 4);
            SelectFolderButton.Name = "SelectFolderButton";
            SelectFolderButton.Size = new Size(161, 32);
            SelectFolderButton.TabIndex = 0;
            SelectFolderButton.Text = "Select folder to Zip";
            SelectFolderButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(461, 394);
            Controls.Add(SelectFolderButton);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button SelectFolderButton;
    }
}
