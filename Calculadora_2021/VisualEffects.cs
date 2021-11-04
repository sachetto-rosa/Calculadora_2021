using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Calculadora_2021
{
    class VisualEffects
    {
        public delegate void ChangeColorDelegate(object sender, EventArgs args);
        public event ChangeColorDelegate ChangeColor;

        public void doVisualEffects()
        {
            while (true)
            {
                if (ChangeColor != null)
                {
                    ChangeColor(this, EventArgs.Empty);
                }
                Thread.Sleep(3000);
            }
        }
    }
}
