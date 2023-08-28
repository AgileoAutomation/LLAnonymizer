/*
 * Created by SharpDevelop.
 * User: Marc ENGEL
 * Date: 21/07/2023
 * Time: 13:50
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace LLAnonymizer
{
	partial class LLAnonymizerForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LLAnonymizerForm));
			this.textEditionBox = new System.Windows.Forms.RichTextBox();
			this.btnReplace = new System.Windows.Forms.Button();
			this.btnInvert = new System.Windows.Forms.Button();
			this.lblTextToFind = new System.Windows.Forms.Label();
			this.lbTextToReplace = new System.Windows.Forms.Label();
			this.lblTextToAnonymize = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// textEditionBox
			// 
			this.textEditionBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.textEditionBox.Location = new System.Drawing.Point(13, 31);
			this.textEditionBox.Name = "textEditionBox";
			this.textEditionBox.Size = new System.Drawing.Size(913, 126);
			this.textEditionBox.TabIndex = 0;
			this.textEditionBox.Text = "";
			this.textEditionBox.TextChanged += new System.EventHandler(this.TextEditionBoxTextChanged);
			// 
			// btnReplace
			// 
			this.btnReplace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnReplace.Location = new System.Drawing.Point(190, 400);
			this.btnReplace.Name = "btnReplace";
			this.btnReplace.Size = new System.Drawing.Size(75, 23);
			this.btnReplace.TabIndex = 17;
			this.btnReplace.Text = "Replace";
			this.btnReplace.UseVisualStyleBackColor = true;
			this.btnReplace.Click += new System.EventHandler(this.BtnReplace_Click);
			// 
			// btnInvert
			// 
			this.btnInvert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnInvert.Location = new System.Drawing.Point(190, 430);
			this.btnInvert.Name = "btnInvert";
			this.btnInvert.Size = new System.Drawing.Size(75, 23);
			this.btnInvert.TabIndex = 18;
			this.btnInvert.Text = "<- Invert ->";
			this.btnInvert.UseVisualStyleBackColor = true;
			this.btnInvert.Click += new System.EventHandler(this.BtnInvert_Click);
			// 
			// lblTextToFind
			// 
			this.lblTextToFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblTextToFind.Location = new System.Drawing.Point(30, 167);
			this.lblTextToFind.Name = "lblTextToFind";
			this.lblTextToFind.Size = new System.Drawing.Size(200, 20);
			this.lblTextToFind.TabIndex = 19;
			this.lblTextToFind.Text = "Text to find";
			this.lblTextToFind.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// lbTextToReplace
			// 
			this.lbTextToReplace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lbTextToReplace.Location = new System.Drawing.Point(270, 167);
			this.lbTextToReplace.Name = "lbTextToReplace";
			this.lbTextToReplace.Size = new System.Drawing.Size(200, 20);
			this.lbTextToReplace.TabIndex = 20;
			this.lbTextToReplace.Text = "Text to replace with";
			this.lbTextToReplace.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// lblTextToAnonymize
			// 
			this.lblTextToAnonymize.Location = new System.Drawing.Point(12, 9);
			this.lblTextToAnonymize.Name = "lblTextToAnonymize";
			this.lblTextToAnonymize.Size = new System.Drawing.Size(200, 20);
			this.lblTextToAnonymize.TabIndex = 21;
			this.lblTextToAnonymize.Text = "Copy the text to anonymize below";
			// 
			// LLAnonymizerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(938, 463);
			this.Controls.Add(this.lblTextToAnonymize);
			this.Controls.Add(this.lbTextToReplace);
			this.Controls.Add(this.lblTextToFind);
			this.Controls.Add(this.btnInvert);
			this.Controls.Add(this.btnReplace);
			this.Controls.Add(this.textEditionBox);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(500, 450);
			this.Name = "LLAnonymizerForm";
			this.Text = "LLAnonymizer";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label lblTextToAnonymize;
		private System.Windows.Forms.Label lbTextToReplace;
		private System.Windows.Forms.Label lblTextToFind;
		private System.Windows.Forms.Button btnInvert;
		private System.Windows.Forms.Button btnReplace;
		private System.Windows.Forms.RichTextBox textEditionBox;
		

	}
}
