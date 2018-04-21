using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvLib
{
    // TODO:間違い
    public class Window
    {
        /// <summary>
        /// https://developer.mozilla.org/ja/docs/Web/API/console
        /// </summary>
        public class ConsoleObj
        {
            public void log(string message) { }
        }

        public bool closed;

        public ConsoleObj console = new ConsoleObj();

        /// <summary>
        /// Living Standard https://developer.mozilla.org/ja/docs/Web/API/GlobalEventHandlers/onclick デスクトップ〇　スマホ？
        /// </summary>
        public Action onclick;

        public Action onload;
    }
}
