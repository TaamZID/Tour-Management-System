
namespace Tour_Management_System
{
    partial class EventHost
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventHost));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.btnBooking = new Guna.UI2.WinForms.Guna2Button();
            this.btnModify = new Guna.UI2.WinForms.Guna2Button();
            this.btnViewEvent = new Guna.UI2.WinForms.Guna2Button();
            this.btnCreateEvent = new Guna.UI2.WinForms.Guna2Button();
            this.btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uC_P_Booking1 = new Tour_Management_System.TourHostUC.UC_P_Booking();
            this.uC_P_UpdateEvent1 = new Tour_Management_System.TourHostUC.UC_P_UpdateEvent();
            this.uC_P_ViewEvent1 = new Tour_Management_System.TourHostUC.UC_P_ViewEvent();
            this.uC_P_AddEvent1 = new Tour_Management_System.TourHostUC.UC_P_AddEvent();
            this.uC_P_Dashboard1 = new Tour_Management_System.TourHostUC.UC_P_Dashboard();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnBooking);
            this.panel1.Controls.Add(this.btnModify);
            this.panel1.Controls.Add(this.btnViewEvent);
            this.panel1.Controls.Add(this.btnCreateEvent);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(367, 805);
            this.panel1.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnLogout.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnLogout.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnLogout.CheckedState.Parent = this.btnLogout;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.CustomImages.Parent = this.btnLogout;
            this.btnLogout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogout.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.HoverState.Parent = this.btnLogout;
            this.btnLogout.Location = new System.Drawing.Point(157, 679);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.ShadowDecoration.Parent = this.btnLogout;
            this.btnLogout.Size = new System.Drawing.Size(210, 45);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnBooking
            // 
            this.btnBooking.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnBooking.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnBooking.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnBooking.CheckedState.Parent = this.btnBooking;
            this.btnBooking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBooking.CustomImages.Parent = this.btnBooking;
            this.btnBooking.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBooking.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooking.ForeColor = System.Drawing.Color.White;
            this.btnBooking.HoverState.Parent = this.btnBooking;
            this.btnBooking.Location = new System.Drawing.Point(157, 615);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.ShadowDecoration.Parent = this.btnBooking;
            this.btnBooking.Size = new System.Drawing.Size(210, 45);
            this.btnBooking.TabIndex = 6;
            this.btnBooking.Text = "Booking";
            this.btnBooking.Click += new System.EventHandler(this.btnBooking_Click);
            // 
            // btnModify
            // 
            this.btnModify.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnModify.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnModify.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnModify.CheckedState.Parent = this.btnModify;
            this.btnModify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModify.CustomImages.Parent = this.btnModify;
            this.btnModify.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnModify.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModify.ForeColor = System.Drawing.Color.White;
            this.btnModify.HoverState.Parent = this.btnModify;
            this.btnModify.Location = new System.Drawing.Point(157, 564);
            this.btnModify.Name = "btnModify";
            this.btnModify.ShadowDecoration.Parent = this.btnModify;
            this.btnModify.Size = new System.Drawing.Size(210, 45);
            this.btnModify.TabIndex = 5;
            this.btnModify.Text = "Modify Event";
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnViewEvent
            // 
            this.btnViewEvent.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnViewEvent.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnViewEvent.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnViewEvent.CheckedState.Parent = this.btnViewEvent;
            this.btnViewEvent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewEvent.CustomImages.Parent = this.btnViewEvent;
            this.btnViewEvent.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnViewEvent.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewEvent.ForeColor = System.Drawing.Color.White;
            this.btnViewEvent.HoverState.Parent = this.btnViewEvent;
            this.btnViewEvent.Location = new System.Drawing.Point(157, 502);
            this.btnViewEvent.Name = "btnViewEvent";
            this.btnViewEvent.ShadowDecoration.Parent = this.btnViewEvent;
            this.btnViewEvent.Size = new System.Drawing.Size(210, 45);
            this.btnViewEvent.TabIndex = 4;
            this.btnViewEvent.Text = "View Event(s)";
            this.btnViewEvent.Click += new System.EventHandler(this.btnViewEvent_Click);
            // 
            // btnCreateEvent
            // 
            this.btnCreateEvent.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCreateEvent.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnCreateEvent.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnCreateEvent.CheckedState.Parent = this.btnCreateEvent;
            this.btnCreateEvent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateEvent.CustomImages.Parent = this.btnCreateEvent;
            this.btnCreateEvent.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCreateEvent.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateEvent.ForeColor = System.Drawing.Color.White;
            this.btnCreateEvent.HoverState.Parent = this.btnCreateEvent;
            this.btnCreateEvent.Location = new System.Drawing.Point(157, 440);
            this.btnCreateEvent.Name = "btnCreateEvent";
            this.btnCreateEvent.ShadowDecoration.Parent = this.btnCreateEvent;
            this.btnCreateEvent.Size = new System.Drawing.Size(210, 45);
            this.btnCreateEvent.TabIndex = 3;
            this.btnCreateEvent.Text = "Create Event";
            this.btnCreateEvent.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnDashboard.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnDashboard.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnDashboard.CheckedState.Parent = this.btnDashboard;
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.CustomImages.Parent = this.btnDashboard;
            this.btnDashboard.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDashboard.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.HoverState.Parent = this.btnDashboard;
            this.btnDashboard.Location = new System.Drawing.Point(157, 379);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.ShadowDecoration.Parent = this.btnDashboard;
            this.btnDashboard.Size = new System.Drawing.Size(210, 45);
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mimmo", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(104, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tour Host";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(367, 298);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.uC_P_Booking1);
            this.panel2.Controls.Add(this.uC_P_UpdateEvent1);
            this.panel2.Controls.Add(this.uC_P_ViewEvent1);
            this.panel2.Controls.Add(this.uC_P_AddEvent1);
            this.panel2.Controls.Add(this.uC_P_Dashboard1);
            this.panel2.Location = new System.Drawing.Point(373, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1073, 805);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // uC_P_Booking1
            // 
            this.uC_P_Booking1.BackColor = System.Drawing.Color.White;
            this.uC_P_Booking1.Location = new System.Drawing.Point(-4, 0);
            this.uC_P_Booking1.Name = "uC_P_Booking1";
            this.uC_P_Booking1.Size = new System.Drawing.Size(1050, 768);
            this.uC_P_Booking1.TabIndex = 4;
            // 
            // uC_P_UpdateEvent1
            // 
            this.uC_P_UpdateEvent1.BackColor = System.Drawing.Color.White;
            this.uC_P_UpdateEvent1.Font = new System.Drawing.Font("Sagar", 8.25F);
            this.uC_P_UpdateEvent1.ForeColor = System.Drawing.Color.Black;
            this.uC_P_UpdateEvent1.Location = new System.Drawing.Point(-4, 0);
            this.uC_P_UpdateEvent1.Name = "uC_P_UpdateEvent1";
            this.uC_P_UpdateEvent1.Size = new System.Drawing.Size(1033, 734);
            this.uC_P_UpdateEvent1.TabIndex = 3;
            // 
            // uC_P_ViewEvent1
            // 
            this.uC_P_ViewEvent1.BackColor = System.Drawing.Color.White;
            this.uC_P_ViewEvent1.Location = new System.Drawing.Point(-4, 0);
            this.uC_P_ViewEvent1.Name = "uC_P_ViewEvent1";
            this.uC_P_ViewEvent1.Size = new System.Drawing.Size(1074, 734);
            this.uC_P_ViewEvent1.TabIndex = 2;
            // 
            // uC_P_AddEvent1
            // 
            this.uC_P_AddEvent1.BackColor = System.Drawing.Color.White;
            this.uC_P_AddEvent1.Location = new System.Drawing.Point(-4, 0);
            this.uC_P_AddEvent1.Name = "uC_P_AddEvent1";
            this.uC_P_AddEvent1.Size = new System.Drawing.Size(1074, 734);
            this.uC_P_AddEvent1.TabIndex = 1;
            // 
            // uC_P_Dashboard1
            // 
            this.uC_P_Dashboard1.BackColor = System.Drawing.Color.White;
            this.uC_P_Dashboard1.Location = new System.Drawing.Point(-4, 3);
            this.uC_P_Dashboard1.Name = "uC_P_Dashboard1";
            this.uC_P_Dashboard1.Size = new System.Drawing.Size(1074, 740);
            this.uC_P_Dashboard1.TabIndex = 0;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this.panel2;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this.panel2;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.TargetControl = this.panel2;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.TargetControl = this.panel2;
            // 
            // guna2Elipse5
            // 
            this.guna2Elipse5.TargetControl = this.panel2;
            // 
            // EventHost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1462, 785);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EventHost";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EventHost";
            this.Load += new System.EventHandler(this.EventHost_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private Guna.UI2.WinForms.Guna2Button btnBooking;
        private Guna.UI2.WinForms.Guna2Button btnModify;
        private Guna.UI2.WinForms.Guna2Button btnViewEvent;
        private Guna.UI2.WinForms.Guna2Button btnCreateEvent;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private TourHostUC.UC_P_Dashboard uC_P_Dashboard1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private TourHostUC.UC_P_AddEvent uC_P_AddEvent1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private TourHostUC.UC_P_ViewEvent uC_P_ViewEvent1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private TourHostUC.UC_P_UpdateEvent uC_P_UpdateEvent1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private TourHostUC.UC_P_Booking uC_P_Booking1;
    }
}