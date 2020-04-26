using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;

namespace Algs4Lib
{
    public class StdDraw
    {
        private static Form form;
        public static Thread guiThread;

        //static StdDraw()
        //{
        //    init();
        //}

        public static void init()
        {
            
            guiThread = new Thread(guiStart);
            guiThread.Name = "guiThread";
            //guiThread.IsBackground = true;
            guiThread.Start(form);            
        }

        private static void guiStart(object form)
        {
            
            //if (form != null)
            //    form.Visible = false;
            var newForm = new Form();
            newForm.Visible = true;
            Application.Run(newForm);
        }

        public static void line(float x0, float y0, float x1, float y1)
        {
            if (guiThread == null) init();
            //Graphics g = form.CreateGraphics();

            //g.DrawLine(Pens.White, x0, y0, x1, y1);
        }
    }
}
