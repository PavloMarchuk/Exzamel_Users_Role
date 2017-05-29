namespace Exzamel_Users_Role
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
			if(disposing && (components != null))
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
			this.DGV1 = new System.Windows.Forms.DataGridView();
			this.clbRoles = new System.Windows.Forms.CheckedListBox();
			((System.ComponentModel.ISupportInitialize)(this.DGV1)).BeginInit();
			this.SuspendLayout();
			// 
			// DGV1
			// 
			this.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DGV1.Location = new System.Drawing.Point(13, 13);
			this.DGV1.Name = "DGV1";
			this.DGV1.Size = new System.Drawing.Size(627, 309);
			this.DGV1.TabIndex = 0;
			// 
			// clbRoles
			// 
			this.clbRoles.FormattingEnabled = true;
			this.clbRoles.Location = new System.Drawing.Point(661, 13);
			this.clbRoles.Name = "clbRoles";
			this.clbRoles.Size = new System.Drawing.Size(372, 424);
			this.clbRoles.TabIndex = 1;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1208, 458);
			this.Controls.Add(this.clbRoles);
			this.Controls.Add(this.DGV1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.DGV1)).EndInit();
			this.ResumeLayout(false);

			}

		#endregion

		private System.Windows.Forms.DataGridView DGV1;
		private System.Windows.Forms.CheckedListBox clbRoles;
		}
	}

