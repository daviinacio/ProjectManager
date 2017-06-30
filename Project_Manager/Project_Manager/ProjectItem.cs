using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Manager {
    class ProjectItem {
        private IniFile configFile;
        private String path;

        public ProjectItem(String path) {
            configFile = new IniFile(@path + "/config.ini");
            configFile.Add("Name", "projectname");
            configFile.Add("Icon", "icon.bmp");

            this.path = path;
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
            return path + "/" + configFile.Read("Icon");
        }

        public void setPath(String path) {
            this.path = path;
        }
        public String getPath() {
            return path;
        }
    }
}
