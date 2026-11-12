namespace Calizar_Week06_05
{
    partial class ucProductListing
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbItemDescription = new System.Windows.Forms.GroupBox();
            this.cmbUnit = new System.Windows.Forms.ComboBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lbxItems = new System.Windows.Forms.ListBox();
            this.lbxPrompt = new System.Windows.Forms.Label();
            this.gbItemDescription.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbItemDescription
            // 
            this.gbItemDescription.Controls.Add(this.cmbUnit);
            this.gbItemDescription.Controls.Add(this.txtAmount);
            this.gbItemDescription.Controls.Add(this.label2);
            this.gbItemDescription.Controls.Add(this.label1);
            this.gbItemDescription.Controls.Add(this.txtDescription);
            this.gbItemDescription.Location = new System.Drawing.Point(68, 31);
            this.gbItemDescription.Name = "gbItemDescription";
            this.gbItemDescription.Size = new System.Drawing.Size(506, 118);
            this.gbItemDescription.TabIndex = 0;
            this.gbItemDescription.TabStop = false;
            this.gbItemDescription.Text = "ItemDescription";
            this.gbItemDescription.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cmbUnit
            // 
            this.cmbUnit.FormattingEnabled = true;
            this.cmbUnit.Location = new System.Drawing.Point(362, 71);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Size = new System.Drawing.Size(121, 21);
            this.cmbUnit.TabIndex = 4;
            this.cmbUnit.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(178, 72);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(166, 20);
            this.txtAmount.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Amount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(178, 35);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(305, 20);
            this.txtDescription.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(629, 63);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(629, 100);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lbxItems
            // 
            this.lbxItems.FormattingEnabled = true;
            this.lbxItems.Location = new System.Drawing.Point(68, 155);
            this.lbxItems.Name = "lbxItems";
            this.lbxItems.Size = new System.Drawing.Size(636, 121);
            this.lbxItems.TabIndex = 7;
            this.lbxItems.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lbxPrompt
            // 
            this.lbxPrompt.BackColor = System.Drawing.Color.Brown;
            this.lbxPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbxPrompt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbxPrompt.Location = new System.Drawing.Point(68, 304);
            this.lbxPrompt.Name = "lbxPrompt";
            this.lbxPrompt.Size = new System.Drawing.Size(636, 27);
            this.lbxPrompt.TabIndex = 8;
            this.lbxPrompt.Text = "Prompt";
            this.lbxPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbxPrompt.Visible = false;
            // 
            // ucProductListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbxPrompt);
            this.Controls.Add(this.lbxItems);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.gbItemDescription);
            this.Name = "ucProductListing";
            this.Size = new System.Drawing.Size(751, 421);
            this.Load += new System.EventHandler(this.ucProductListing_Load);
            this.gbItemDescription.ResumeLayout(false);
            this.gbItemDescription.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbItemDescription;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cmbUnit;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ListBox lbxItems;
        private System.Windows.Forms.Label lbxPrompt;
    }
}
