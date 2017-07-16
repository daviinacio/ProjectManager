using Project_Manager;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ProjectItem {
    private static String localPathChar = "$";
    private static char filesSeparator = '|';

    private IniFile configFile;
    private String file;

    private List<String> files;

    public ProjectItem() {
        file = "";
        files = new List<String>();
    }

    public ProjectItem(String file) {
        create(file);

        // Load files
        files = new List<String>();

        if (!configFile.Read("Files").Equals("")) {
            String[] fs = configFile.Read("Files").Split(filesSeparator);

            foreach (String f in fs)
                files.Add(f);
        }

        this.file = file;
    }

    public void create(String file) {
        this.file = file;
        if (file != null) {
            configFile = new IniFile(file);
            configFile.Add("Name", "projectname");
            configFile.Add("Icon", localPathChar + "\\icon.bmp");
            configFile.Add("Files", "");
        }
    }

    public void saveFiles() {
        if (file != null) {
            String fs = "";
            for (int i = 0; i < files.Count; i++) {
                fs += files.ToArray()[i].Replace(getPath(), localPathChar);
                if (i >= files.Count - 1) continue;
                fs += filesSeparator;
            }
            configFile.Write("Files", fs);
            //PrMessageBox.Show("Files", fs);
        }
    }

    public void setName(String name) {
        configFile.Write("Name", name); 
    }
    public String getName() {
        return configFile.Read("Name");
    }

    public void setIcon(String icon) {
        configFile.Write("Icon", icon.Replace(getPath(), localPathChar));
    }
    public String getIcon() {
        return configFile.Read("Icon").Replace(localPathChar, getPath());
    }

    public String getProjectFile() {
        return file;
    }
    public void setProjectFile(String file) {
        this.file = file;
    }
        
    public String getPath() {
        return Path.GetDirectoryName(file).Replace('/', '\\');
    }

    // Files
    public int getFilesCount() {
        return files.Count;
    }

    public List<String> getFilesList() {
        return files;
    }

    public String getFile(int i) {
        if (this.file != "")
            return files.ToArray()[i].Replace(localPathChar, getPath());
        else
            return files.ToArray()[i];
    }

    public void addFile(String file) {
        files.Add(file); //saveFiles();
    }

    public void removeFile(int i) {
        files.RemoveAt(i); //saveFiles();
    }

    public void removeFile(String file) {
        files.Remove(file); //saveFiles();
    }
        
}
