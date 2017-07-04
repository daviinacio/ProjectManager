using Project_Manager;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ProjectItem {
    private static String localPathChar = "$";
    private static char filesSeparator = '|';

    private IniFile configFile;
    private String file;

    private List<String> files;

    public ProjectItem(String file) {
        configFile = new IniFile(file);
        configFile.Add("Name", "projectname");
        configFile.Add("Icon", localPathChar + "\\icon.bmp");
        configFile.Add("Files", "");

        // Load files
        files = new List<String>();

        if (!configFile.Read("Files").Equals("")) {
            String[] fs = configFile.Read("Files").Split(filesSeparator);

            foreach (String f in fs)
                files.Add(f);
        }

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
        //return String.Format(configFile.Read("Icon"), getPath());
        return configFile.Read("Icon").Replace(localPathChar, getPath());
    }

    /*public void setPFile(String file) {
        this.file = file;
        configFile = new IniFile(file);
    }
    public String getPFile() {
        return file;
    }*/

    public String getProjectFile() {
        return file;
    }
        
    public String getPath() {
        return Path.GetDirectoryName(file) + '\\';
    }

    // Files
    public int getFilesCount() {
        return files.Count;
    }

    public List<String> getFilesList() {
        return files;
    }

    public String getFile(int i) {
        return files.ToArray()[i].Replace(localPathChar, getPath());;
    }

    public void addFile(String file) {
        files.Add(file);
    }

    public void removeFile(int i) {
        files.RemoveAt(i);
    }

    public void removeFile(String file) {
        files.Remove(file);
    }
        
}
