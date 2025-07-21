using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_Winform.Helpers
{
    public static class LayoutDefault
    {
        public static void ConfigureFormLayout(Form form, Label labelHelloUser, Button backButton, Button buttonRealtime)
        {
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Size = new Size(800, 600);
            form.MaximumSize = form.Size;
            form.MinimumSize = form.Size;

            labelHelloUser.Text = $"Hello, {Current.Username}!";
            labelHelloUser.Location = new Point(form.ClientSize.Width - labelHelloUser.Width - 20, 20);
            labelHelloUser.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            backButton.FlatStyle = FlatStyle.Flat;
            backButton.Location = new Point(20, form.ClientSize.Height - backButton.Height - 20);
            backButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            
            buttonRealtime.Location = new Point(20, 20);
            buttonRealtime.Anchor = AnchorStyles.Top | AnchorStyles.Left;

        }

        public static void ConfigureLayoutB(Form form)
        {
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Size = new Size(800, 600);
            form.MaximumSize = form.Size;
            form.MinimumSize = form.Size;

        }
    }
}
