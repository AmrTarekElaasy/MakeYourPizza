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
            this.labFinalToppings = new System.Windows.Forms.Label();
            this.btnOrderPizza = new System.Windows.Forms.Button();
            this.labTitleFinalToppings = new System.Windows.Forms.Label();
            this.btnResetForm = new System.Windows.Forms.Button();
            this.labFinalSize = new System.Windows.Forms.Label();
            this.labTitleFinalSize = new System.Windows.Forms.Label();
            this.labFinalCrustType = new System.Windows.Forms.Label();
            this.gbWhereToEat = new System.Windows.Forms.GroupBox();
            this.rbTakeOut = new System.Windows.Forms.RadioButton();
            this.rbEatIn = new System.Windows.Forms.RadioButton();
            this.labTitleFinalCrustType = new System.Windows.Forms.Label();
            this.labWhereToEat = new System.Windows.Forms.Label();
            this.labTitleWhereToEat = new System.Windows.Forms.Label();
            this.labTitleFinalSalary = new System.Windows.Forms.Label();
            this.labTotalSalary = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbSize.SuspendLayout();
            this.gbCrustType.SuspendLayout();
            this.gbToppings.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbWhereToEat.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labTheTitel
            // 
            this.labTheTitel.Font = new System.Drawing.Font("Segoe Print", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTheTitel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labTheTitel.Location = new System.Drawing.Point(349, 6);
            this.labTheTitel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labTheTitel.Name = "labTheTitel";
            this.labTheTitel.Size = new System.Drawing.Size(353, 63);
            this.labTheTitel.TabIndex = 0;
            this.labTheTitel.Text = "Make Your Pizza";
            // 
            // gbSize
            // 
            this.gbSize.Controls.Add(this.rbLarg);
            this.gbSize.Controls.Add(this.rbMeduim);
            this.gbSize.Controls.Add(this.rbSmall);
            this.gbSize.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSize.Location = new System.Drawing.Point(17, 89);
            this.gbSize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbSize.Name = "gbSize";
            this.gbSize.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbSize.Size = new System.Drawing.Size(137, 123);
            this.gbSize.TabIndex = 1;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Size";
            this.gbSize.Enter += new System.EventHandler(this.gbSize_Enter);
            // 
            // rbLarg
            // 
            this.rbLarg.AutoSize = true;
            this.rbLarg.Location = new System.Drawing.Point(28, 82);
            this.rbLarg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbLarg.Name = "rbLarg";
            this.rbLarg.Size = new System.Drawing.Size(74, 34);
            this.rbLarg.TabIndex = 2;
            this.rbLarg.Text = "Larg";
            this.rbLarg.UseVisualStyleBackColor = true;
            this.rbLarg.CheckedChanged += new System.EventHandler(this.rbLarg_CheckedChanged);
            // 
            // rbMeduim
            // 
            this.rbMeduim.AutoSize = true;
            this.rbMeduim.Location = new System.Drawing.Point(28, 54);
            this.rbMeduim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbMeduim.Name = "rbMeduim";
            this.rbMeduim.Size = new System.Drawing.Size(102, 34);
            this.rbMeduim.TabIndex = 1;
            this.rbMeduim.Text = "Meduim";
            this.rbMeduim.UseVisualStyleBackColor = true;
            this.rbMeduim.CheckedChanged += new System.EventHandler(this.rbMeduim_CheckedChanged);
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Location = new System.Drawing.Point(28, 26);
            this.rbSmall.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(82, 34);
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
            this.gbCrustType.Location = new System.Drawing.Point(17, 278);
            this.gbCrustType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbCrustType.Name = "gbCrustType";
            this.gbCrustType.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbCrustType.Size = new System.Drawing.Size(187, 87);
            this.gbCrustType.TabIndex = 3;
            this.gbCrustType.TabStop = false;
            this.gbCrustType.Text = "Crust Type";
            this.gbCrustType.Enter += new System.EventHandler(this.gbCrustType_Enter);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(28, 95);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(17, 16);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Visible = false;
            // 
            // rbThinkCrust
            // 
            this.rbThinkCrust.AutoSize = true;
            this.rbThinkCrust.Location = new System.Drawing.Point(28, 54);
            this.rbThinkCrust.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbThinkCrust.Name = "rbThinkCrust";
            this.rbThinkCrust.Size = new System.Drawing.Size(135, 34);
            this.rbThinkCrust.TabIndex = 1;
            this.rbThinkCrust.TabStop = true;
            this.rbThinkCrust.Text = "Think Crust";
            this.rbThinkCrust.UseVisualStyleBackColor = true;
            this.rbThinkCrust.CheckedChanged += new System.EventHandler(this.rbThinkCrust_CheckedChanged);
            // 
            // rbThinCrust
            // 
            this.rbThinCrust.AutoSize = true;
            this.rbThinCrust.Location = new System.Drawing.Point(28, 26);
            this.rbThinCrust.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbThinCrust.Name = "rbThinCrust";
            this.rbThinCrust.Size = new System.Drawing.Size(125, 34);
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
            this.gbToppings.Location = new System.Drawing.Point(361, 89);
            this.gbToppings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbToppings.Name = "gbToppings";
            this.gbToppings.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbToppings.Size = new System.Drawing.Size(328, 123);
            this.gbToppings.TabIndex = 4;
            this.gbToppings.TabStop = false;
            this.gbToppings.Text = "Toppings";
            this.gbToppings.Enter += new System.EventHandler(this.gbToppings_Enter);
            // 
            // chkGreenPeppers
            // 
            this.chkGreenPeppers.AutoSize = true;
            this.chkGreenPeppers.Location = new System.Drawing.Point(155, 82);
            this.chkGreenPeppers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkGreenPeppers.Name = "chkGreenPeppers";
            this.chkGreenPeppers.Size = new System.Drawing.Size(161, 34);
            this.chkGreenPeppers.TabIndex = 5;
            this.chkGreenPeppers.Text = "Green Peppers";
            this.chkGreenPeppers.UseVisualStyleBackColor = true;
            this.chkGreenPeppers.CheckedChanged += new System.EventHandler(this.chkGreenPeppers_CheckedChanged);
            // 
            // chkTomatoes
            // 
            this.chkTomatoes.AutoSize = true;
            this.chkTomatoes.Location = new System.Drawing.Point(9, 84);
            this.chkTomatoes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkTomatoes.Name = "chkTomatoes";
            this.chkTomatoes.Size = new System.Drawing.Size(117, 34);
            this.chkTomatoes.TabIndex = 4;
            this.chkTomatoes.Text = "Tomatoes";
            this.chkTomatoes.UseVisualStyleBackColor = true;
            this.chkTomatoes.CheckedChanged += new System.EventHandler(this.chkTomatoes_CheckedChanged);
            // 
            // chkOlives
            // 
            this.chkOlives.AutoSize = true;
            this.chkOlives.Location = new System.Drawing.Point(155, 54);
            this.chkOlives.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Size = new System.Drawing.Size(84, 34);
            this.chkOlives.TabIndex = 3;
            this.chkOlives.Text = "Olives";
            this.chkOlives.UseVisualStyleBackColor = true;
            this.chkOlives.CheckedChanged += new System.EventHandler(this.chkOlives_CheckedChanged);
            // 
            // chkMushrooms
            // 
            this.chkMushrooms.AutoSize = true;
            this.chkMushrooms.Location = new System.Drawing.Point(9, 54);
            this.chkMushrooms.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkMushrooms.Name = "chkMushrooms";
            this.chkMushrooms.Size = new System.Drawing.Size(132, 34);
            this.chkMushrooms.TabIndex = 2;
            this.chkMushrooms.Text = "Mushrooms";
            this.chkMushrooms.UseVisualStyleBackColor = true;
            this.chkMushrooms.CheckedChanged += new System.EventHandler(this.chkMushrooms_CheckedChanged);
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.Location = new System.Drawing.Point(155, 26);
            this.chkOnion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(86, 34);
            this.chkOnion.TabIndex = 1;
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = true;
            this.chkOnion.CheckedChanged += new System.EventHandler(this.chkOnion_CheckedChanged);
            // 
            // chkExtraCheese
            // 
            this.chkExtraCheese.AutoSize = true;
            this.chkExtraCheese.Location = new System.Drawing.Point(9, 26);
            this.chkExtraCheese.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkExtraCheese.Name = "chkExtraCheese";
            this.chkExtraCheese.Size = new System.Drawing.Size(147, 34);
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
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnOrderPizza);
            this.panel1.Controls.Add(this.btnResetForm);
            this.panel1.Controls.Add(this.gbWhereToEat);
            this.panel1.Controls.Add(this.labTheTitel);
            this.panel1.Controls.Add(this.gbCrustType);
            this.panel1.Controls.Add(this.gbToppings);
            this.panel1.Controls.Add(this.gbSize);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1051, 470);
            this.panel1.TabIndex = 5;
            // 
            // labFinalToppings
            // 
            this.labFinalToppings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labFinalToppings.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labFinalToppings.Location = new System.Drawing.Point(63, 108);
            this.labFinalToppings.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labFinalToppings.Name = "labFinalToppings";
            this.labFinalToppings.Size = new System.Drawing.Size(225, 89);
            this.labFinalToppings.TabIndex = 9;
            // 
            // btnOrderPizza
            // 
            this.btnOrderPizza.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnOrderPizza.Location = new System.Drawing.Point(319, 400);
            this.btnOrderPizza.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOrderPizza.Name = "btnOrderPizza";
            this.btnOrderPizza.Size = new System.Drawing.Size(139, 44);
            this.btnOrderPizza.TabIndex = 8;
            this.btnOrderPizza.Text = "Order Pizza";
            this.btnOrderPizza.UseVisualStyleBackColor = true;
            this.btnOrderPizza.Click += new System.EventHandler(this.btnOrderPizza_Click);
            // 
            // labTitleFinalToppings
            // 
            this.labTitleFinalToppings.AutoSize = true;
            this.labTitleFinalToppings.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitleFinalToppings.Location = new System.Drawing.Point(23, 77);
            this.labTitleFinalToppings.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labTitleFinalToppings.Name = "labTitleFinalToppings";
            this.labTitleFinalToppings.Size = new System.Drawing.Size(94, 30);
            this.labTitleFinalToppings.TabIndex = 8;
            this.labTitleFinalToppings.Text = "Toppings:";
            // 
            // btnResetForm
            // 
            this.btnResetForm.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnResetForm.Location = new System.Drawing.Point(592, 400);
            this.btnResetForm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnResetForm.Name = "btnResetForm";
            this.btnResetForm.Size = new System.Drawing.Size(139, 44);
            this.btnResetForm.TabIndex = 7;
            this.btnResetForm.Text = "Reset Form";
            this.btnResetForm.UseVisualStyleBackColor = true;
            this.btnResetForm.Click += new System.EventHandler(this.btnResetForm_Click);
            // 
            // labFinalSize
            // 
            this.labFinalSize.AutoSize = true;
            this.labFinalSize.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labFinalSize.Location = new System.Drawing.Point(63, 56);
            this.labFinalSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labFinalSize.Name = "labFinalSize";
            this.labFinalSize.Size = new System.Drawing.Size(0, 30);
            this.labFinalSize.TabIndex = 7;
            // 
            // labTitleFinalSize
            // 
            this.labTitleFinalSize.AutoSize = true;
            this.labTitleFinalSize.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitleFinalSize.Location = new System.Drawing.Point(23, 35);
            this.labTitleFinalSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labTitleFinalSize.Name = "labTitleFinalSize";
            this.labTitleFinalSize.Size = new System.Drawing.Size(52, 30);
            this.labTitleFinalSize.TabIndex = 6;
            this.labTitleFinalSize.Text = "Size:";
            // 
            // labFinalCrustType
            // 
            this.labFinalCrustType.AutoSize = true;
            this.labFinalCrustType.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labFinalCrustType.Location = new System.Drawing.Point(63, 229);
            this.labFinalCrustType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labFinalCrustType.Name = "labFinalCrustType";
            this.labFinalCrustType.Size = new System.Drawing.Size(0, 30);
            this.labFinalCrustType.TabIndex = 5;
            // 
            // gbWhereToEat
            // 
            this.gbWhereToEat.Controls.Add(this.rbTakeOut);
            this.gbWhereToEat.Controls.Add(this.rbEatIn);
            this.gbWhereToEat.Location = new System.Drawing.Point(381, 300);
            this.gbWhereToEat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbWhereToEat.Name = "gbWhereToEat";
            this.gbWhereToEat.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbWhereToEat.Size = new System.Drawing.Size(288, 64);
            this.gbWhereToEat.TabIndex = 5;
            this.gbWhereToEat.TabStop = false;
            this.gbWhereToEat.Text = "Where To Eat";
            this.gbWhereToEat.Enter += new System.EventHandler(this.gbWhereToEat_Enter);
            // 
            // rbTakeOut
            // 
            this.rbTakeOut.AutoSize = true;
            this.rbTakeOut.Location = new System.Drawing.Point(175, 25);
            this.rbTakeOut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbTakeOut.Name = "rbTakeOut";
            this.rbTakeOut.Size = new System.Drawing.Size(80, 20);
            this.rbTakeOut.TabIndex = 1;
            this.rbTakeOut.TabStop = true;
            this.rbTakeOut.Text = "TakeOut";
            this.rbTakeOut.UseVisualStyleBackColor = true;
            this.rbTakeOut.CheckedChanged += new System.EventHandler(this.rbTakeOut_CheckedChanged);
            // 
            // rbEatIn
            // 
            this.rbEatIn.AutoSize = true;
            this.rbEatIn.Location = new System.Drawing.Point(39, 25);
            this.rbEatIn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbEatIn.Name = "rbEatIn";
            this.rbEatIn.Size = new System.Drawing.Size(61, 20);
            this.rbEatIn.TabIndex = 0;
            this.rbEatIn.TabStop = true;
            this.rbEatIn.Text = "Eat In";
            this.rbEatIn.UseVisualStyleBackColor = true;
            this.rbEatIn.CheckedChanged += new System.EventHandler(this.rbEatIn_CheckedChanged);
            // 
            // labTitleFinalCrustType
            // 
            this.labTitleFinalCrustType.AutoSize = true;
            this.labTitleFinalCrustType.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitleFinalCrustType.Location = new System.Drawing.Point(23, 197);
            this.labTitleFinalCrustType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labTitleFinalCrustType.Name = "labTitleFinalCrustType";
            this.labTitleFinalCrustType.Size = new System.Drawing.Size(112, 30);
            this.labTitleFinalCrustType.TabIndex = 4;
            this.labTitleFinalCrustType.Text = "Crust Type:";
            // 
            // labWhereToEat
            // 
            this.labWhereToEat.AutoSize = true;
            this.labWhereToEat.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labWhereToEat.Location = new System.Drawing.Point(63, 289);
            this.labWhereToEat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labWhereToEat.Name = "labWhereToEat";
            this.labWhereToEat.Size = new System.Drawing.Size(0, 30);
            this.labWhereToEat.TabIndex = 3;
            // 
            // labTitleWhereToEat
            // 
            this.labTitleWhereToEat.AutoSize = true;
            this.labTitleWhereToEat.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitleWhereToEat.Location = new System.Drawing.Point(23, 260);
            this.labTitleWhereToEat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labTitleWhereToEat.Name = "labTitleWhereToEat";
            this.labTitleWhereToEat.Size = new System.Drawing.Size(138, 30);
            this.labTitleWhereToEat.TabIndex = 2;
            this.labTitleWhereToEat.Text = "Where To Eat:";
            // 
            // labTitleFinalSalary
            // 
            this.labTitleFinalSalary.AutoSize = true;
            this.labTitleFinalSalary.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitleFinalSalary.Location = new System.Drawing.Point(23, 319);
            this.labTitleFinalSalary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labTitleFinalSalary.Name = "labTitleFinalSalary";
            this.labTitleFinalSalary.Size = new System.Drawing.Size(113, 30);
            this.labTitleFinalSalary.TabIndex = 1;
            this.labTitleFinalSalary.Text = "Total Price:";
            // 
            // labTotalSalary
            // 
            this.labTotalSalary.AutoSize = true;
            this.labTotalSalary.Font = new System.Drawing.Font("Segoe UI Historic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTotalSalary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labTotalSalary.Location = new System.Drawing.Point(58, 348);
            this.labTotalSalary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labTotalSalary.Name = "labTotalSalary";
            this.labTotalSalary.Size = new System.Drawing.Size(58, 46);
            this.labTotalSalary.TabIndex = 0;
            this.labTotalSalary.Text = "$0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labTitleFinalSize);
            this.groupBox1.Controls.Add(this.labFinalToppings);
            this.groupBox1.Controls.Add(this.labTotalSalary);
            this.groupBox1.Controls.Add(this.labTitleFinalSalary);
            this.groupBox1.Controls.Add(this.labTitleFinalToppings);
            this.groupBox1.Controls.Add(this.labTitleWhereToEat);
            this.groupBox1.Controls.Add(this.labWhereToEat);
            this.groupBox1.Controls.Add(this.labFinalSize);
            this.groupBox1.Controls.Add(this.labTitleFinalCrustType);
            this.groupBox1.Controls.Add(this.labFinalCrustType);
            this.groupBox1.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(751, 46);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(296, 398);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Summary";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 470);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Make Your Pizza";
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.gbCrustType.ResumeLayout(false);
            this.gbCrustType.PerformLayout();
            this.gbToppings.ResumeLayout(false);
            this.gbToppings.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.gbWhereToEat.ResumeLayout(false);
            this.gbWhereToEat.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

