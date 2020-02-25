using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using LogicTranslator;

namespace FormTranslate
{
	public partial class Form1 : Form
	{	
		translateLogic m_tranlation;
		string m_Text=null;
		string m_From=null;
		string m_To=null;

		public Form1()
		{
			m_tranlation = new translateLogic();
			InitializeComponent();
		}


		private void inputTichTextBox_SelectionChanged(object sender, EventArgs e)
		{
			if (inputTichTextBox.SelectedText.Length > 0)
			{
				m_Text = inputTichTextBox.SelectedText.ToString();
			}
		}

		private void inputTichTextBox_MouseDown(object sender, MouseEventArgs e)
		{
			try
			{
				if (e.Button == MouseButtons.Right)
				{
					string text = m_tranlation.TranslateText(m_Text, m_From, m_To);
					if (text != null)
					{
						translationTextBox.Text = translationTextBox.Tag.ToString();
						translationTextBox.Text += text;
					}
					else
						translationTextBox.Text = translationTextBox.Tag.ToString();
				}
			}
			catch
			{
				Console.WriteLine("error");
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			foreach (string str in m_tranlation.GetLanguage())
			{
				comboBoxTranslateFrom.Items.Add(str);
				comboBoxTranslateTo.Items.Add(str);
			}
			comboBoxTranslateFrom.Text = comboBoxTranslateFrom.Tag.ToString();
			comboBoxTranslateTo.Text = comboBoxTranslateTo.Tag.ToString();
		}

		private void comboBoxTranslatoFrom_SelectedIndexChanged(object sender, EventArgs e)
		{
			m_From = comboBoxTranslateFrom.SelectedItem.ToString().Substring(0, 2);
		}

		private void comboBoxTranslateTo_SelectedIndexChanged(object sender, EventArgs e)
		{
			m_To = comboBoxTranslateTo.SelectedItem.ToString().Substring(0, 2);
		}

		
	}
}
