/*
 * Created by SharpDevelop.
 * User: Marc ENGEL
 * Date: 21/07/2023
 * Time: 13:50
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Windows.Forms;

namespace LLAnonymizer
{
	public class ListableTextBox : System.Windows.Forms.TextBox
	{
		public int index;
	}
	
    public partial class LLAnonymizerForm : Form
    {
		private const int NB_REPLACE = 8;
    	private ListableTextBox[] txtSearch = new ListableTextBox[NB_REPLACE];
    	private ListableTextBox[] txtReplace = new	ListableTextBox[NB_REPLACE];
    	private bool bFoundDuplicate;

        public LLAnonymizerForm()
        {
            InitializeComponent();
			this.SuspendLayout();

			// Dynamically create the search/repair pairs. If needed, it will be easy to add some new
            for (int iSearchText = 0; iSearchText < NB_REPLACE; iSearchText++)
            {
				this.txtSearch[iSearchText] = new ListableTextBox();
				this.txtReplace[iSearchText] = new ListableTextBox();

				// txtSearch
				// 
				this.txtSearch[iSearchText].Location = new System.Drawing.Point(18, 188+(214-188)*iSearchText);
				this.txtSearch[iSearchText].Name = "txtSearch";
				this.txtSearch[iSearchText].Size = new System.Drawing.Size(195, 20);
				this.txtSearch[iSearchText].TabIndex = iSearchText*2;
				this.txtSearch[iSearchText].index = iSearchText;
				this.txtSearch[iSearchText].TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
				this.txtSearch[iSearchText].Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
				// 
				// txtReplace
				// 
				this.txtReplace[iSearchText].Location = new System.Drawing.Point(257, 188+(214-188)*iSearchText);
				this.txtReplace[iSearchText].Name = "txtReplace";
				this.txtReplace[iSearchText].Size = new System.Drawing.Size(195, 20);
				this.txtSearch[iSearchText].index = iSearchText;
				this.txtReplace[iSearchText].TabIndex = iSearchText*2+1;
				this.txtReplace[iSearchText].TextChanged += new System.EventHandler(this.txtReplace_TextChanged);
				this.txtReplace[iSearchText].Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));

				this.Controls.Add(this.txtReplace[iSearchText]);
				this.Controls.Add(this.txtSearch[iSearchText]);
            }


			this.ResumeLayout(false);
			this.PerformLayout();
        }

        private void VerifyDuplicateBeforeReplace()
        {
			this.SuspendLayout();

			int cursor = textEditionBox.SelectionStart;
        	// Reset the color to black for all text in the text box
            textEditionBox.SelectAll();
            textEditionBox.SelectionColor = Color.Black;

            bFoundDuplicate = false;
            
            // Check for existing replacement text and set color to red
            for (int iSearchText = 0; iSearchText < NB_REPLACE; iSearchText++)
            {
            	string replacementText = txtReplace[iSearchText].Text;

            	int index = 0;
                while (index < textEditionBox.TextLength)
                {
                    int startIndex = textEditionBox.Find(replacementText, index, RichTextBoxFinds.MatchCase|RichTextBoxFinds.WholeWord);
                    if (startIndex == -1)
                        break;

					bFoundDuplicate = true;
					
                    textEditionBox.Select(startIndex, replacementText.Length);
                    textEditionBox.SelectionColor = Color.Red;

                    index = startIndex + replacementText.Length;
                }
            }
            textEditionBox.DeselectAll();

			btnReplace.Enabled = !bFoundDuplicate;
			
        	textEditionBox.SelectionStart = cursor ;
        	
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        private void BtnReplace_Click(object sender, EventArgs e)
        {
            for (int iSearchText = 0; iSearchText < NB_REPLACE; iSearchText++)
            {
	            if (string.IsNullOrWhiteSpace(txtSearch[iSearchText].Text) || string.IsNullOrWhiteSpace(txtReplace[iSearchText].Text))
	                return;
	
	            string searchText = txtSearch[iSearchText].Text;
	            string replacementText = txtReplace[iSearchText].Text;
	
	            // Perform replacement in the text box
	            if(searchText.Length != 0 && replacementText.Length != 0)
	            	textEditionBox.Text = textEditionBox.Text.Replace(searchText.Trim(), replacementText.Trim());
            }
        }

        private void BtnInvert_Click(object sender, EventArgs e)
        {
            string temp;

            for (int iSearchText = 0; iSearchText < NB_REPLACE; iSearchText++)
            {
	            // Swap the search and replace texts
				temp = txtSearch[iSearchText].Text;
	            txtSearch[iSearchText].Text = txtReplace[iSearchText].Text;
	            txtReplace[iSearchText].Text = temp;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
        	ListableTextBox realSender = (ListableTextBox)sender;
        	
           	// Automatically propose the replacement text
            if (!string.IsNullOrWhiteSpace(txtSearch[realSender.index].Text))
            {
                if (string.IsNullOrWhiteSpace(txtReplace[realSender.index].Text))
	            {
					string proposedReplacement = new string(txtSearch[realSender.index].Text[0], 1).ToUpper()+ new string(((char)(realSender.index + 65)).ToString().ToUpper()[0],5);
	                txtReplace[realSender.index].Text = proposedReplacement;
	            }
            }
            else
            {
                txtReplace[realSender.index].Text = string.Empty;
            }
        }

        private void txtReplace_TextChanged(object sender, EventArgs e)
        {
        	VerifyDuplicateBeforeReplace();
        }

        void TextEditionBoxTextChanged(object sender, System.EventArgs e)
		{
			VerifyDuplicateBeforeReplace();
		}

    }
}

