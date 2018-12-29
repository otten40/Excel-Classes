namespace EmployeeAccessFinder
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
            this.Input_PositionID = new System.Windows.Forms.TextBox();
            this.Button_Find = new System.Windows.Forms.Button();
            this.Label_Result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Input_PositionID
            // 
            this.Input_PositionID.Location = new System.Drawing.Point(63, 93);
            this.Input_PositionID.Name = "Input_PositionID";
            this.Input_PositionID.Size = new System.Drawing.Size(100, 20);
            this.Input_PositionID.TabIndex = 0;
            this.Input_PositionID.TextChanged += new System.EventHandler(this.Input_PositionID_TextChanged);
            // 
            // Button_Find
            // 
            this.Button_Find.Location = new System.Drawing.Point(75, 150);
            this.Button_Find.Name = "Button_Find";
            this.Button_Find.Size = new System.Drawing.Size(75, 23);
            this.Button_Find.TabIndex = 1;
            this.Button_Find.Text = "Find";
            this.Button_Find.UseVisualStyleBackColor = true;
            this.Button_Find.Click += new System.EventHandler(this.Button_Find_Click);
            // 
            // Label_Result
            // 
            this.Label_Result.AutoSize = true;
            this.Label_Result.Location = new System.Drawing.Point(227, 93);
            this.Label_Result.Name = "Label_Result";
            this.Label_Result.Size = new System.Drawing.Size(80, 13);
            this.Label_Result.TabIndex = 2;
            this.Label_Result.Text = "Row:      Col:    ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Label_Result);
            this.Controls.Add(this.Button_Find);
            this.Controls.Add(this.Input_PositionID);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Input_PositionID;
        private System.Windows.Forms.Button Button_Find;
        private System.Windows.Forms.Label Label_Result;
    }
}

