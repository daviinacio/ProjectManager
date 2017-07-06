using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Manager {
    static class Program {
        public static Color backColor = ColorTranslator.FromHtml("#202020"), foreColor = Color.White, borderColor = Color.Turquoise;
        public static Projects projects;
        public static ProjectStarter projectStarter;

        public static String appdataFolder = (Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\DaviApps\\Project Manager\\");

        public static bool topMost = false;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args) {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            projects = new Projects();
            projectStarter = new ProjectStarter();

            if (!Directory.Exists(appdataFolder))
                Directory.CreateDirectory(appdataFolder);

            //MessageBox.Show(args[0]);

            if (args.Length >= 1) {
                //MessageBox.Show(args[0]);
                FileInfo file = new FileInfo(args[0]);
                if (file.Exists) {
                    //MessageBox.Show("Exists");
                    projectStarter = new ProjectStarter();
                    projectStarter.setProject(args[0]);
                    Application.Run(projectStarter);
                }
            } else
                Application.Run(projects);
        }
    }
}
