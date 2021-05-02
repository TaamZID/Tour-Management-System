
namespace Tour_Management_System.TourHostUC
{
    partial class UC_P_AddEvent
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEventID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEventName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEventNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtRegisDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtRegisEnd = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtPerson = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCost = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnCreate = new Guna.UI2.WinForms.Guna2Button();
            this.btnReset = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mimmo", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create Event";
            // 
            // txtEventID
            // 
            this.txtEventID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEventID.DefaultText = "";
            this.txtEventID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEventID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEventID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEventID.DisabledState.Parent = this.txtEventID;
            this.txtEventID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEventID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEventID.FocusedState.Parent = this.txtEventID;
            this.txtEventID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEventID.ForeColor = System.Drawing.Color.Black;
            this.txtEventID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEventID.HoverState.Parent = this.txtEventID;
            this.txtEventID.Location = new System.Drawing.Point(137, 203);
            this.txtEventID.Name = "txtEventID";
            this.txtEventID.PasswordChar = '\0';
            this.txtEventID.PlaceholderText = "";
            this.txtEventID.SelectedText = "";
            this.txtEventID.ShadowDecoration.Parent = this.txtEventID;
            this.txtEventID.Size = new System.Drawing.Size(313, 36);
            this.txtEventID.TabIndex = 1;
            this.txtEventID.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mimmo", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(133, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Event ID";
            // 
            // txtEventName
            // 
            this.txtEventName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEventName.DefaultText = "";
            this.txtEventName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEventName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEventName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEventName.DisabledState.Parent = this.txtEventName;
            this.txtEventName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEventName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEventName.FocusedState.Parent = this.txtEventName;
            this.txtEventName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEventName.ForeColor = System.Drawing.Color.Black;
            this.txtEventName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEventName.HoverState.Parent = this.txtEventName;
            this.txtEventName.Location = new System.Drawing.Point(137, 340);
            this.txtEventName.Name = "txtEventName";
            this.txtEventName.PasswordChar = '\0';
            this.txtEventName.PlaceholderText = "";
            this.txtEventName.SelectedText = "";
            this.txtEventName.ShadowDecoration.Parent = this.txtEventName;
            this.txtEventName.Size = new System.Drawing.Size(313, 36);
            this.txtEventName.TabIndex = 3;
            // 
            // txtEventNumber
            // 
            this.txtEventNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEventNumber.DefaultText = "";
            this.txtEventNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEventNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEventNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEventNumber.DisabledState.Parent = this.txtEventNumber;
            this.txtEventNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEventNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEventNumber.FocusedState.Parent = this.txtEventNumber;
            this.txtEventNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEventNumber.ForeColor = System.Drawing.Color.Black;
            this.txtEventNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEventNumber.HoverState.Parent = this.txtEventNumber;
            this.txtEventNumber.Location = new System.Drawing.Point(137, 453);
            this.txtEventNumber.Name = "txtEventNumber";
            this.txtEventNumber.PasswordChar = '\0';
            this.txtEventNumber.PlaceholderText = "";
            this.txtEventNumber.SelectedText = "";
            this.txtEventNumber.ShadowDecoration.Parent = this.txtEventNumber;
            this.txtEventNumber.Size = new System.Drawing.Size(313, 36);
            this.txtEventNumber.TabIndex = 4;
            // 
            // txtRegisDate
            // 
            this.txtRegisDate.CheckedState.Parent = this.txtRegisDate;
            this.txtRegisDate.FillColor = System.Drawing.Color.White;
            this.txtRegisDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRegisDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.txtRegisDate.HoverState.Parent = this.txtRegisDate;
            this.txtRegisDate.Location = new System.Drawing.Point(137, 585);
            this.txtRegisDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtRegisDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtRegisDate.Name = "txtRegisDate";
            this.txtRegisDate.ShadowDecoration.Parent = this.txtRegisDate;
            this.txtRegisDate.Size = new System.Drawing.Size(313, 36);
            this.txtRegisDate.TabIndex = 5;
            this.txtRegisDate.Value = new System.DateTime(2021, 4, 30, 20, 42, 27, 501);
            // 
            // txtRegisEnd
            // 
            this.txtRegisEnd.CheckedState.Parent = this.txtRegisEnd;
            this.txtRegisEnd.FillColor = System.Drawing.Color.White;
            this.txtRegisEnd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRegisEnd.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.txtRegisEnd.HoverState.Parent = this.txtRegisEnd;
            this.txtRegisEnd.Location = new System.Drawing.Point(617, 203);
            this.txtRegisEnd.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtRegisEnd.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtRegisEnd.Name = "txtRegisEnd";
            this.txtRegisEnd.ShadowDecoration.Parent = this.txtRegisEnd;
            this.txtRegisEnd.Size = new System.Drawing.Size(313, 36);
            this.txtRegisEnd.TabIndex = 6;
            this.txtRegisEnd.Value = new System.DateTime(2021, 4, 30, 20, 42, 27, 501);
            // 
            // txtPerson
            // 
            this.txtPerson.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPerson.DefaultText = "";
            this.txtPerson.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPerson.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPerson.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPerson.DisabledState.Parent = this.txtPerson;
            this.txtPerson.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPerson.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPerson.FocusedState.Parent = this.txtPerson;
            this.txtPerson.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPerson.ForeColor = System.Drawing.Color.Black;
            this.txtPerson.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPerson.HoverState.Parent = this.txtPerson;
            this.txtPerson.Location = new System.Drawing.Point(617, 340);
            this.txtPerson.Name = "txtPerson";
            this.txtPerson.PasswordChar = '\0';
            this.txtPerson.PlaceholderText = "";
            this.txtPerson.SelectedText = "";
            this.txtPerson.ShadowDecoration.Parent = this.txtPerson;
            this.txtPerson.Size = new System.Drawing.Size(313, 36);
            this.txtPerson.TabIndex = 7;
            // 
            // txtCost
            // 
            this.txtCost.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCost.DefaultText = "";
            this.txtCost.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCost.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCost.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCost.DisabledState.Parent = this.txtCost;
            this.txtCost.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCost.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCost.FocusedState.Parent = this.txtCost;
            this.txtCost.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCost.ForeColor = System.Drawing.Color.Black;
            this.txtCost.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCost.HoverState.Parent = this.txtCost;
            this.txtCost.Location = new System.Drawing.Point(617, 453);
            this.txtCost.Name = "txtCost";
            this.txtCost.PasswordChar = '\0';
            this.txtCost.PlaceholderText = "";
            this.txtCost.SelectedText = "";
            this.txtCost.ShadowDecoration.Parent = this.txtCost;
            this.txtCost.Size = new System.Drawing.Size(313, 36);
            this.txtCost.TabIndex = 8;
            // 
            // btnCreate
            // 
            this.btnCreate.BorderRadius = 19;
            this.btnCreate.BorderThickness = 1;
            this.btnCreate.CheckedState.Parent = this.btnCreate;
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreate.CustomImages.Parent = this.btnCreate;
            this.btnCreate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.HoverState.Parent = this.btnCreate;
            this.btnCreate.Location = new System.Drawing.Point(617, 576);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.ShadowDecoration.Parent = this.btnCreate;
            this.btnCreate.Size = new System.Drawing.Size(148, 45);
            this.btnCreate.TabIndex = 9;
            this.btnCreate.Text = "Create";
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnReset
            // 
            this.btnReset.BorderRadius = 19;
            this.btnReset.BorderThickness = 1;
            this.btnReset.CheckedState.Parent = this.btnReset;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.CustomImages.Parent = this.btnReset;
            this.btnReset.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.HoverState.Parent = this.btnReset;
            this.btnReset.Location = new System.Drawing.Point(795, 576);
            this.btnReset.Name = "btnReset";
            this.btnReset.ShadowDecoration.Parent = this.btnReset;
            this.btnReset.Size = new System.Drawing.Size(135, 45);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mimmo", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(133, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Event Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mimmo", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(133, 428);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Event Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mimmo", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(133, 560);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "Registration Starts";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mimmo", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(613, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "Registration Ends";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Mimmo", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(613, 315);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 24);
            this.label7.TabIndex = 15;
            this.label7.Text = "Person";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Mimmo", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(613, 428);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 24);
            this.label8.TabIndex = 16;
            this.label8.Text = "Cost Per Person";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // UC_P_AddEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.txtPerson);
            this.Controls.Add(this.txtRegisEnd);
            this.Controls.Add(this.txtRegisDate);
            this.Controls.Add(this.txtEventNumber);
            this.Controls.Add(this.txtEventName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEventID);
            this.Controls.Add(this.label1);
            this.Name = "UC_P_AddEvent";
            this.Size = new System.Drawing.Size(1074, 734);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtEventID;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtEventName;
        private Guna.UI2.WinForms.Guna2TextBox txtEventNumber;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtRegisDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtRegisEnd;
        private Guna.UI2.WinForms.Guna2TextBox txtPerson;
        private Guna.UI2.WinForms.Guna2TextBox txtCost;
        private Guna.UI2.WinForms.Guna2Button btnCreate;
        private Guna.UI2.WinForms.Guna2Button btnReset;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
