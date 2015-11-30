namespace ConferenceRooms
{
    partial class EventsView
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
            this.components = new System.ComponentModel.Container();
            this.eventList = new System.Windows.Forms.DataGridView();
            this.btnNewRoom = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.bsEvents = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.eventList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEvents)).BeginInit();
            this.SuspendLayout();
            // 
            // eventList
            // 
            this.eventList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventList.Location = new System.Drawing.Point(12, 12);
            this.eventList.Name = "eventList";
            this.eventList.Size = new System.Drawing.Size(534, 268);
            this.eventList.TabIndex = 0;
            // 
            // btnNewRoom
            // 
            this.btnNewRoom.Location = new System.Drawing.Point(552, 12);
            this.btnNewRoom.Name = "btnNewRoom";
            this.btnNewRoom.Size = new System.Drawing.Size(118, 23);
            this.btnNewRoom.TabIndex = 1;
            this.btnNewRoom.Text = "Gib me an Event";
            this.btnNewRoom.UseVisualStyleBackColor = true;
            this.btnNewRoom.Click += new System.EventHandler(this.btnNewRoom_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(552, 41);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(118, 23);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit my Event";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(552, 70);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(118, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Rid me of Event";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // EventsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 292);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNewRoom);
            this.Controls.Add(this.eventList);
            this.Name = "EventsView";
            this.Text = "These are my Room\'s Events";
            this.Load += new System.EventHandler(this.EventsView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEvents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bsEvents;
        private System.Windows.Forms.DataGridView eventList;
        private System.Windows.Forms.Button btnNewRoom;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
    }
}