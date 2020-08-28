using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Z13_DI
{
    public class PanelFiller : IPanelFiller
    {
        private readonly IControlGenerator controlGenerator;
        private readonly IDataProvider dataProvider;
        public PanelFiller(IControlGenerator controlGeneratorOut, IDataProvider dataProviderOut)
        {
            controlGenerator = controlGeneratorOut;
            dataProvider = dataProviderOut;
        }
        public void Fill(Panel panel)
        {
            var number = dataProvider.GetData();

            for (int i = 0; i < number; i++)
            {
                panel.Children.Add(controlGenerator.Generate());
            }
        }
    }
}
