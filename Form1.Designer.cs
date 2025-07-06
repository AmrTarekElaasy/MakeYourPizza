namespace MakeYourPizza
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
            this.labTheTitel = new System.Windows.Forms.Label();
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.rbLarg = new System.Windows.Forms.RadioButton();
            this.rbMeduim = new System.Windows.Forms.RadioButton();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbCrustType = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rbThinkCrust = new System.Windows.Forms.RadioButton();
            this.rbThinCrust = new System.Windows.Forms.RadioButton();
            this.gbToppings = new System.Windows.Forms.GroupBox();
            this.chkGreenPeppers = new System.Windows.Forms.CheckBox();
            this.chkTomatoes = new System.Windows.Forms.CheckBox();
            this.chkOlives = new System.Windows.Forms.CheckBox();
            this.chkMushrooms = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.chkExtraCheese = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOrderPizza = new System.Windows.Forms.Button();
            this.btnResetForm = new System.Windows.Forms.Button();
            this.gpOrderSummary = new System.Windows.Forms.GroupBox();
            this.gbWhereToEat = new System.Windows.Forms.GroupBox();
            this.rbTakeOut = new System.Windows.Forms.RadioButton();
            this.rbEatIn = new System.Windows.Forms.RadioButton();
            this.labTotalSalary = new System.Windows.Forms.Label();
            this.labTitleFinalSalary = new System.Windows.Forms.Label();
            this.labTitleWhereToEat = new System.Windows.Forms.Label();
            this.labWhereToEat = new System.Windows.Forms.Label();
            this.labTitleFinalCrustType = new System.Windows.Forms.Label();
            this.labFinalCrustType = new System.Windows.Forms.Label();
            this.labTitleFinalSize = new System.Windows.Forms.Label();
            this.labFinalSize = new System.Windows.Forms.Label();
            this.labTitleFinalToppings = new System.Windows.Forms.Label();
            this.labFinalToppings = new System.Windows.Forms.Label();
            this.gbSize.SuspendLayout();
            this.gbCrustType.SuspendLayout();
            this.gbToppings.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gpOrderSummary.SuspendLayout();
            this.gbWhereToEat.SuspendLayout();
            this.SuspendLayout();
            // 
            // labTheTitel
            // 
            this.labTheTitel.Font = new System.Drawing.Font("Segoe Print", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTheTitel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labTheTitel.Location = new System.Drawing.Point(270, 5);
            this.labTheTitel.Name = "labTheTitel";
            this.labTheTitel.Size = new System.Drawing.Size(265, 51);
            this.labTheTitel.TabIndex = 0;
            this.labTheTitel.Text = "Make Your Pizza";
            // 
            // gbSize
            // 
            this.gbSize.Controls.Add(this.rbLarg);
            this.gbSize.Controls.Add(this.rbMeduim);
            this.gbSize.Controls.Add(this.rbSmall);
            this.gbSize.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSize.Location = new System.Drawing.Point(13, 72);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(103, 100);
            this.gbSize.TabIndex = 1;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Size";
            this.gbSize.Enter += new System.EventHandler(this.gbSize_Enter);
            // 
            // rbLarg
            // 
            this.rbLarg.AutoSize = true;
            this.rbLarg.Location = new System.Drawing.Point(21, 67);
            this.rbLarg.Name = "rbLarg";
            this.rbLarg.Size = new System.Drawing.Size(58, 27);
            this.rbLarg.TabIndex = 2;
            this.rbLarg.Text = "Larg";
            this.rbLarg.UseVisualStyleBackColor = true;
            this.rbLarg.CheckedChanged += new System.EventHandler(this.rbLarg_CheckedChanged);
            // 
            // rbMeduim
            // 
            this.rbMeduim.AutoSize = true;
            this.rbMeduim.Location = new System.Drawing.Point(21, 44);
            this.rbMeduim.Name = "rbMeduim";
            this.rbMeduim.Size = new System.Drawing.Size(81, 27);
            this.rbMeduim.TabIndex = 1;
            this.rbMeduim.Text = "Meduim";
            this.rbMeduim.UseVisualStyleBackColor = true;
            this.rbMeduim.CheckedChanged += new System.EventHandler(this.rbMeduim_CheckedChanged);
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Location = new System.Drawing.Point(21, 21);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(65, 27);
            this.rbSmall.TabIndex = 0;
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = true;
            this.rbSmall.CheckedChanged += new System.EventHandler(this.rbSmall_CheckedChanged);
            // 
            // gbCrustType
            // 
            this.gbCrustType.Controls.Add(this.radioButton1);
            this.gbCrustType.Controls.Add(this.rbThinkCrust);
            this.gbCrustType.Controls.Add(this.rbThinCrust);
            this.gbCrustType.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCrustType.Location = new System.Drawing.Point(13, 210);
            this.gbCrustType.Name = "gbCrustType";
            this.gbCrustType.Size = new System.Drawing.Size(140, 71);
            this.gbCrustType.TabIndex = 3;
            this.gbCrustType.TabStop = false;
            this.gbCrustType.Text = "Crust Type";
            this.gbCrustType.Enter += new System.EventHandler(this.gbCrustType_Enter);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(21, 77);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(14, 13);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Visible = false;
            // 
            // rbThinkCrust
            // 
            this.rbThinkCrust.AutoSize = true;
            this.rbThinkCrust.Location = new System.Drawing.Point(21, 44);
            this.rbThinkCrust.Name = "rbThinkCrust";
            this.rbThinkCrust.Size = new System.Drawing.Size(107, 27);
            this.rbThinkCrust.TabIndex = 1;
            this.rbThinkCrust.TabStop = true;
            this.rbThinkCrust.Text = "Think Crust";
            this.rbThinkCrust.UseVisualStyleBackColor = true;
            this.rbThinkCrust.CheckedChanged += new System.EventHandler(this.rbThinkCrust_CheckedChanged);
            // 
            // rbThinCrust
            // 
            this.rbThinCrust.AutoSize = true;
            this.rbThinCrust.Location = new System.Drawing.Point(21, 21);
            this.rbThinCrust.Name = "rbThinCrust";
            this.rbThinCrust.Size = new System.Drawing.Size(99, 27);
            this.rbThinCrust.TabIndex = 0;
            this.rbThinCrust.TabStop = true;
            this.rbThinCrust.Text = "Thin Crust";
            this.rbThinCrust.UseVisualStyleBackColor = true;
            this.rbThinCrust.CheckedChanged += new System.EventHandler(this.rbThinCrust_CheckedChanged);
            // 
            // gbToppings
            // 
            this.gbToppings.Controls.Add(this.chkGreenPeppers);
            this.gbToppings.Controls.Add(this.chkTomatoes);
            this.gbToppings.Controls.Add(this.chkOlives);
            this.gbToppings.Controls.Add(this.chkMushrooms);
            this.gbToppings.Controls.Add(this.chkOnion);
            this.gbToppings.Controls.Add(this.chkExtraCheese);
            this.gbToppings.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbToppings.Location = new System.Drawing.Point(279, 72);
            this.gbToppings.Name = "gbToppings";
            this.gbToppings.Size = new System.Drawing.Size(246, 100);
            this.gbToppings.TabIndex = 4;
            this.gbToppings.TabStop = false;
            this.gbToppings.Text = "Toppings";
            this.gbToppings.Enter += new System.EventHandler(this.gbToppings_Enter);
            // 
            // chkGreenPeppers
            // 
            this.chkGreenPeppers.AutoSize = true;
            this.chkGreenPeppers.Location = new System.Drawing.Point(116, 67);
            this.chkGreenPeppers.Name = "chkGreenPeppers";
            this.chkGreenPeppers.Size = new System.Drawing.Size(126, 27);
            this.chkGreenPeppers.TabIndex = 5;
            this.chkGreenPeppers.Text = "Green Peppers";
            this.chkGreenPeppers.UseVisualStyleBackColor = true;
            this.chkGreenPeppers.CheckedChanged += new System.EventHandler(this.chkGreenPeppers_CheckedChanged);
            // 
            // chkTomatoes
            // 
            this.chkTomatoes.AutoSize = true;
            this.chkTomatoes.Location = new System.Drawing.Point(7, 68);
            this.chkTomatoes.Name = "chkTomatoes";
            this.chkTomatoes.Size = new System.Drawing.Size(92, 27);
            this.chkTomatoes.TabIndex = 4;
            this.chkTomatoes.Text = "Tomatoes";
            this.chkTomatoes.UseVisualStyleBackColor = true;
            this.chkTomatoes.CheckedChanged += new System.EventHandler(this.chkTomatoes_CheckedChanged);
            // 
            // chkOlives
            // 
            this.chkOlives.AutoSize = true;
            this.chkOlives.Location = new System.Drawing.Point(116, 44);
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Size = new System.Drawing.Size(67, 27);
            this.chkOlives.TabIndex = 3;
            this.chkOlives.Text = "Olives";
            this.chkOlives.UseVisualStyleBackColor = true;
            this.chkOlives.CheckedChanged += new System.EventHandler(this.chkOlives_CheckedChanged);
            // 
            // chkMushrooms
            // 
            this.chkMushrooms.AutoSize = true;
            this.chkMushrooms.Location = new System.Drawing.Point(7, 44);
            this.chkMushrooms.Name = "chkMushrooms";
            this.chkMushrooms.Size = new System.Drawing.Size(103, 27);
            this.chkMushrooms.TabIndex = 2;
            this.chkMushrooms.Text = "Mushrooms";
            this.chkMushrooms.UseVisualStyleBackColor = true;
            this.chkMushrooms.CheckedChanged += new System.EventHandler(this.chkMushrooms_CheckedChanged);
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.Location = new System.Drawing.Point(116, 21);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(68, 27);
            this.chkOnion.TabIndex = 1;
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = true;
            this.chkOnion.CheckedChanged += new System.EventHandler(this.chkOnion_CheckedChanged);
            // 
            // chkExtraCheese
            // 
            this.chkExtraCheese.AutoSize = true;
            this.chkExtraCheese.Location = new System.Drawing.Point(7, 21);
            this.chkExtraCheese.Name = "chkExtraCheese";
            this.chkExtraCheese.Size = new System.Drawing.Size(115, 27);
            this.chkExtraCheese.TabIndex = 0;
            this.chkExtraCheese.Text = "Extra Cheese";
            this.chkExtraCheese.UseVisualStyleBackColor = true;
            this.chkExtraCheese.CheckedChanged += new System.EventHandler(this.chkExtraCheese_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.btnOrderPizza);
            this.panel1.Controls.Add(this.btnResetForm);
            this.panel1.Controls.Add(this.gpOrderSummary);
            this.panel1.Controls.Add(this.gbWhereToEat);
            this.panel1.Controls.Add(this.labTheTitel);
            this.panel1.Controls.Add(this.gbCrustType);
            this.panel1.Controls.Add(this.gbToppings);
            this.panel1.Controls.Add(this.gbSize);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1006, 372);
            this.panel1.TabIndex = 5;
            // 
            // btnOrderPizza
            // 
            this.btnOrderPizza.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnOrderPizza.Location = new System.Drawing.Point(248, 325);
            this.btnOrderPizza.Name = "btnOrderPizza";
            this.btnOrderPizza.Size = new System.Drawing.Size(104, 36);
            this.btnOrderPizza.TabIndex = 8;
            this.btnOrderPizza.Text = "Order Pizza";
            this.btnOrderPizza.UseVisualStyleBackColor = true;
            this.btnOrderPizza.Click += new System.EventHandler(this.btnOrderPizza_Click);
            // 
            // btnResetForm
            // 
            this.btnResetForm.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnResetForm.Location = new System.Drawing.Point(453, 325);
            this.btnResetForm.Name = "btnResetForm";
            this.btnResetForm.Size = new System.Drawing.Size(104, 36);
            this.btnResetForm.TabIndex = 7;
            this.btnResetForm.Text = "Reset Form";
            this.btnResetForm.UseVisualStyleBackColor = true;
            this.btnResetForm.Click += new System.EventHandler(this.btnResetForm_Click);
            // 
            // gpOrderSummary
            // 
            this.gpOrderSummary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpOrderSummary.AutoSize = true;
            this.gpOrderSummary.Controls.Add(this.labFinalToppings);
            this.gpOrderSummary.Controls.Add(this.labTitleFinalToppings);
            this.gpOrderSummary.Controls.Add(this.labFinalSize);
            this.gpOrderSummary.Controls.Add(this.labTitleFinalSize);
            this.gpOrderSummary.Controls.Add(this.labFinalCrustType);
            this.gpOrderSummary.Controls.Add(this.labTitleFinalCrustType);
            this.gpOrderSummary.Controls.Add(this.labWhereToEat);
            this.gpOrderSummary.Controls.Add(this.labTitleWhereToEat);
            this.gpOrderSummary.Controls.Add(this.labTitleFinalSalary);
            this.gpOrderSummary.Controls.Add(this.labTotalSalary);
            this.gpOrderSummary.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gpOrderSummary.Location = new System.Drawing.Point(574, 66);
            this.gpOrderSummary.Name = "gpOrderSummary";
            this.gpOrderSummary.Size = new System.Drawing.Size(415, 288);
            this.gpOrderSummary.TabIndex = 6;
            this.gpOrderSummary.TabStop = false;
            this.gpOrderSummary.Text = "Order Summary";
            this.gpOrderSummary.Enter += new System.EventHandler(this.gpOrderSummary_Enter);
            // 
            // gbWhereToEat
            // 
            this.gbWhereToEat.Controls.Add(this.rbTakeOut);
            this.gbWhereToEat.Controls.Add(this.rbEatIn);
            this.gbWhereToEat.Location = new System.Drawing.Point(294, 244);
            this.gbWhereToEat.Name = "gbWhereToEat";
            this.gbWhereToEat.Size = new System.Drawing.Size(216, 52);
            this.gbWhereToEat.TabIndex = 5;
            this.gbWhereToEat.TabStop = false;
            this.gbWhereToEat.Text = "Where To Eat";
            this.gbWhereToEat.Enter += new System.EventHandler(this.gbWhereToEat_Enter);
            // 
            // rbTakeOut
            // 
            this.rbTakeOut.AutoSize = true;
            this.rbTakeOut.Location = new System.Drawing.Point(131, 20);
            this.rbTakeOut.Name = "rbTakeOut";
            this.rbTakeOut.Size = new System.Drawing.Size(67, 17);
            this.rbTakeOut.TabIndex = 1;
            this.rbTakeOut.TabStop = true;
            this.rbTakeOut.Text = "TakeOut";
            this.rbTakeOut.UseVisualStyleBackColor = true;
            this.rbTakeOut.CheckedChanged += new System.EventHandler(this.rbTakeOut_CheckedChanged);
            // 
            // rbEatIn
            // 
            this.rbEatIn.AutoSize = true;
            this.rbEatIn.Location = new System.Drawing.Point(29, 20);
            this.rbEatIn.Name = "rbEatIn";
            this.rbEatIn.Size = new System.Drawing.Size(53, 17);
            this.rbEatIn.TabIndex = 0;
            this.rbEatIn.TabStop = true;
            this.rbEatIn.Text = "Eat In";
            this.rbEatIn.UseVisualStyleBackColor = true;
            this.rbEatIn.CheckedChanged += new System.EventHandler(this.rbEatIn_CheckedChanged);
            // 
            // labTotalSalary
            // 
            this.labTotalSalary.AutoSize = true;
            this.labTotalSalary.Font = new System.Drawing.Font("Segoe UI Historic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTotalSalary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labTotalSalary.Location = new System.Drawing.Point(72, 235);
            this.labTotalSalary.Name = "labTotalSalary";
            this.labTotalSalary.Size = new System.Drawing.Size(49, 37);
            this.labTotalSalary.TabIndex = 0;
            this.labTotalSalary.Text = "$0";
            // 
            // labTitleFinalSalary
            // 
            this.labTitleFinalSalary.AutoSize = true;
            this.labTitleFinalSalary.Location = new System.Drawing.Point(20, 226);
            this.labTitleFinalSalary.Name = "labTitleFinalSalary";
            this.labTitleFinalSalary.Size = new System.Drawing.Size(61, 13);
            this.labTitleFinalSalary.TabIndex = 1;
            this.labTitleFinalSalary.Text = "Total Price:";
            // 
            // labTitleWhereToEat
            // 
            this.labTitleWhereToEat.AutoSize = true;
            this.labTitleWhereToEat.Location = new System.Drawing.Point(20, 178);
            this.labTitleWhereToEat.Name = "labTitleWhereToEat";
            this.labTitleWhereToEat.Size = new System.Drawing.Size(77, 13);
            this.labTitleWhereToEat.TabIndex = 2;
            this.labTitleWhereToEat.Text = "Where To Eat:";
            // 
            // labWhereToEat
            // 
            this.labWhereToEat.AutoSize = true;
            this.labWhereToEat.Location = new System.Drawing.Point(76, 201);
            this.labWhereToEat.Name = "labWhereToEat";
            this.labWhereToEat.Size = new System.Drawing.Size(0, 13);
            this.labWhereToEat.TabIndex = 3;
            // 
            // labTitleFinalCrustType
            // 
            this.labTitleFinalCrustType.AutoSize = true;
            this.labTitleFinalCrustType.Location = new System.Drawing.Point(20, 127);
            this.labTitleFinalCrustType.Name = "labTitleFinalCrustType";
            this.labTitleFinalCrustType.Size = new System.Drawing.Size(61, 13);
            this.labTitleFinalCrustType.TabIndex = 4;
            this.labTitleFinalCrustType.Text = "Crust Type:";
            // 
            // labFinalCrustType
            // 
            this.labFinalCrustType.AutoSize = true;
            this.labFinalCrustType.Location = new System.Drawing.Point(76, 156);
            this.labFinalCrustType.Name = "labFinalCrustType";
            this.labFinalCrustType.Size = new System.Drawing.Size(0, 13);
            this.labFinalCrustType.TabIndex = 5;
            // 
            // labTitleFinalSize
            // 
            this.labTitleFinalSize.AutoSize = true;
            this.labTitleFinalSize.Location = new System.Drawing.Point(20, 27);
            this.labTitleFinalSize.Name = "labTitleFinalSize";
            this.labTitleFinalSize.Size = new System.Drawing.Size(30, 13);
            this.labTitleFinalSize.TabIndex = 6;
            this.labTitleFinalSize.Text = "Size:";
            // 
            // labFinalSize
            // 
            this.labFinalSize.AutoSize = true;
            this.labFinalSize.Location = new System.Drawing.Point(76, 41);
            this.labFinalSize.Name = "labFinalSize";
            this.labFinalSize.Size = new System.Drawing.Size(0, 13);
            this.labFinalSize.TabIndex = 7;
            // 
            // labTitleFinalToppings
            // 
            this.labTitleFinalToppings.AutoSize = true;
            this.labTitleFinalToppings.Location = new System.Drawing.Point(20, 58);
            this.labTitleFinalToppings.Name = "labTitleFinalToppings";
            this.labTitleFinalToppings.Size = new System.Drawing.Size(54, 13);
            this.labTitleFinalToppings.TabIndex = 8;
            this.labTitleFinalToppings.Text = "Toppings:";
            // 
            // labFinalToppings
            // 
            this.labFinalToppings.AutoSize = true;
            this.labFinalToppings.Location = new System.Drawing.Point(76, 93);
            this.labFinalToppings.Name = "labFinalToppings";
            this.labFinalToppings.Size = new System.Drawing.Size(0, 13);
            this.labFinalToppings.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 372);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.gbCrustType.ResumeLayout(false);
            this.gbCrustType.PerformLayout();
            this.gbToppings.ResumeLayout(false);
            this.gbToppings.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gpOrderSummary.ResumeLayout(false);
            this.gpOrderSummary.PerformLayout();
            this.gbWhereToEat.ResumeLayout(false);
            this.gbWhereToEat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labTheTitel;
        private System.Windows.Forms.GroupBox gbSize;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RadioButton rbLarg;
        private System.Windows.Forms.RadioButton rbMeduim;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.GroupBox gbCrustType;
        private System.Windows.Forms.RadioButton rbThinkCrust;
        private System.Windows.Forms.RadioButton rbThinCrust;
        private System.Windows.Forms.GroupBox gbToppings;
        private System.Windows.Forms.CheckBox chkGreenPeppers;
        private System.Windows.Forms.CheckBox chkTomatoes;
        private System.Windows.Forms.CheckBox chkOlives;
        private System.Windows.Forms.CheckBox chkMushrooms;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.CheckBox chkExtraCheese;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbWhereToEat;
        private System.Windows.Forms.RadioButton rbTakeOut;
        private System.Windows.Forms.RadioButton rbEatIn;
        private System.Windows.Forms.GroupBox gpOrderSummary;
        private System.Windows.Forms.Button btnResetForm;
        private System.Windows.Forms.Button btnOrderPizza;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label labTotalSalary;
        private System.Windows.Forms.Label labTitleFinalSalary;
        private System.Windows.Forms.Label labWhereToEat;
        private System.Windows.Forms.Label labTitleWhereToEat;
        private System.Windows.Forms.Label labTitleFinalCrustType;
        private System.Windows.Forms.Label labFinalCrustType;
        private System.Windows.Forms.Label labFinalSize;
        private System.Windows.Forms.Label labTitleFinalSize;
        private System.Windows.Forms.Label labFinalToppings;
        private System.Windows.Forms.Label labTitleFinalToppings;
    }
}

