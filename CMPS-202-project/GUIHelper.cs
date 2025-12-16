using System.Drawing;
using System.Windows.Forms;

namespace CMPS_202_project
{
    public static class GUIHelper
    {
        // Color Palette
        private static readonly Color BackgroundColor = Color.FromArgb(30, 30, 30); // Dark Grey
        private static readonly Color ControlColor = Color.FromArgb(50, 50, 50);    // Lighter Grey
        private static readonly Color TextColor = Color.White;
        private static readonly Color AccentColor = Color.FromArgb(220, 20, 60);    // Crimson / Modern Red

        public static void ApplyModernStyle(Form form)
        {
            form.BackColor = BackgroundColor;
            form.ForeColor = TextColor;

            // CHANGED: Use form.Font.Size instead of hardcoded 10
            form.Font = new Font("Segoe UI", form.Font.Size, FontStyle.Regular);

            foreach (Control c in form.Controls)
            {
                StyleControl(c);
            }
        }

        private static void StyleControl(Control c)
        {
            // 1. Style Buttons
            if (c is Button btn)
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.BackColor = AccentColor;
                btn.ForeColor = Color.White;
                btn.Cursor = Cursors.Hand;

                // CHANGED: Use btn.Font.Size instead of hardcoded 10
                btn.Font = new Font("Segoe UI", btn.Font.Size, FontStyle.Bold);

                // Red Hover Effect
                btn.MouseEnter += (s, e) => btn.BackColor = Color.FromArgb(255, 70, 70);
                btn.MouseLeave += (s, e) => btn.BackColor = AccentColor;
            }
            // 2. Style Links ("Don't have an account?")
            else if (c is LinkLabel link)
            {
                link.LinkColor = AccentColor;
                link.ActiveLinkColor = Color.Red;
                link.VisitedLinkColor = AccentColor;
                link.LinkBehavior = LinkBehavior.HoverUnderline;

                // Ensure LinkLabel also uses Segoe UI but keeps its size
                link.Font = new Font("Segoe UI", link.Font.Size, link.Font.Style);
            }
            // 3. Style TextBoxes
            else if (c is TextBox txt)
            {
                txt.BorderStyle = BorderStyle.FixedSingle;
                txt.BackColor = ControlColor;
                txt.ForeColor = Color.White;
                txt.Font = new Font("Segoe UI", txt.Font.Size, FontStyle.Regular);
            }
            // 4. Style ComboBoxes
            else if (c is ComboBox box)
            {
                box.FlatStyle = FlatStyle.Flat;
                box.BackColor = ControlColor;
                box.ForeColor = Color.White;
                box.Font = new Font("Segoe UI", box.Font.Size, FontStyle.Regular);
            }
            // 5. Style DataGridView (Tables)
            else if (c is DataGridView dgv)
            {
                dgv.BackgroundColor = BackgroundColor;
                dgv.BorderStyle = BorderStyle.None;
                dgv.EnableHeadersVisualStyles = false;

                // Header Style (Red)
                dgv.ColumnHeadersDefaultCellStyle.BackColor = AccentColor;
                dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", dgv.Font.Size, FontStyle.Bold);

                // Row Style
                dgv.DefaultCellStyle.BackColor = BackgroundColor;
                dgv.DefaultCellStyle.ForeColor = Color.White;
                dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 70, 70);
                dgv.DefaultCellStyle.SelectionForeColor = Color.White;
                dgv.DefaultCellStyle.Font = new Font("Segoe UI", dgv.Font.Size, FontStyle.Regular);
            }
            // 6. Style Labels
            else if (c is Label lbl)
            {
                lbl.ForeColor = TextColor;
                lbl.Font = new Font("Segoe UI", lbl.Font.Size, lbl.Font.Style);
            }

            // Recursively apply to containers
            if (c.HasChildren)
            {
                foreach (Control child in c.Controls)
                {
                    StyleControl(child);
                }
            }
        }
    }
}