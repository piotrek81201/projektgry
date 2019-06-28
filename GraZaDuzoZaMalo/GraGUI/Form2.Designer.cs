namespace GraGUI
{
    partial class Form2
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.listHistoria = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // listHistoria
            // 
            this.listHistoria.GridLines = true;
            this.listHistoria.HideSelection = false;
            this.listHistoria.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listHistoria.LabelWrap = false;
            this.listHistoria.Location = new System.Drawing.Point(1, 1);
            this.listHistoria.Name = "listHistoria";
            this.listHistoria.Size = new System.Drawing.Size(558, 595);
            this.listHistoria.TabIndex = 0;
            this.listHistoria.UseCompatibleStateImageBehavior = false;
            this.listHistoria.View = System.Windows.Forms.View.Details;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 591);
            this.Controls.Add(this.listHistoria);
            this.Name = "Form2";
            this.Text = "Historia";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listHistoria;
    }
}