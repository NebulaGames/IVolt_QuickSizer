
namespace IVolt_QuickSizer
{
    partial class IVolt_QuickSizerConfigDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IVolt_QuickSizerConfigDialog));
            this.CancelResizeEffort_Button = new System.Windows.Forms.Button();
            this.ProcessResizeCommand_Button = new System.Windows.Forms.Button();
            this.SizesCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CustomSizesTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CancelResizeEffort_Button
            // 
            this.CancelResizeEffort_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelResizeEffort_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelResizeEffort_Button.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CancelResizeEffort_Button.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelResizeEffort_Button.Location = new System.Drawing.Point(231, 300);
            this.CancelResizeEffort_Button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CancelResizeEffort_Button.Name = "CancelResizeEffort_Button";
            this.CancelResizeEffort_Button.Size = new System.Drawing.Size(124, 34);
            this.CancelResizeEffort_Button.TabIndex = 5;
            this.CancelResizeEffort_Button.Text = "Cancel";
            this.CancelResizeEffort_Button.UseVisualStyleBackColor = true;
            // 
            // ProcessResizeCommand_Button
            // 
            this.ProcessResizeCommand_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ProcessResizeCommand_Button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ProcessResizeCommand_Button.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ProcessResizeCommand_Button.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProcessResizeCommand_Button.Location = new System.Drawing.Point(384, 300);
            this.ProcessResizeCommand_Button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProcessResizeCommand_Button.Name = "ProcessResizeCommand_Button";
            this.ProcessResizeCommand_Button.Size = new System.Drawing.Size(239, 34);
            this.ProcessResizeCommand_Button.TabIndex = 4;
            this.ProcessResizeCommand_Button.Text = "OK";
            this.ProcessResizeCommand_Button.UseVisualStyleBackColor = true;
            this.ProcessResizeCommand_Button.Click += new System.EventHandler(this.ProcessResizeCommand_Button_Click);
            // 
            // SizesCheckedListBox
            // 
            this.SizesCheckedListBox.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SizesCheckedListBox.FormattingEnabled = true;
            this.SizesCheckedListBox.Items.AddRange(new object[] {
            "16",
            "32",
            "64",
            "128",
            "256",
            "512",
            "1024",
            "2048"});
            this.SizesCheckedListBox.Location = new System.Drawing.Point(117, 48);
            this.SizesCheckedListBox.Name = "SizesCheckedListBox";
            this.SizesCheckedListBox.Size = new System.Drawing.Size(195, 211);
            this.SizesCheckedListBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 35);
            this.label1.TabIndex = 8;
            this.label1.Text = "Sizes To Convert To";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(331, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Custom Sizes (One Per Line)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CustomSizesTextBox
            // 
            this.CustomSizesTextBox.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomSizesTextBox.Location = new System.Drawing.Point(331, 48);
            this.CustomSizesTextBox.Multiline = true;
            this.CustomSizesTextBox.Name = "CustomSizesTextBox";
            this.CustomSizesTextBox.Size = new System.Drawing.Size(292, 211);
            this.CustomSizesTextBox.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(231, 265);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(530, 26);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "###FILENAME###_###NEWSIZE###.###EXT###";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 26);
            this.label3.TabIndex = 12;
            this.label3.Text = "Output File Pattern";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // IVolt_QuickSizerConfigDialog
            // 
            this.AcceptButton = this.ProcessResizeCommand_Button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.CancelButton = this.CancelResizeEffort_Button;
            this.ClientSize = new System.Drawing.Size(774, 347);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CustomSizesTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SizesCheckedListBox);
            this.Controls.Add(this.ProcessResizeCommand_Button);
            this.Controls.Add(this.CancelResizeEffort_Button);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.Name = "IVolt_QuickSizerConfigDialog";
            this.Text = "Quick ReSizer";
            this.UseAppThemeColors = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ProcessResizeCommand_Button;
        private System.Windows.Forms.Button CancelResizeEffort_Button;
        private System.Windows.Forms.CheckedListBox SizesCheckedListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CustomSizesTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
    }
}