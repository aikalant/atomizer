using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Atomizer
{
    public class ElementViewBox : Panel
    {
        private Boolean locked = false;
        public Boolean Locked
        {
            get { return locked; }
            set
            {
                locked = value;
                if (locked)
                    LockIcon.Visible = true;
                else
                    LockIcon.Visible = false;
            }
        }

        private Element element;
        public Element Element
        {
            get
            {
                return element;
            }
        }

        private System.Windows.Forms.PictureBox LockIcon;
        private System.Windows.Forms.TextBox V7;
        private System.Windows.Forms.TextBox V6;
        private System.Windows.Forms.TextBox V5;
        private System.Windows.Forms.TextBox V4;
        private System.Windows.Forms.TextBox V3;
        private System.Windows.Forms.TextBox V2;
        private System.Windows.Forms.TextBox V1;
        private System.Windows.Forms.TextBox Data;
        private System.Windows.Forms.TextBox ElementName;
        private System.Windows.Forms.TextBox Symbol;
        private System.Windows.Forms.TextBox AtomicNumber;

        public ElementViewBox()
            : base()
        {
            this.SetStyle(ControlStyles.UserPaint, true);

            //this.ViewBox = new System.Windows.Forms.Panel();
            this.V1 = new System.Windows.Forms.TextBox();
            this.V2 = new System.Windows.Forms.TextBox();
            this.V3 = new System.Windows.Forms.TextBox();
            this.V4 = new System.Windows.Forms.TextBox();
            this.V5 = new System.Windows.Forms.TextBox();
            this.V6 = new System.Windows.Forms.TextBox();
            this.V7 = new System.Windows.Forms.TextBox();
            this.Data = new System.Windows.Forms.TextBox();
            this.ElementName = new System.Windows.Forms.TextBox();
            this.Symbol = new System.Windows.Forms.TextBox();
            this.AtomicNumber = new System.Windows.Forms.TextBox();
            this.LockIcon = new System.Windows.Forms.PictureBox();
            //((System.ComponentModel.ISupportInitialize)(this.LockIcon)).BeginInit();
            // 
            // ViewBox
            // 
            this.Controls.Add(this.V7);
            this.Controls.Add(this.V6);
            this.Controls.Add(this.V5);
            this.Controls.Add(this.V4);
            this.Controls.Add(this.V3);
            this.Controls.Add(this.V2);
            this.Controls.Add(this.V1);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.ElementName);
            this.Controls.Add(this.Symbol);
            this.Controls.Add(this.AtomicNumber);
            this.Controls.Add(this.LockIcon);
            this.Location = new System.Drawing.Point(12, 421);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ViewBox";
            this.Size = new System.Drawing.Size(180, 140);
            this.TabIndex = 0;
            // 
            // LockIcon
            // 
            this.LockIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LockIcon.Image = global::Atomizer.Properties.Resources.Lock_Icon;
            this.LockIcon.Location = new System.Drawing.Point(120, 0);
            this.LockIcon.Margin = new System.Windows.Forms.Padding(0);
            this.LockIcon.Name = "LockIcon";
            this.LockIcon.Size = new System.Drawing.Size(32, 32);
            this.LockIcon.TabIndex = 0;
            this.LockIcon.TabStop = false;
            this.LockIcon.Visible = false;
            this.LockIcon.MouseClick += delegate(Object sender, MouseEventArgs e)
            {
                locked = false;
                LockIcon.Visible = false;
            };
            // 
            // V7
            // 
            this.V7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.V7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V7.Location = new System.Drawing.Point(152, 120);
            this.V7.Margin = new System.Windows.Forms.Padding(0);
            this.V7.Name = "V7";
            this.V7.Size = new System.Drawing.Size(28, 20);
            this.V7.TabIndex = 0;
            this.V7.Text = "7";
            this.V7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.V7.BackColor = System.Drawing.SystemColors.Control;
            this.V7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.V7.ReadOnly = true;
            this.V7.TabStop = false;
            // 
            // V6
            // 
            this.V6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.V6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V6.Location = new System.Drawing.Point(152, 100);
            this.V6.Margin = new System.Windows.Forms.Padding(0);
            this.V6.Name = "V6";
            this.V6.Size = new System.Drawing.Size(28, 20);
            this.V6.TabIndex = 0;
            this.V6.Text = "18";
            this.V6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.V6.BackColor = System.Drawing.SystemColors.Control;
            this.V6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.V6.ReadOnly = true;
            this.V6.TabStop = false;
            // 
            // V5
            // 
            this.V5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.V5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V5.Location = new System.Drawing.Point(152, 80);
            this.V5.Margin = new System.Windows.Forms.Padding(0);
            this.V5.Name = "V5";
            this.V5.Size = new System.Drawing.Size(28, 20);
            this.V5.TabIndex = 0;
            this.V5.Text = "32";
            this.V5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.V5.BackColor = System.Drawing.SystemColors.Control;
            this.V5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.V5.ReadOnly = true;
            this.V5.TabStop = false;
            // 
            // V4
            // 
            this.V4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.V4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V4.Location = new System.Drawing.Point(152, 60);
            this.V4.Margin = new System.Windows.Forms.Padding(0);
            this.V4.Name = "V4";
            this.V4.Size = new System.Drawing.Size(28, 20);
            this.V4.TabIndex = 0;
            this.V4.Text = "32";
            this.V4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.V4.BackColor = System.Drawing.SystemColors.Control;
            this.V4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.V4.ReadOnly = true;
            this.V4.TabStop = false;
            // 
            // V3
            // 
            this.V3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.V3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V3.Location = new System.Drawing.Point(152, 40);
            this.V3.Margin = new System.Windows.Forms.Padding(0);
            this.V3.Name = "V3";
            this.V3.Size = new System.Drawing.Size(28, 20);
            this.V3.TabIndex = 0;
            this.V3.Text = "18";
            this.V3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.V3.BackColor = System.Drawing.SystemColors.Control;
            this.V3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.V3.ReadOnly = true;
            this.V3.TabStop = false;
            // 
            // V2
            // 
            this.V2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.V2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V2.Location = new System.Drawing.Point(152, 20);
            this.V2.Margin = new System.Windows.Forms.Padding(0);
            this.V2.Name = "V2";
            this.V2.Size = new System.Drawing.Size(28, 20);
            this.V2.TabIndex = 0;
            this.V2.Text = "8";
            this.V2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.V2.BackColor = System.Drawing.SystemColors.Control;
            this.V2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.V2.ReadOnly = true;
            this.V2.TabStop = false;
            // 
            // V1
            // 
            this.V1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.V1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V1.Location = new System.Drawing.Point(152, 0);
            this.V1.Margin = new System.Windows.Forms.Padding(0);
            this.V1.Name = "V1";
            this.V1.Size = new System.Drawing.Size(28, 20);
            this.V1.TabIndex = 0;
            this.V1.Text = "2";
            this.V1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.V1.BackColor = System.Drawing.SystemColors.Control;
            this.V1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.V1.ReadOnly = true;
            this.V1.TabStop = false;
            // 
            // Data
            // 
            this.Data.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Data.Location = new System.Drawing.Point(0, 113);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(152, 27);
            this.Data.TabIndex = 0;
            this.Data.Text = "18.994032";
            this.Data.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Data.BackColor = System.Drawing.SystemColors.Control;
            this.Data.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Data.ReadOnly = true;
            this.Data.TabStop = false;
            // 
            // Name
            // 
            this.ElementName.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ElementName.Location = new System.Drawing.Point(0, 86);
            this.ElementName.Name = "Name";
            this.ElementName.Size = new System.Drawing.Size(152, 27);
            this.ElementName.TabIndex = 0;
            this.ElementName.Text = "Rutherfordium";
            this.ElementName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ElementName.BackColor = System.Drawing.SystemColors.Control;
            this.ElementName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ElementName.ReadOnly = true;
            this.ElementName.TabStop = false;
            // 
            // Symbol
            // 
            this.Symbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 33F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Symbol.Location = new System.Drawing.Point(0, 36);
            this.Symbol.Name = "Symbol";
            this.Symbol.Size = new System.Drawing.Size(152, 50);
            this.Symbol.TabIndex = 0;
            this.Symbol.Text = "Uuo";
            this.Symbol.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Symbol.BackColor = System.Drawing.SystemColors.Control;
            this.Symbol.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Symbol.ReadOnly = true;
            this.Symbol.TabStop = false;
            // 
            // AtomicNumber
            // 
            this.AtomicNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AtomicNumber.Location = new System.Drawing.Point(0, 0);
            this.AtomicNumber.Name = "AtomicNumber";
            this.AtomicNumber.Size = new System.Drawing.Size(120, 36);
            this.AtomicNumber.TabIndex = 0;
            this.AtomicNumber.Text = "118";
            this.AtomicNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.AtomicNumber.BackColor = System.Drawing.SystemColors.Control;
            this.AtomicNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AtomicNumber.ReadOnly = true;
            this.AtomicNumber.TabStop = false;
        }

        public void SetElement(Element element)
        {
            this.element = element;
            this.Symbol.Text = element.Symbol;
            this.AtomicNumber.Text = element.AtomicNumber.ToString();
            this.ElementName.Text = element.Name;
            this.Data.Text = element.AtomicMass;
            disperseAtomicNumber();
            this.BackColor = ElementDatabase.GetNormalBackColor(element.GetType());

            this.Visible = true;
            this.Enabled = true;
        }
        public void ClearElement()
        {
            this.element = null;
            this.Enabled = false;
            this.Visible = false;
        }

        private void disperseAtomicNumber()
        {
            int num = element.AtomicNumber;
            disperse(V1, 2, ref num);
            disperse(V2, 8, ref num);
            disperse(V3, 18, ref num);
            disperse(V4, 32, ref num);
            disperse(V5, 32, ref num);
            disperse(V6, 18, ref num);
            disperse(V7, 8, ref num);
        }
        private void clearAtomicNumbers()
        {
            V1.Text = "";
            V2.Text = "";
            V3.Text = "";
            V4.Text = "";
            V5.Text = "";
            V6.Text = "";
            V7.Text = "";
        }
        private void disperse(TextBox control, int max, ref int num)
        {
            if (num >= max)
            {
                control.Text = max.ToString();
                num -= max;
            }
            else
            {
                control.Text = num.ToString();
                num = 0;
            }
        }

        protected override void OnBackColorChanged(EventArgs e)
        {
            base.OnBackColorChanged(e);

            this.Symbol.BackColor = BackColor;
            this.AtomicNumber.BackColor = BackColor;
            this.Data.BackColor = BackColor;
            this.ElementName.BackColor = BackColor;
            this.V1.BackColor = BackColor;
            this.V2.BackColor = BackColor;
            this.V3.BackColor = BackColor;
            this.V4.BackColor = BackColor;
            this.V5.BackColor = BackColor;
            this.V6.BackColor = BackColor;
            this.V7.BackColor = BackColor;
        }
    }
}
