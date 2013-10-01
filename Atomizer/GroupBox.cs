using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Atomizer
{
    public class GroupBox : BorderedPanel, Activatable
    {
        public Type classification;
        private System.Windows.Forms.TextBox text;

        private bool activated = false;

        public GroupBox()
            : base()
        {
            this.SetStyle(ControlStyles.UserPaint, true);

            this.Margin = new System.Windows.Forms.Padding(0);
            this.Size = new System.Drawing.Size(107, 15);
            this.TabIndex = 0;

            this.text = new System.Windows.Forms.TextBox();
            this.Controls.Add(this.text);

            this.text.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.text.BackColor = System.Drawing.SystemColors.Control;
            this.text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text.Location = new System.Drawing.Point(1,1);
            this.text.Margin = new System.Windows.Forms.Padding(0);
            this.text.Name = "text";
            this.text.ReadOnly = true;
            this.text.Size = new System.Drawing.Size(105, 13);
            this.text.TabIndex = 0;
            this.text.TabStop = false;
            this.text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.text.MouseDown += CaretHider;
            this.text.MouseEnter += EnterHandler;
            this.text.MouseLeave += ExitHandler;
        }


        public void Highlight()
        {
            this.text.ForeColor = ElementDatabase.HighlightTextColor;
            this.BackColor = ElementDatabase.HightlightBackColor;
            this.BorderColor = ElementDatabase.HightlightBorderColor;
            this.BorderThickness = 2;

        }
        public void Restore()
        {
            this.text.ForeColor = ElementDatabase.NormalTextColor;
            this.BackColor = ElementDatabase.GetNormalBackColor(classification);
            this.BorderColor = ElementDatabase.NormalBorderColor;
            this.BorderThickness = 1;
        }
        public void DeHightlight()
        {
            this.text.ForeColor = ElementDatabase.DeHightlightTextColor;
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

                if (this.classification != null)
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
            foreach (Element e in ElementDatabase.elementList)
            {
                bool match = false;
                foreach (Type thistype in ElementDatabase.ClassificatonTrees[e.GetType()])
                {
                    if (classification == thistype)
                    {
                        match = true;
                        break;
                    }
                }
                if (!match)
                    e.Control.DeHightlight();
            }
            foreach (GroupBox g in MainWindow.GroupBoxes.Values)
            {
                bool match = false;
                foreach (Type thistype in ElementDatabase.ClassificatonTrees[classification])
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
        }
        public void DeactivationActions()
        {
            foreach (Element e in ElementDatabase.elementList)
                e.Control.Restore();
            foreach (GroupBox g in MainWindow.GroupBoxes.Values)
                g.Restore();
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

        public void SetClassification(Type type)
        {
            this.classification = type;
            if (type == typeof(Metal))
                this.text.Text = "Metals";
            else if (type == typeof(AlkaliMetal))
                this.text.Text = "Alkali Metals";
            else if (type == typeof(AlkalineEarthMetal))
                this.text.Text = "Alkaline Earth Metals";
            else if (type == typeof(RareEarthMetal))
                this.text.Text = "Rare Earth Metals";
            else if (type == typeof(Lanthanide))
                this.text.Text = "Lanthanides";
            else if (type == typeof(Actinide))
                this.text.Text = "Actinides";
            else if (type == typeof(TransitionMetal) || type == typeof(CoinageMetal) || type == typeof(VolatileMetal))
                this.text.Text = "Transition Metals";
            else if (type == typeof(PostTransitionMetal))
                this.text.Text = "Post-transition Metals";
            else if (type == typeof(Metalloid))
                this.text.Text = "Metalloids";
            else if (type == typeof(NonMetal))
                this.text.Text = "Nonmetals";
            else if (type == typeof(OtherNonMetal))
                this.text.Text = "Other Nonmetals";
            else if (type == typeof(NobleGas))
                this.text.Text = "Noble Gases";
            else if (type == typeof(Halogen))
                this.text.Text = "Halogens";
            else
                this.text.Text = "Invalid Type";

            this.BackColor = ElementDatabase.GetNormalBackColor(classification);
            this.text.BackColor = BackColor;
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
            MainWindow.HideCaret(this.text.Handle);
        }

        protected override void OnBackColorChanged(EventArgs e)
        {
            base.OnBackColorChanged(e);

            this.text.BackColor = BackColor;
        }
    }
}
