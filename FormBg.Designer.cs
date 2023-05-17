namespace Calculator
{
    partial class FormBg
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBg));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonMinimize = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButtonClose = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.CustomizableEdges = customizableEdges1;
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 12);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            this.guna2Panel1.Size = new System.Drawing.Size(254, 433);
            this.guna2Panel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.buttonMinimize);
            this.panel1.Controls.Add(this.guna2ImageButtonClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.panel1.Size = new System.Drawing.Size(254, 12);
            this.panel1.TabIndex = 1;
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.AnimatedGIF = true;
            this.buttonMinimize.BackColor = System.Drawing.Color.Transparent;
            this.buttonMinimize.CheckedState.Image = global::Calculator_Suva.Properties.Resources.rsz_image_removebg_preview;
            this.buttonMinimize.CheckedState.ImageSize = new System.Drawing.Size(10, 10);
            this.buttonMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonMinimize.HoverState.Image = global::Calculator_Suva.Properties.Resources.mac_mini1;
            this.buttonMinimize.HoverState.ImageSize = new System.Drawing.Size(12, 12);
            this.buttonMinimize.Image = global::Calculator_Suva.Properties.Resources.mini;
            this.buttonMinimize.ImageOffset = new System.Drawing.Point(0, 0);
            this.buttonMinimize.ImageRotate = 0F;
            this.buttonMinimize.ImageSize = new System.Drawing.Size(10, 10);
            this.buttonMinimize.Location = new System.Drawing.Point(216, 0);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.PressedState.Image = global::Calculator_Suva.Properties.Resources.mini;
            this.buttonMinimize.PressedState.ImageSize = new System.Drawing.Size(10, 10);
            this.buttonMinimize.ShadowDecoration.CustomizableEdges = customizableEdges3;
            this.buttonMinimize.Size = new System.Drawing.Size(13, 12);
            this.buttonMinimize.TabIndex = 1;
            this.toolTip1.SetToolTip(this.buttonMinimize, "Minimize");
            this.buttonMinimize.UseTransparentBackground = true;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // guna2ImageButtonClose
            // 
            this.guna2ImageButtonClose.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButtonClose.CheckedState.Image = global::Calculator_Suva.Properties.Resources.macClose;
            this.guna2ImageButtonClose.CheckedState.ImageSize = new System.Drawing.Size(10, 10);
            this.guna2ImageButtonClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2ImageButtonClose.HoverState.Image = global::Calculator_Suva.Properties.Resources.mac_close1;
            this.guna2ImageButtonClose.HoverState.ImageSize = new System.Drawing.Size(12, 12);
            this.guna2ImageButtonClose.Image = global::Calculator_Suva.Properties.Resources.macClose;
            this.guna2ImageButtonClose.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButtonClose.ImageRotate = 0F;
            this.guna2ImageButtonClose.ImageSize = new System.Drawing.Size(10, 10);
            this.guna2ImageButtonClose.Location = new System.Drawing.Point(229, 0);
            this.guna2ImageButtonClose.Name = "guna2ImageButtonClose";
            this.guna2ImageButtonClose.PressedState.Image = global::Calculator_Suva.Properties.Resources.macClose;
            this.guna2ImageButtonClose.PressedState.ImageSize = new System.Drawing.Size(10, 10);
            this.guna2ImageButtonClose.ShadowDecoration.CustomizableEdges = customizableEdges4;
            this.guna2ImageButtonClose.Size = new System.Drawing.Size(13, 12);
            this.guna2ImageButtonClose.TabIndex = 0;
            this.toolTip1.SetToolTip(this.guna2ImageButtonClose, "Close");
            this.guna2ImageButtonClose.UseTransparentBackground = true;
            this.guna2ImageButtonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 40;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.panel1;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // FormBg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 445);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormBg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBg";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButtonClose;
        private Guna.UI2.WinForms.Guna2ImageButton buttonMinimize;
        private ToolTip toolTip1;
    }
}