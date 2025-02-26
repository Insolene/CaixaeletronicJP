namespace $safeprojectname$
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }

        public static void DecNumber(object sender , KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 44) 
                e.Handled = true;
            else if (e.KeyChar == 44)
            {
                TextBox txt = (TextBox)sender;
                if (txt.Text.Contains(","))
                    e.Handled = true;
            }
        }
    }
}