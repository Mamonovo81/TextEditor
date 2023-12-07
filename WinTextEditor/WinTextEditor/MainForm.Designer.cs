/*
 * Created by SharpDevelop.
 * User: user
 * Date: 07.12.2023
 * Time: 17:27
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace WinTextEditor
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.textOutput = new System.Windows.Forms.TextBox();
			this.panelControl = new System.Windows.Forms.Panel();
			this.buttonSaveAs = new System.Windows.Forms.Button();
			this.buttonSave = new System.Windows.Forms.Button();
			this.buttonOpen = new System.Windows.Forms.Button();
			this.panelClose = new System.Windows.Forms.Panel();
			this.buttonClose = new System.Windows.Forms.Button();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.panelControl.SuspendLayout();
			this.panelClose.SuspendLayout();
			this.SuspendLayout();
			// 
			// textOutput
			// 
			this.textOutput.Location = new System.Drawing.Point(29, 12);
			this.textOutput.Multiline = true;
			this.textOutput.Name = "textOutput";
			this.textOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textOutput.Size = new System.Drawing.Size(537, 249);
			this.textOutput.TabIndex = 0;
			// 
			// panelControl
			// 
			this.panelControl.Controls.Add(this.buttonSaveAs);
			this.panelControl.Controls.Add(this.buttonSave);
			this.panelControl.Controls.Add(this.buttonOpen);
			this.panelControl.Location = new System.Drawing.Point(6, 291);
			this.panelControl.Name = "panelControl";
			this.panelControl.Size = new System.Drawing.Size(423, 74);
			this.panelControl.TabIndex = 1;
			// 
			// buttonSaveAs
			// 
			this.buttonSaveAs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonSaveAs.Location = new System.Drawing.Point(265, 14);
			this.buttonSaveAs.Name = "buttonSaveAs";
			this.buttonSaveAs.Size = new System.Drawing.Size(140, 46);
			this.buttonSaveAs.TabIndex = 2;
			this.buttonSaveAs.Text = "Сохранить как";
			this.buttonSaveAs.UseVisualStyleBackColor = true;
			// 
			// buttonSave
			// 
			this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonSave.ForeColor = System.Drawing.Color.CornflowerBlue;
			this.buttonSave.Location = new System.Drawing.Point(136, 14);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(111, 47);
			this.buttonSave.TabIndex = 1;
			this.buttonSave.Text = "Сохранить";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.ButtonSaveClick);
			// 
			// buttonOpen
			// 
			this.buttonOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonOpen.ForeColor = System.Drawing.Color.Crimson;
			this.buttonOpen.Location = new System.Drawing.Point(22, 14);
			this.buttonOpen.Name = "buttonOpen";
			this.buttonOpen.Size = new System.Drawing.Size(108, 48);
			this.buttonOpen.TabIndex = 0;
			this.buttonOpen.Text = "Открыть";
			this.buttonOpen.UseVisualStyleBackColor = true;
			this.buttonOpen.Click += new System.EventHandler(this.ButtonOpenClick);
			// 
			// panelClose
			// 
			this.panelClose.Controls.Add(this.buttonClose);
			this.panelClose.Location = new System.Drawing.Point(442, 291);
			this.panelClose.Name = "panelClose";
			this.panelClose.Size = new System.Drawing.Size(123, 73);
			this.panelClose.TabIndex = 2;
			// 
			// buttonClose
			// 
			this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonClose.ForeColor = System.Drawing.Color.DarkBlue;
			this.buttonClose.Location = new System.Drawing.Point(3, 14);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new System.Drawing.Size(117, 45);
			this.buttonClose.TabIndex = 0;
			this.buttonClose.Text = "Закрыть";
			this.buttonClose.UseVisualStyleBackColor = true;
			this.buttonClose.Click += new System.EventHandler(this.ButtonCloseClick);
			// 
			// openFileDialog
			// 
			this.openFileDialog.FileName = "openFileDialog1";
			this.openFileDialog.Filter = "TXT files|*.txt";
			this.openFileDialog.Title = "Открыть файл";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(578, 378);
			this.Controls.Add(this.panelClose);
			this.Controls.Add(this.panelControl);
			this.Controls.Add(this.textOutput);
			this.Name = "MainForm";
			this.Text = "Мой текстовый редактор";
			this.panelControl.ResumeLayout(false);
			this.panelClose.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.Button buttonClose;
		private System.Windows.Forms.Panel panelClose;
		private System.Windows.Forms.Button buttonOpen;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.Button buttonSaveAs;
		private System.Windows.Forms.Panel panelControl;
		private System.Windows.Forms.TextBox textOutput;
	}
}
