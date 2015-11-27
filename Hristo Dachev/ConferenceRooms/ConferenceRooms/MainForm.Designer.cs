namespace ConferenceRooms
{
    partial class MainForm
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
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.btnDeleteRoom = new System.Windows.Forms.Button();
            this.btnEditRoom = new System.Windows.Forms.Button();
            this.confList = new System.Windows.Forms.DataGridView();
            this.bsRooms = new System.Windows.Forms.BindingSource(this.components);
            this.btnListEvents = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.confList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRooms)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.Location = new System.Drawing.Point(594, 12);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(92, 23);
            this.btnAddRoom.TabIndex = 1;
            this.btnAddRoom.Text = "Add Room";
            this.btnAddRoom.UseVisualStyleBackColor = true;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // btnDeleteRoom
            // 
            this.btnDeleteRoom.Location = new System.Drawing.Point(594, 41);
            this.btnDeleteRoom.Name = "btnDeleteRoom";
            this.btnDeleteRoom.Size = new System.Drawing.Size(92, 23);
            this.btnDeleteRoom.TabIndex = 2;
            this.btnDeleteRoom.Text = "Delete Room";
            this.btnDeleteRoom.UseVisualStyleBackColor = true;
            this.btnDeleteRoom.Click += new System.EventHandler(this.btnDeleteRoom_Click);
            // 
            // btnEditRoom
            // 
            this.btnEditRoom.Location = new System.Drawing.Point(594, 70);
            this.btnEditRoom.Name = "btnEditRoom";
            this.btnEditRoom.Size = new System.Drawing.Size(92, 23);
            this.btnEditRoom.TabIndex = 3;
            this.btnEditRoom.Text = "Edit Room";
            this.btnEditRoom.UseVisualStyleBackColor = true;
            this.btnEditRoom.Click += new System.EventHandler(this.btnEditRoom_Click);
            // 
            // confList
            // 
            this.confList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.confList.Location = new System.Drawing.Point(12, 12);
            this.confList.Name = "confList";
            this.confList.Size = new System.Drawing.Size(560, 311);
            this.confList.TabIndex = 4;
            // 
            // btnListEvents
            // 
            this.btnListEvents.Location = new System.Drawing.Point(594, 99);
            this.btnListEvents.Name = "btnListEvents";
            this.btnListEvents.Size = new System.Drawing.Size(92, 23);
            this.btnListEvents.TabIndex = 5;
            this.btnListEvents.Text = "Gib Events";
            this.btnListEvents.UseVisualStyleBackColor = true;
            this.btnListEvents.Click += new System.EventHandler(this.btnListEvents_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 336);
            this.Controls.Add(this.btnListEvents);
            this.Controls.Add(this.confList);
            this.Controls.Add(this.btnEditRoom);
            this.Controls.Add(this.btnDeleteRoom);
            this.Controls.Add(this.btnAddRoom);
            this.Name = "MainForm";
            this.Text = "Conference Rooms";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.confList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRooms)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bsRooms;
        private System.Windows.Forms.Button btnAddRoom;
        private System.Windows.Forms.Button btnDeleteRoom;
        private System.Windows.Forms.Button btnEditRoom;
        private System.Windows.Forms.DataGridView confList;
        private System.Windows.Forms.Button btnListEvents;
    }
}

