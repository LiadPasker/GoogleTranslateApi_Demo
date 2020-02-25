namespace FormTranslate
{
	partial class Form1
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
			this.inputTichTextBox = new System.Windows.Forms.RichTextBox();
			this.translationTextBox = new System.Windows.Forms.TextBox();
			this.comboBoxTranslateFrom = new System.Windows.Forms.ComboBox();
			this.comboBoxTranslateTo = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// inputTichTextBox
			// 
			this.inputTichTextBox.ForeColor = System.Drawing.SystemColors.MenuText;
			this.inputTichTextBox.Location = new System.Drawing.Point(112, 31);
			this.inputTichTextBox.Name = "inputTichTextBox";
			this.inputTichTextBox.Size = new System.Drawing.Size(278, 220);
			this.inputTichTextBox.TabIndex = 0;
			this.inputTichTextBox.Tag = "inputTichTextBox";
			this.inputTichTextBox.Text = "";
			this.inputTichTextBox.SelectionChanged += new System.EventHandler(this.inputTichTextBox_SelectionChanged);
			this.inputTichTextBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.inputTichTextBox_MouseDown);
			// 
			// translationTextBox
			// 
			this.translationTextBox.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
			this.translationTextBox.Location = new System.Drawing.Point(112, 336);
			this.translationTextBox.Multiline = true;
			this.translationTextBox.Name = "translationTextBox";
			this.translationTextBox.Size = new System.Drawing.Size(278, 74);
			this.translationTextBox.TabIndex = 2;
			this.translationTextBox.Tag = "Translate:";
			this.translationTextBox.Text = "Translate:";
			// 
			// comboBoxTranslateFrom
			// 
			this.comboBoxTranslateFrom.FormattingEnabled = true;
			this.comboBoxTranslateFrom.Location = new System.Drawing.Point(112, 280);
			this.comboBoxTranslateFrom.Name = "comboBoxTranslateFrom";
			this.comboBoxTranslateFrom.Size = new System.Drawing.Size(135, 24);
			this.comboBoxTranslateFrom.TabIndex = 3;
			this.comboBoxTranslateFrom.Tag = "Language From:";
			this.comboBoxTranslateFrom.Text = "Language From:";
			this.comboBoxTranslateFrom.SelectedIndexChanged += new System.EventHandler(this.comboBoxTranslatoFrom_SelectedIndexChanged);
			// 
			// comboBoxTranslateTo
			// 
			this.comboBoxTranslateTo.FormattingEnabled = true;
			this.comboBoxTranslateTo.Location = new System.Drawing.Point(264, 280);
			this.comboBoxTranslateTo.Name = "comboBoxTranslateTo";
			this.comboBoxTranslateTo.Size = new System.Drawing.Size(126, 24);
			this.comboBoxTranslateTo.TabIndex = 4;
			this.comboBoxTranslateTo.Tag = "Language To:";
			this.comboBoxTranslateTo.Text = "Language To:";
			this.comboBoxTranslateTo.SelectedIndexChanged += new System.EventHandler(this.comboBoxTranslateTo_SelectedIndexChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(483, 450);
			this.Controls.Add(this.comboBoxTranslateTo);
			this.Controls.Add(this.comboBoxTranslateFrom);
			this.Controls.Add(this.translationTextBox);
			this.Controls.Add(this.inputTichTextBox);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RichTextBox inputTichTextBox;
		private System.Windows.Forms.TextBox translationTextBox;
		private System.Windows.Forms.ComboBox comboBoxTranslateFrom;
		private System.Windows.Forms.ComboBox comboBoxTranslateTo;
	}
}

