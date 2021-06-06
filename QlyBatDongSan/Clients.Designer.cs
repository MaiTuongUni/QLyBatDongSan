
namespace QlyBatDongSan
{
    partial class Clients
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdClient = new System.Windows.Forms.TextBox();
            this.txtFirstNameClient = new System.Windows.Forms.TextBox();
            this.txtLastNameClient = new System.Windows.Forms.TextBox();
            this.txtPhoneClient = new System.Windows.Forms.TextBox();
            this.txtEmailClient = new System.Windows.Forms.TextBox();
            this.txtAddressClient = new System.Windows.Forms.TextBox();
            this.lvClient = new System.Windows.Forms.ListView();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.btnEditClient = new System.Windows.Forms.Button();
            this.btnRemoveClient = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Magenta;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(949, 77);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Orchid;
            this.panel2.Controls.Add(this.btnRefresh);
            this.panel2.Controls.Add(this.btnRemoveClient);
            this.panel2.Controls.Add(this.btnEditClient);
            this.panel2.Controls.Add(this.btnAddClient);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 533);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(949, 109);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Orchid;
            this.panel3.Controls.Add(this.txtAddressClient);
            this.panel3.Controls.Add(this.txtEmailClient);
            this.panel3.Controls.Add(this.txtPhoneClient);
            this.panel3.Controls.Add(this.txtLastNameClient);
            this.panel3.Controls.Add(this.txtFirstNameClient);
            this.panel3.Controls.Add(this.txtIdClient);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 77);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(462, 456);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Orchid;
            this.panel4.Controls.Add(this.lvClient);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(468, 77);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(481, 456);
            this.panel4.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(406, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(129, 39);
            this.label11.TabIndex = 4;
            this.label11.Text = "Clients";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "FirstName:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "LastName:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Phone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Address:";
            // 
            // txtIdClient
            // 
            this.txtIdClient.Location = new System.Drawing.Point(107, 22);
            this.txtIdClient.Name = "txtIdClient";
            this.txtIdClient.Size = new System.Drawing.Size(310, 22);
            this.txtIdClient.TabIndex = 1;
            // 
            // txtFirstNameClient
            // 
            this.txtFirstNameClient.Location = new System.Drawing.Point(107, 70);
            this.txtFirstNameClient.Name = "txtFirstNameClient";
            this.txtFirstNameClient.Size = new System.Drawing.Size(310, 22);
            this.txtFirstNameClient.TabIndex = 1;
            // 
            // txtLastNameClient
            // 
            this.txtLastNameClient.Location = new System.Drawing.Point(107, 117);
            this.txtLastNameClient.Name = "txtLastNameClient";
            this.txtLastNameClient.Size = new System.Drawing.Size(310, 22);
            this.txtLastNameClient.TabIndex = 1;
            // 
            // txtPhoneClient
            // 
            this.txtPhoneClient.Location = new System.Drawing.Point(107, 166);
            this.txtPhoneClient.Name = "txtPhoneClient";
            this.txtPhoneClient.Size = new System.Drawing.Size(310, 22);
            this.txtPhoneClient.TabIndex = 1;
            // 
            // txtEmailClient
            // 
            this.txtEmailClient.Location = new System.Drawing.Point(107, 217);
            this.txtEmailClient.Name = "txtEmailClient";
            this.txtEmailClient.Size = new System.Drawing.Size(310, 22);
            this.txtEmailClient.TabIndex = 1;
            // 
            // txtAddressClient
            // 
            this.txtAddressClient.Location = new System.Drawing.Point(107, 277);
            this.txtAddressClient.Multiline = true;
            this.txtAddressClient.Name = "txtAddressClient";
            this.txtAddressClient.Size = new System.Drawing.Size(310, 146);
            this.txtAddressClient.TabIndex = 1;
            // 
            // lvClient
            // 
            this.lvClient.HideSelection = false;
            this.lvClient.Location = new System.Drawing.Point(35, 22);
            this.lvClient.Name = "lvClient";
            this.lvClient.Size = new System.Drawing.Size(416, 401);
            this.lvClient.TabIndex = 0;
            this.lvClient.UseCompatibleStateImageBehavior = false;
            // 
            // btnAddClient
            // 
            this.btnAddClient.Location = new System.Drawing.Point(86, 25);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(150, 57);
            this.btnAddClient.TabIndex = 0;
            this.btnAddClient.Text = "Add";
            this.btnAddClient.UseVisualStyleBackColor = true;
            // 
            // btnEditClient
            // 
            this.btnEditClient.Location = new System.Drawing.Point(267, 25);
            this.btnEditClient.Name = "btnEditClient";
            this.btnEditClient.Size = new System.Drawing.Size(150, 57);
            this.btnEditClient.TabIndex = 0;
            this.btnEditClient.Text = "Edit";
            this.btnEditClient.UseVisualStyleBackColor = true;
            // 
            // btnRemoveClient
            // 
            this.btnRemoveClient.Location = new System.Drawing.Point(468, 25);
            this.btnRemoveClient.Name = "btnRemoveClient";
            this.btnRemoveClient.Size = new System.Drawing.Size(150, 57);
            this.btnRemoveClient.TabIndex = 0;
            this.btnRemoveClient.Text = "Remove";
            this.btnRemoveClient.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(665, 25);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(254, 57);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 642);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Clients";
            this.Text = "Clients";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.TextBox txtAddressClient;
        private System.Windows.Forms.TextBox txtEmailClient;
        private System.Windows.Forms.TextBox txtPhoneClient;
        private System.Windows.Forms.TextBox txtLastNameClient;
        private System.Windows.Forms.TextBox txtFirstNameClient;
        private System.Windows.Forms.TextBox txtIdClient;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvClient;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnRemoveClient;
        private System.Windows.Forms.Button btnEditClient;
    }
}