namespace CarRental
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
            this.listViewCar = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddCar = new System.Windows.Forms.Button();
            this.btnDeleteCar = new System.Windows.Forms.Button();
            this.btnEditCar = new System.Windows.Forms.Button();
            this.btnUnrentCar = new System.Windows.Forms.Button();
            this.btnRentCar = new System.Windows.Forms.Button();
            this.btnCalculateRent = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotalRent = new System.Windows.Forms.TextBox();
            this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewCar
            // 
            this.listViewCar.FullRowSelect = true;
            this.listViewCar.Location = new System.Drawing.Point(12, 38);
            this.listViewCar.Name = "listViewCar";
            this.listViewCar.Size = new System.Drawing.Size(694, 333);
            this.listViewCar.TabIndex = 0;
            this.listViewCar.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "List Available Cars :";
            // 
            // btnAddCar
            // 
            this.btnAddCar.Location = new System.Drawing.Point(734, 38);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(128, 33);
            this.btnAddCar.TabIndex = 2;
            this.btnAddCar.Text = "Add Car";
            this.btnAddCar.UseVisualStyleBackColor = true;
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
            // 
            // btnDeleteCar
            // 
            this.btnDeleteCar.Location = new System.Drawing.Point(734, 128);
            this.btnDeleteCar.Name = "btnDeleteCar";
            this.btnDeleteCar.Size = new System.Drawing.Size(128, 33);
            this.btnDeleteCar.TabIndex = 3;
            this.btnDeleteCar.Text = "Delete Car";
            this.btnDeleteCar.UseVisualStyleBackColor = true;
            this.btnDeleteCar.Click += new System.EventHandler(this.btnDeleteCar_Click);
            // 
            // btnEditCar
            // 
            this.btnEditCar.Location = new System.Drawing.Point(734, 83);
            this.btnEditCar.Name = "btnEditCar";
            this.btnEditCar.Size = new System.Drawing.Size(128, 33);
            this.btnEditCar.TabIndex = 4;
            this.btnEditCar.Text = "Edit Car";
            this.btnEditCar.UseVisualStyleBackColor = true;
            this.btnEditCar.Click += new System.EventHandler(this.btnEditCar_Click);
            // 
            // btnUnrentCar
            // 
            this.btnUnrentCar.Location = new System.Drawing.Point(734, 318);
            this.btnUnrentCar.Name = "btnUnrentCar";
            this.btnUnrentCar.Size = new System.Drawing.Size(128, 53);
            this.btnUnrentCar.TabIndex = 5;
            this.btnUnrentCar.Text = "Cancel Rent Selected Car";
            this.btnUnrentCar.UseVisualStyleBackColor = true;
            this.btnUnrentCar.Click += new System.EventHandler(this.btnUnrentCar_Click);
            // 
            // btnRentCar
            // 
            this.btnRentCar.Location = new System.Drawing.Point(734, 250);
            this.btnRentCar.Name = "btnRentCar";
            this.btnRentCar.Size = new System.Drawing.Size(128, 52);
            this.btnRentCar.TabIndex = 6;
            this.btnRentCar.Text = "Rent Selected Car";
            this.btnRentCar.UseVisualStyleBackColor = true;
            this.btnRentCar.Click += new System.EventHandler(this.btnRentCar_Click);
            // 
            // btnCalculateRent
            // 
            this.btnCalculateRent.Location = new System.Drawing.Point(12, 385);
            this.btnCalculateRent.Name = "btnCalculateRent";
            this.btnCalculateRent.Size = new System.Drawing.Size(155, 53);
            this.btnCalculateRent.TabIndex = 7;
            this.btnCalculateRent.Text = "Calculate Total Rent";
            this.btnCalculateRent.UseVisualStyleBackColor = true;
            this.btnCalculateRent.Click += new System.EventHandler(this.btnCalculateRent_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 403);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Total Rent : ";
            // 
            // txtTotalRent
            // 
            this.txtTotalRent.Location = new System.Drawing.Point(274, 398);
            this.txtTotalRent.Name = "txtTotalRent";
            this.txtTotalRent.Size = new System.Drawing.Size(188, 22);
            this.txtTotalRent.TabIndex = 9;
            // 
            // carBindingSource
            // 
            this.carBindingSource.DataSource = typeof(CarRental.Car);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 450);
            this.Controls.Add(this.txtTotalRent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCalculateRent);
            this.Controls.Add(this.btnRentCar);
            this.Controls.Add(this.btnUnrentCar);
            this.Controls.Add(this.btnEditCar);
            this.Controls.Add(this.btnDeleteCar);
            this.Controls.Add(this.btnAddCar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewCar);
            this.Name = "MainForm";
            this.Text = "Car Rental";
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewCar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddCar;
        private System.Windows.Forms.Button btnDeleteCar;
        private System.Windows.Forms.Button btnEditCar;
        private System.Windows.Forms.Button btnUnrentCar;
        private System.Windows.Forms.BindingSource carBindingSource;
        private System.Windows.Forms.Button btnRentCar;
        private System.Windows.Forms.Button btnCalculateRent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotalRent;
    }
}

