using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Manager {
    class ProjectItem {
        //private static String configFileName = "\\config.prini";
        private IniFile configFile;
        private String file;

        public ProjectItem(String file) {
            configFile = new IniFile(file);
            configFile.Add("Name", "projectname");
            configFile.Add("Icon", "{0}\\icon.bmp");

            this.file = file;
        }

        public void setName(String name) {
            configFile.Write("Name", name); 
        }
        public String getName() {
            return configFile.Read("Name");
        }

        public void setIcon(String icon) {
            configFile.Write("Icon", icon);
        }
        public String getIcon() {
            //return path + "/" + configFile.Read("Icon");
            return String.Format(configFile.Read("Icon"), getPath());
        }

        public void setFile(String file) {
            this.file = file;
            configFile = new IniFile(file);
        }
        public String getPath() {
            return Path.GetDirectoryName(file);
        }

        public String getFile() {
            return file;
        }
    }
}
