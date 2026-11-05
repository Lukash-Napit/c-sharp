namespace MyCalculatorApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblFirst = new System.Windows.Forms.Label();
            this.lblSecond = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.txtSecond = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnModulo = new System.Windows.Forms.Button();
            this.btnPower = new System.Windows.Forms.Button();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClearHistory = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lstHistory = new System.Windows.Forms.ListBox();
            this.SuspendLayout();

            // Labels & TextBoxes
            this.lblFirst.AutoSize = true;
            this.lblFirst.Location = new System.Drawing.Point(20, 23);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(75, 20);
            this.lblFirst.Text = "Number 1:";

            this.txtFirst.Location = new System.Drawing.Point(100, 20);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(125, 27);

            this.lblSecond.AutoSize = true;
            this.lblSecond.Location = new System.Drawing.Point(260, 23);
            this.lblSecond.Name = "lblSecond";
            this.lblSecond.Size = new System.Drawing.Size(75, 20);
            this.lblSecond.Text = "Number 2:";

            this.txtSecond.Location = new System.Drawing.Point(340, 20);
            this.txtSecond.Name = "txtSecond";
            this.txtSecond.Size = new System.Drawing.Size(125, 27);

            // Math Buttons
            this.btnAdd.Location = new System.Drawing.Point(20, 65);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(50, 35);
            this.btnAdd.Text = "+";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            this.btnSubtract.Location = new System.Drawing.Point(75, 65);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(50, 35);
            this.btnSubtract.Text = "-";
            this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click);

            this.btnMultiply.Location = new System.Drawing.Point(130, 65);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(50, 35);
            this.btnMultiply.Text = "*";
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);

            this.btnDivide.Location = new System.Drawing.Point(185, 65);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(50, 35);
            this.btnDivide.Text = "/";
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);

            this.btnModulo.Location = new System.Drawing.Point(240, 65);
            this.btnModulo.Name = "btnModulo";
            this.btnModulo.Size = new System.Drawing.Size(50, 35);
            this.btnModulo.Text = "%";
            this.btnModulo.Click += new System.EventHandler(this.btnModulo_Click);

            this.btnPower.Location = new System.Drawing.Point(295, 65);
            this.btnPower.Name = "btnPower";
            this.btnPower.Size = new System.Drawing.Size(65, 35);
            this.btnPower.Text = "Power";
            this.btnPower.Click += new System.EventHandler(this.btnPower_Click);

            this.btnSqrt.Location = new System.Drawing.Point(365, 65);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(60, 35);
            this.btnSqrt.Text = "Sqrt";
            this.btnSqrt.Click += new System.EventHandler(this.btnSqrt_Click);

            this.btnMin.Location = new System.Drawing.Point(430, 65);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(50, 35);
            this.btnMin.Text = "Min";
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);

            this.btnMax.Location = new System.Drawing.Point(485, 65);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(50, 35);
            this.btnMax.Text = "Max";
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);

            // ListBox History
            this.lstHistory.ItemHeight = 20;
            this.lstHistory.Location = new System.Drawing.Point(20, 110);
            this.lstHistory.Name = "lstHistory";
            this.lstHistory.Size = new System.Drawing.Size(600, 244);

            // Bottom Buttons & Result Box
            this.btnClearHistory.Location = new System.Drawing.Point(20, 375);
            this.btnClearHistory.Name = "btnClearHistory";
            this.btnClearHistory.Size = new System.Drawing.Size(120, 35);
            this.btnClearHistory.Text = "Clear History";
            this.btnClearHistory.Click += new System.EventHandler(this.btnClearHistory_Click);

            this.btnClear.Location = new System.Drawing.Point(150, 375);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 35);
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            this.btnExit.Location = new System.Drawing.Point(240, 375);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 35);
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);

            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(340, 382);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(52, 20);
            this.lblResult.Text = "Result:";

            this.txtResult.Location = new System.Drawing.Point(400, 379);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(220, 27);

            // Form Setup
            this.ClientSize = new System.Drawing.Size(650, 430);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnClearHistory);
            this.Controls.Add(this.lstHistory);
            this.Controls.Add(this.btnMax);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnSqrt);
            this.Controls.Add(this.btnPower);
            this.Controls.Add(this.btnModulo);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtSecond);
            this.Controls.Add(this.lblSecond);
            this.Controls.Add(this.txtFirst);
            this.Controls.Add(this.lblFirst);
            this.Name = "Form1";
            this.Text = "My Personal Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.Label lblSecond;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.TextBox txtSecond;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnModulo;
        private System.Windows.Forms.Button btnPower;
        private System.Windows.Forms.Button btnSqrt;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClearHistory;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox lstHistory;
    }
}