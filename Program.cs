namespace Students_Record_App
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
            //Student newStudent = new Student("John", "Doe", "Male", 25, "Class A", "123 Main St");
            Application.Run(new Our_Students());
           // Application.Run(new Add_Edit_Students());
        }
    }
}