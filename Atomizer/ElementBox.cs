using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Atomizer
{
    public class ElementBox : BorderedPanel, Activatable
    {
        private Element element;
        public Element Element
        {
            get
            {
                return element;
            }
        }

        private System.Windows.Forms.TextBox Symbol;
        private System.Windows.Forms.TextBox AtomicNumber;

        private bool activated = false;

        public ElementBox()
            : base()
        {
            this.SetStyle(ControlStyles.UserPaint, true);

            this.Margin = new System.Windows.Forms.Padding(0);
            this.Size = new System.Drawing.Size(40, 40);
            this.TabIndex = 0;
            this.MouseDown += ViewLocker;

            this.Symbol = new System.Windows.Forms.TextBox();
            this.AtomicNumber = new System.Windows.Forms.TextBox();
            this.Controls.Add(this.Symbol);
            this.Controls.Add(this.AtomicNumber);



            this.Symbol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Symbol.BackColor = System.Drawing.SystemColors.Control;
            this.Symbol.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Symbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Symbol.Location = new System.Drawing.Point(5, 7);
            this.Symbol.Margin = new System.Windows.Forms.Padding(0);
            this.Symbol.MaxLength = 3;
            this.Symbol.Name = "Symbol";
            this.Symbol.ReadOnly = true;
            this.Symbol.Size = new System.Drawing.Size(30, 13);
            this.Symbol.TabIndex = 0;
            this.Symbol.TabStop = false;
            this.Symbol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Symbol.MouseDown += CaretHider;
            this.Symbol.MouseDown += ViewLocker;
            this.Symbol.MouseEnter += EnterHandler;
            this.Symbol.MouseLeave += ExitHandler;

            this.AtomicNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.AtomicNumber.BackColor = System.Drawing.SystemColors.Control;
            this.AtomicNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AtomicNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AtomicNumber.Location = new System.Drawing.Point(10, 20);
            this.AtomicNumber.MaxLength = 3;
            this.AtomicNumber.Name = "AtomicNumber";
            this.AtomicNumber.ReadOnly = true;
            this.AtomicNumber.Size = new System.Drawing.Size(22, 11);
            this.AtomicNumber.TabIndex = 0;
            this.AtomicNumber.TabStop = false;
            this.AtomicNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AtomicNumber.MouseDown += CaretHider;
            this.AtomicNumber.MouseDown += ViewLocker;
            this.AtomicNumber.MouseEnter += EnterHandler;
            this.AtomicNumber.MouseLeave += ExitHandler;
        }


        public void Highlight()
        {
            this.Symbol.ForeColor = ElementDatabase.HighlightTextColor;
            this.AtomicNumber.ForeColor = ElementDatabase.HighlightTextColor;
            this.BackColor = ElementDatabase.HightlightBackColor;
            this.BorderColor = ElementDatabase.HightlightBorderColor;
            this.BorderThickness = 2;

        }
        public void Restore()
        {
            this.Symbol.ForeColor = ElementDatabase.NormalTextColor;
            this.AtomicNumber.ForeColor = ElementDatabase.NormalTextColor;
            this.BackColor = ElementDatabase.GetNormalBackColor(element.GetType());
            this.BorderColor = ElementDatabase.NormalBorderColor;
            this.BorderThickness = 1;
        }
        public void DeHightlight()
        {
            this.Symbol.ForeColor = ElementDatabase.DeHightlightTextColor;
            this.AtomicNumber.ForeColor = ElementDatabase.DeHightlightTextColor;
            this.BackColor = ElementDatabase.DehighlightBackColor;
            this.BorderColor = ElementDatabase.DeHightlightBorderColor;
            this.BorderThickness = 1;
        }


        public void TryMakeActive()
        {
            if (!activated)
            {
                if (MainWindow.selectedElement != null)
                {
                    MainWindow.selectedElement.TryMakeUnactive();
                    MainWindow.selectedElement = null;
                }

                if (this.element != null)
                {
                    ActivationActions();
                    activated = true;
                    MainWindow.selectedElement = this;
                }
            }
        }
        public void TryMakeUnactive()
        {
            if (activated)
            {
                DeactivationActions();
                activated = false;
                MainWindow.selectedElement = null;
            }
        }

        public void ActivationActions()
        {
            Highlight();
            foreach (GroupBox g in MainWindow.GroupBoxes.Values)
            {
                bool match = false;
                foreach (Type thistype in ElementDatabase.ClassificatonTrees[element.GetType()])
                {
                    if (g.classification == thistype)
                    {
                        match = true;
                        break;
                    }
                }
                if (match)
                    g.Highlight();
                else
                    g.DeHightlight();
            }
            if(!MainWindow.viewBox.Locked)
                MainWindow.viewBox.SetElement(element);
            MainWindow.MainWindowObject.Text = "Atomizer - " + element.Name;
        }
        public void DeactivationActions()
        {
            Restore();
            foreach (GroupBox g in MainWindow.GroupBoxes.Values)
                g.Restore();
            if (!MainWindow.viewBox.Locked)
                MainWindow.viewBox.ClearElement();
            MainWindow.MainWindowObject.Text = "Atomizer";
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            TryMakeActive();
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);

            if (!this.ClientRectangle.Contains(PointToClient(Control.MousePosition)))
                TryMakeUnactive();
        }

        public void SetElement(Element element)
        {
            this.element = element;
            this.Symbol.Text = element.Symbol;
            this.AtomicNumber.Text = element.AtomicNumber.ToString();
            this.BackColor = ElementDatabase.GetNormalBackColor(element.GetType());

            element.Control = this;
        }

        private void EnterHandler(object sender, System.EventArgs e)
        {
            TryMakeActive();
        }
        private void ExitHandler(object sender, System.EventArgs e)
        {
            if (!this.ClientRectangle.Contains(PointToClient(Control.MousePosition)))
                TryMakeUnactive();
        }

        private void CaretHider(Object sender, MouseEventArgs e)
        {
            MainWindow.HideCaret(this.Symbol.Handle);
            MainWindow.HideCaret(this.AtomicNumber.Handle);
        }

        private void ViewLocker(Object sender, MouseEventArgs e)
        {
            if (MainWindow.viewBox.Element == element && MainWindow.viewBox.Locked)
                MainWindow.viewBox.Locked = false;
            else
            {
                MainWindow.viewBox.Locked = true;
                MainWindow.viewBox.SetElement(element);
            }
        }

        protected override void OnBackColorChanged(EventArgs e)
        {
            base.OnBackColorChanged(e);

            this.Symbol.BackColor = BackColor;
            this.AtomicNumber.BackColor = BackColor;
        }
    }
}
