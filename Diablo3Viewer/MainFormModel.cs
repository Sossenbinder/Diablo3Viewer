using Diablo3Viewer.DataFetcher;
using Diablo3Viewer.DataInterpreters;
using Diablo3Viewer.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diablo3Viewer
{
    class MainFormModel
    {
        CareerProfileData cpd;

        public void startLoadingProcess()
        {
            ChampionFetcher cf = new ChampionFetcher(cpd);
            cf.fetchData();

        }

        public void validateProfile()
        {
            CareerProfileFetcher cpf = new CareerProfileFetcher();
            if (cpf.fetchData())
            {
                cpd = cpf.getModel();
                startLoadingProcess();
            }
            else
            {
                MessageBox.Show(
                    "Character couldn't be found. Please check your entered data again.",
                    "Character not found.",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1
                );
            }

        }
    }
}
