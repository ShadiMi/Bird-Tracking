namespace Final_Project_205674047_208078212
{
    enum cageType
    {
        METAL,WOOD,PLASTIC
    }

    public class Habitat
    {
        private  Bird bird;
        private Cage cage;
    }
    public class Bird
    {
        public int BirdSN { get; set; }
        public string Species { get; set; }
        public string Subspecies { get; set; }
        public DateTime HatchingDate { get; set; }
        public string Gender { get; set; }
        public string CageNumber { get; set; }
        public int FatherSerialNumber { get; set; }
        public int MotherSerialNumber { get; set; }

    }
    public class Cage
    {
        string CageSerialNum;
        double height;
        double width;
        cageType cageType;
    }



    internal static class Program
    {
        private static Login loginForm;

        // Rest of the code...

        public static Login GetLoginForm()
        {
            return loginForm;
        }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Call SetCompatibleTextRenderingDefault method here
            Application.SetCompatibleTextRenderingDefault(false);

            // Create the login form
            loginForm = new Login();

            Application.Run(loginForm);
        }
    }
}