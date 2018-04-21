using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvLib
{
    public class MvFramework
    {
        public Window getSceneWindow(string windowName)
        {
            MvLib_SceneManager manager = new MvLib_SceneManager();
            return manager.getSceneWindow(windowName);
        }
    }
}
