using Project_Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

public abstract class FormUtils {
    double defaultOpct = 0.85;
    int opct = 0;

    // Fade methods

    void fadeUp(int delay, int increment) {
        while (opct < defaultOpct) {
            setOpacity(opct + increment);
            Thread.Sleep(delay);
        }
    }
    void fadeDown(int delay, int decrement) {
        while (opct > 20) {
            setOpacity(opct - decrement);
            Thread.Sleep(delay);
        }
    }
    void setOpacity(int opacity) {
        this.opct = opacity;
        updateOpacity();
    }

    void updateOpacity();
    
}

