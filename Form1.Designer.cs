
namespace CS311_Project3_MLC
{
    partial class PizzaPlace
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            Console.WriteLine("Dispose");
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Console.WriteLine("InitializeComponent");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PizzaPlace));
            lblTitle = new Label();
            pictPizza = new PictureBox();
            cboSize = new ComboBox();
            lblSize = new Label();
            grpCrustType = new GroupBox();
            rdoGlutenFree = new RadioButton();
            rdoRegular = new RadioButton();
            rdoThick = new RadioButton();
            rdoThin = new RadioButton();
            ckbSpicyItalianSausage = new CheckBox();
            ckbOnion = new CheckBox();
            ckbGreenPepper = new CheckBox();
            ckbBlackOlives = new CheckBox();
            ckbGreenOlives = new CheckBox();
            ckbBananaPeppers = new CheckBox();
            ckbJalepeno = new CheckBox();
            ckbExtraCheese = new CheckBox();
            ckbMushroom = new CheckBox();
            lblToppings = new Label();
            rtfOrderSummary = new RichTextBox();
            lblOrderSummary = new Label();
            ckbPepperoni = new CheckBox();
            ckbSausage = new CheckBox();
            ckbCanadianBacon = new CheckBox();
            txtSubtotal = new TextBox();
            lblSubtotal = new Label();
            lblTax = new Label();
            txtTax = new TextBox();
            lblTotal = new Label();
            txtTotal = new TextBox();
            btnCalculate = new Button();
            btnClear = new Button();
            pictPizza2 = new PictureBox();
            pictPizza1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictPizza).BeginInit();
            Console.WriteLine("beforeSuspend");
            grpCrustType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictPizza2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictPizza1).BeginInit();
            SuspendLayout();
            Console.WriteLine("afterSuspend");
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Palatino Linotype", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(192, 0, 0);
            lblTitle.Location = new Point(162, 22);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(494, 80);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Megan's Pizzeria";
            lblTitle.Click += label1_Click;
            // 
            // pictPizza
            // 
            pictPizza.Image = (Image)resources.GetObject("pictPizza.Image");
            pictPizza.Location = new Point(77, 105);
            pictPizza.Name = "pictPizza";
            pictPizza.Size = new Size(0, 0);
            pictPizza.TabIndex = 1;
            pictPizza.TabStop = false;
            // 
            // cboSize
            // 
            cboSize.Font = new Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboSize.FormattingEnabled = true;
            cboSize.Items.AddRange(new object[] { "Small", "Medium", "Large", "X-Large", "Ginormous" });
            cboSize.Location = new Point(128, 122);
            cboSize.Name = "cboSize";
            cboSize.Size = new Size(140, 29);
            cboSize.TabIndex = 2;
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.Font = new Font("Cambria", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSize.Location = new Point(24, 125);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(98, 21);
            lblSize.TabIndex = 3;
            lblSize.Text = "Pizza Size:";
            // 
            // grpCrustType
            // 
            grpCrustType.Controls.Add(rdoGlutenFree);
            grpCrustType.Controls.Add(rdoRegular);
            grpCrustType.Controls.Add(rdoThick);
            grpCrustType.Controls.Add(rdoThin);
            grpCrustType.Font = new Font("Cambria", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpCrustType.Location = new Point(292, 122);
            grpCrustType.Name = "grpCrustType";
            grpCrustType.Size = new Size(593, 46);
            grpCrustType.TabIndex = 4;
            grpCrustType.TabStop = false;
            grpCrustType.Text = "Crust Type:";
            // 
            // rdoGlutenFree
            // 
            rdoGlutenFree.AutoSize = true;
            rdoGlutenFree.Font = new Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdoGlutenFree.Location = new Point(373, 15);
            rdoGlutenFree.Name = "rdoGlutenFree";
            rdoGlutenFree.Size = new Size(121, 25);
            rdoGlutenFree.TabIndex = 3;
            rdoGlutenFree.TabStop = true;
            rdoGlutenFree.Text = "Gluten Free";
            rdoGlutenFree.UseVisualStyleBackColor = true;
            // 
            // rdoRegular
            // 
            rdoRegular.AutoSize = true;
            rdoRegular.Font = new Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdoRegular.Location = new Point(276, 15);
            rdoRegular.Name = "rdoRegular";
            rdoRegular.Size = new Size(91, 25);
            rdoRegular.TabIndex = 2;
            rdoRegular.TabStop = true;
            rdoRegular.Text = "Regular";
            rdoRegular.UseVisualStyleBackColor = true;
            // 
            // rdoThick
            // 
            rdoThick.AutoSize = true;
            rdoThick.Font = new Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdoThick.Location = new Point(196, 15);
            rdoThick.Name = "rdoThick";
            rdoThick.Size = new Size(74, 25);
            rdoThick.TabIndex = 1;
            rdoThick.TabStop = true;
            rdoThick.Text = "Thick";
            rdoThick.UseVisualStyleBackColor = true;
            // 
            // rdoThin
            // 
            rdoThin.AutoSize = true;
            rdoThin.Font = new Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdoThin.Location = new Point(123, 15);
            rdoThin.Name = "rdoThin";
            rdoThin.Size = new Size(67, 25);
            rdoThin.TabIndex = 0;
            rdoThin.TabStop = true;
            rdoThin.Text = "Thin";
            rdoThin.UseVisualStyleBackColor = true;
            // 
            // ckbSpicyItalianSausage
            // 
            ckbSpicyItalianSausage.AutoSize = true;
            ckbSpicyItalianSausage.Font = new Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ckbSpicyItalianSausage.Location = new Point(49, 284);
            ckbSpicyItalianSausage.Name = "ckbSpicyItalianSausage";
            ckbSpicyItalianSausage.Size = new Size(194, 25);
            ckbSpicyItalianSausage.TabIndex = 8;
            ckbSpicyItalianSausage.Text = "Spicy Italian Sausage";
            ckbSpicyItalianSausage.UseVisualStyleBackColor = true;
            // 
            // ckbOnion
            // 
            ckbOnion.AutoSize = true;
            ckbOnion.Font = new Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ckbOnion.Location = new Point(301, 191);
            ckbOnion.Name = "ckbOnion";
            ckbOnion.Size = new Size(79, 25);
            ckbOnion.TabIndex = 9;
            ckbOnion.Text = "Onion";
            ckbOnion.UseVisualStyleBackColor = true;
            // 
            // ckbGreenPepper
            // 
            ckbGreenPepper.AutoSize = true;
            ckbGreenPepper.Font = new Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ckbGreenPepper.Location = new Point(301, 222);
            ckbGreenPepper.Name = "ckbGreenPepper";
            ckbGreenPepper.Size = new Size(137, 25);
            ckbGreenPepper.TabIndex = 10;
            ckbGreenPepper.Text = "Green Pepper";
            ckbGreenPepper.UseVisualStyleBackColor = true;
            // 
            // ckbBlackOlives
            // 
            ckbBlackOlives.AutoSize = true;
            ckbBlackOlives.Font = new Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ckbBlackOlives.Location = new Point(301, 253);
            ckbBlackOlives.Name = "ckbBlackOlives";
            ckbBlackOlives.Size = new Size(126, 25);
            ckbBlackOlives.TabIndex = 11;
            ckbBlackOlives.Text = "Black Olives";
            ckbBlackOlives.UseVisualStyleBackColor = true;
            // 
            // ckbGreenOlives
            // 
            ckbGreenOlives.AutoSize = true;
            ckbGreenOlives.Font = new Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ckbGreenOlives.Location = new Point(301, 284);
            ckbGreenOlives.Name = "ckbGreenOlives";
            ckbGreenOlives.Size = new Size(130, 25);
            ckbGreenOlives.TabIndex = 12;
            ckbGreenOlives.Text = "Green Olives";
            ckbGreenOlives.UseVisualStyleBackColor = true;
            // 
            // ckbBananaPeppers
            // 
            ckbBananaPeppers.AutoSize = true;
            ckbBananaPeppers.Font = new Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ckbBananaPeppers.Location = new Point(492, 191);
            ckbBananaPeppers.Name = "ckbBananaPeppers";
            ckbBananaPeppers.Size = new Size(157, 25);
            ckbBananaPeppers.TabIndex = 13;
            ckbBananaPeppers.Text = "Banana Peppers";
            ckbBananaPeppers.UseVisualStyleBackColor = true;
            // 
            // ckbJalepeno
            // 
            ckbJalepeno.AutoSize = true;
            ckbJalepeno.Font = new Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ckbJalepeno.Location = new Point(492, 222);
            ckbJalepeno.Name = "ckbJalepeno";
            ckbJalepeno.Size = new Size(100, 25);
            ckbJalepeno.TabIndex = 14;
            ckbJalepeno.Text = "Jalepeno";
            ckbJalepeno.UseVisualStyleBackColor = true;
            // 
            // ckbExtraCheese
            // 
            ckbExtraCheese.AutoSize = true;
            ckbExtraCheese.Font = new Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ckbExtraCheese.Location = new Point(492, 253);
            ckbExtraCheese.Name = "ckbExtraCheese";
            ckbExtraCheese.Size = new Size(132, 25);
            ckbExtraCheese.TabIndex = 15;
            ckbExtraCheese.Text = "Extra Cheese";
            ckbExtraCheese.UseVisualStyleBackColor = true;
            // 
            // ckbMushroom
            // 
            ckbMushroom.AutoSize = true;
            ckbMushroom.Font = new Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ckbMushroom.Location = new Point(492, 284);
            ckbMushroom.Name = "ckbMushroom";
            ckbMushroom.Size = new Size(117, 25);
            ckbMushroom.TabIndex = 16;
            ckbMushroom.Text = "Mushroom";
            ckbMushroom.UseVisualStyleBackColor = true;
            // 
            // lblToppings
            // 
            lblToppings.AutoSize = true;
            lblToppings.Font = new Font("Cambria", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblToppings.Location = new Point(24, 167);
            lblToppings.Name = "lblToppings";
            lblToppings.Size = new Size(91, 21);
            lblToppings.TabIndex = 17;
            lblToppings.Text = "Toppings:";
            // 
            // rtfOrderSummary
            // 
            rtfOrderSummary.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtfOrderSummary.Location = new Point(49, 346);
            rtfOrderSummary.Name = "rtfOrderSummary";
            rtfOrderSummary.Size = new Size(619, 167);
            rtfOrderSummary.TabIndex = 18;
            rtfOrderSummary.Text = "";
            // 
            // lblOrderSummary
            // 
            lblOrderSummary.AutoSize = true;
            lblOrderSummary.Font = new Font("Cambria", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOrderSummary.Location = new Point(17, 322);
            lblOrderSummary.Name = "lblOrderSummary";
            lblOrderSummary.Size = new Size(149, 21);
            lblOrderSummary.TabIndex = 19;
            lblOrderSummary.Text = "Order Summary:";
            // 
            // ckbPepperoni
            // 
            ckbPepperoni.AutoSize = true;
            ckbPepperoni.Font = new Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ckbPepperoni.Location = new Point(49, 191);
            ckbPepperoni.Name = "ckbPepperoni";
            ckbPepperoni.Size = new Size(112, 25);
            ckbPepperoni.TabIndex = 5;
            ckbPepperoni.Text = "Pepperoni";
            ckbPepperoni.UseVisualStyleBackColor = true;
            // 
            // ckbSausage
            // 
            ckbSausage.AutoSize = true;
            ckbSausage.Font = new Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ckbSausage.Location = new Point(49, 222);
            ckbSausage.Name = "ckbSausage";
            ckbSausage.Size = new Size(95, 25);
            ckbSausage.TabIndex = 6;
            ckbSausage.Text = "Sausage";
            ckbSausage.UseVisualStyleBackColor = true;
            // 
            // ckbCanadianBacon
            // 
            ckbCanadianBacon.AutoSize = true;
            ckbCanadianBacon.Font = new Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ckbCanadianBacon.Location = new Point(49, 253);
            ckbCanadianBacon.Name = "ckbCanadianBacon";
            ckbCanadianBacon.Size = new Size(156, 25);
            ckbCanadianBacon.TabIndex = 7;
            ckbCanadianBacon.Text = "Canadian Bacon";
            ckbCanadianBacon.UseVisualStyleBackColor = true;
            // 
            // txtSubtotal
            // 
            txtSubtotal.Font = new Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSubtotal.Location = new Point(809, 401);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.Size = new Size(188, 29);
            txtSubtotal.TabIndex = 20;
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Font = new Font("Cambria", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubtotal.Location = new Point(702, 409);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(93, 21);
            lblSubtotal.TabIndex = 21;
            lblSubtotal.Text = "Sub Total:";
            // 
            // lblTax
            // 
            lblTax.AutoSize = true;
            lblTax.Font = new Font("Cambria", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTax.Location = new Point(704, 440);
            lblTax.Name = "lblTax";
            lblTax.Size = new Size(45, 21);
            lblTax.TabIndex = 22;
            lblTax.Text = "Tax:";
            // 
            // txtTax
            // 
            txtTax.Font = new Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTax.Location = new Point(809, 436);
            txtTax.Name = "txtTax";
            txtTax.Size = new Size(188, 29);
            txtTax.TabIndex = 23;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Cambria", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(704, 471);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(58, 21);
            lblTotal.TabIndex = 24;
            lblTotal.Text = "Total:";
            // 
            // txtTotal
            // 
            txtTotal.Font = new Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTotal.Location = new Point(809, 471);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(188, 29);
            txtTotal.TabIndex = 25;
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Cambria", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalculate.Location = new Point(722, 339);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(114, 35);
            btnCalculate.TabIndex = 26;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Cambria", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(870, 339);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(127, 35);
            btnClear.TabIndex = 27;
            btnClear.Text = "Restart";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // pictPizza2
            // 
            pictPizza2.Image = (Image)resources.GetObject("pictPizza2.Image");
            pictPizza2.Location = new Point(662, 20);
            pictPizza2.Name = "pictPizza2";
            pictPizza2.Size = new Size(133, 82);
            pictPizza2.TabIndex = 28;
            pictPizza2.TabStop = false;
            // 
            // pictPizza1
            // 
            pictPizza1.Image = (Image)resources.GetObject("pictPizza1.Image");
            pictPizza1.Location = new Point(29, 22);
            pictPizza1.Name = "pictPizza1";
            pictPizza1.Size = new Size(132, 83);
            pictPizza1.TabIndex = 29;
            pictPizza1.TabStop = false;
            // 
            // PizzaPlace
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1046, 537);
            Controls.Add(pictPizza1);
            Controls.Add(pictPizza2);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Controls.Add(txtTotal);
            Controls.Add(lblTotal);
            Controls.Add(txtTax);
            Controls.Add(lblTax);
            Controls.Add(lblSubtotal);
            Controls.Add(txtSubtotal);
            Controls.Add(lblOrderSummary);
            Controls.Add(rtfOrderSummary);
            Controls.Add(lblToppings);
            Controls.Add(ckbMushroom);
            Controls.Add(ckbExtraCheese);
            Controls.Add(ckbJalepeno);
            Controls.Add(ckbBananaPeppers);
            Controls.Add(ckbGreenOlives);
            Controls.Add(ckbBlackOlives);
            Controls.Add(ckbGreenPepper);
            Controls.Add(ckbOnion);
            Controls.Add(ckbSpicyItalianSausage);
            Controls.Add(ckbCanadianBacon);
            Controls.Add(ckbSausage);
            Controls.Add(ckbPepperoni);
            Controls.Add(grpCrustType);
            Controls.Add(lblSize);
            Controls.Add(cboSize);
            Controls.Add(pictPizza);
            Controls.Add(lblTitle);
            Name = "PizzaPlace";
            Text = "Megan's Pizzeria";
            //Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictPizza).EndInit();
            grpCrustType.ResumeLayout(false);
            grpCrustType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictPizza2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictPizza1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Form1_Load");
            throw new NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("label1_Click");
            throw new NotImplementedException();
        }

        #endregion

        private Label lblTitle;
        private PictureBox pictPizza;
        private ComboBox cboSize;
        private Label lblSize;
        private GroupBox grpCrustType;
        private RadioButton rdoGlutenFree;
        private RadioButton rdoRegular;
        private RadioButton rdoThick;
        private RadioButton rdoThin;
        private CheckBox ckbPepperoni;
        private CheckBox ckbSausage;
        private CheckBox ckbCanadianBacon;
        private CheckBox ckbSpicyItalianSausage;
        private CheckBox ckbOnion;
        private CheckBox ckbGreenPepper;
        private CheckBox ckbBlackOlives;
        private CheckBox ckbGreenOlives;
        private CheckBox ckbBananaPeppers;
        private CheckBox ckbJalepeno;
        private CheckBox ckbExtraCheese;
        private CheckBox ckbMushroom;
        private Label lblToppings;
        private RichTextBox rtfOrderSummary;
        private Label lblOrderSummary;
        private TextBox txtSubtotal;
        private Label lblSubtotal;
        private Label lblTax;
        private TextBox txtTax;
        private Label lblTotal;
        private TextBox txtTotal;
        private Button btnCalculate;
        private Button btnClear;
        private PictureBox pictPizza2;
        private PictureBox pictPizza1;
    }
}
