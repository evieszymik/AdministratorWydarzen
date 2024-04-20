namespace AdministratorWydarzen
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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var view = new EventView();
            var model = new Model.EventManager();
            var presenter = new Presenter.EventPresenter(view,model);
            Application.Run(view);
        }
    }
}