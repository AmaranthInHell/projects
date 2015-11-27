namespace ConferenceRooms
{
    partial class AddEditEvent
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
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnGo = new System.Windows.Forms.Button();
            this.lblAttendees = new System.Windows.Forms.Label();
            this.txtAttandees = new System.Windows.Forms.TextBox();
            this.dateStartEvent = new System.Windows.Forms.DateTimePicker();
            this.dateEndEvent = new System.Windows.Forms.DateTimePicker();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(25, 25);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(100, 20);
            this.txtTitle.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(22, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(58, 13);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Event Title";
            // 
            // btnGo
            // 
            this.btnGo.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGo.Location = new System.Drawing.Point(25, 168);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(100, 23);
            this.btnGo.TabIndex = 5;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // lblAttendees
            // 
            this.lblAttendees.AutoSize = true;
            this.lblAttendees.Location = new System.Drawing.Point(22, 126);
            this.lblAttendees.Name = "lblAttendees";
            this.lblAttendees.Size = new System.Drawing.Size(55, 13);
            this.lblAttendees.TabIndex = 6;
            this.lblAttendees.Text = "Attendees";
            // 
            // txtAttandees
            // 
            this.txtAttandees.Location = new System.Drawing.Point(25, 142);
            this.txtAttandees.Name = "txtAttandees";
            this.txtAttandees.Size = new System.Drawing.Size(100, 20);
            this.txtAttandees.TabIndex = 7;
            // 
            // dateStartEvent
            // 
            this.dateStartEvent.Location = new System.Drawing.Point(12, 64);
            this.dateStartEvent.Name = "dateStartEvent";
            this.dateStartEvent.Size = new System.Drawing.Size(126, 20);
            this.dateStartEvent.TabIndex = 8;
            this.dateStartEvent.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateEndEvent
            // 
            this.dateEndEvent.Location = new System.Drawing.Point(12, 103);
            this.dateEndEvent.Name = "dateEndEvent";
            this.dateEndEvent.Size = new System.Drawing.Size(126, 20);
            this.dateEndEvent.TabIndex = 9;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(22, 48);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(55, 13);
            this.lblStartDate.TabIndex = 10;
            this.lblStartDate.Text = "Start Date";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(22, 87);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(52, 13);
            this.lblEndDate.TabIndex = 11;
            this.lblEndDate.Text = "End Date";
            // 
            // AddEditRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(150, 205);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.dateEndEvent);
            this.Controls.Add(this.dateStartEvent);
            this.Controls.Add(this.txtAttandees);
            this.Controls.Add(this.lblAttendees);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtTitle);
            this.Name = "AddEditRoom";
            this.Load += new System.EventHandler(this.AddEditRoom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label lblAttendees;
        private System.Windows.Forms.TextBox txtAttandees;
        private System.Windows.Forms.DateTimePicker dateStartEvent;
        private System.Windows.Forms.DateTimePicker dateEndEvent;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
    }
}